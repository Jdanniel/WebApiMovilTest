using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiMovil.Models;

namespace WebApiMovil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CUsuariosController : ControllerBase
    {
        private readonly ELAVONTESTContext _context;

        public CUsuariosController(ELAVONTESTContext context)
        {
            _context = context;
        }

        // GET: api/CUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CUsuarios>>> GetCUsuarios()
        {
            return await _context.CUsuarios.ToListAsync();
        }

        // GET: api/CUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CUsuarios>> GetCUsuarios(int id)
        {
            var cUsuarios = await _context.CUsuarios.FindAsync(id);

            if (cUsuarios == null)
            {
                return NotFound();
            }

            return cUsuarios;
        }

        [HttpPost("LoginRequest")]
        public async Task<ActionResult> GetLoginRequest(LoginRequest req)
        {
            if (req == null) return BadRequest("No se ingresaron los datos solicitados");

            try
            {
                var dataApp = await _context.BdApplicationVersions.Where(x => x.Status).FirstOrDefaultAsync();
                if(dataApp.BuildNumber == req.buildNumber && dataApp.Version == req.version)
                {
                    int idusuario = await _context.CUsuarios.Where(x => x.Username == req.username).Select(x => x.IdUsuario).SingleOrDefaultAsync();
                    var usuario = await _context.CUsuarios.Where(x => x.IdUsuario == idusuario).SingleOrDefaultAsync();
                    var UsuarioPhone = _context.BdUsuarioCelular.Where(x => x.IdUsuario == idusuario).FirstOrDefault();

                    if (UsuarioPhone != null)
                    {
                        if (UsuarioPhone.Imei != req.imei)
                        {
                            if (UsuarioPhone.Imei == null)
                            {
                                UsuarioPhone.Imei = req.imei;
                                _context.SaveChanges();
                            }
                            else
                            {
                                return NotFound(new { Texterror = "IMEI" });
                            }
                        }
                    }
                    else
                    {
                        BdUsuarioCelular celular = new BdUsuarioCelular()
                        {
                            IdUsuario = idusuario,
                            IdUsuarioAlta = 559,
                            FecAlta = DateTime.Now,
                            Imei = req.imei
                        };
                        _context.BdUsuarioCelular.Add(celular);
                        _context.SaveChanges();
                    }

                    if (usuario == null)
                    {
                        return NotFound();
                    }

                    SpGetPassword pw = await _context.Query<SpGetPassword>().FromSql("EXEC SP_GET_PASSWORD @p0", idusuario).SingleOrDefaultAsync();

                    if (usuario.IsPda != 1)
                    {
                        return NotFound(new { Texterror = "El usuario no es PDA" });
                    }

                    if (!req.password.Equals(pw.pw))
                    {
                        return NotFound();
                    }

                    BdBitacoraAcceso acceso = new BdBitacoraAcceso()
                    {
                        IdUsuario = idusuario,
                        Acceso = DateTime.Now,
                        FecStatus = DateTime.Now,
                        Status = "ACTIVO",
                        IpCliente = req.imei,
                        Host = "ACCESO APLICACION"
                    };
                    _context.BdBitacoraAcceso.Add(acceso);
                    await _context.SaveChangesAsync();
                    return Ok(new { user = usuario.Nombre + " " + usuario.Paterno + " " + usuario.Materno, idusuario = usuario.IdUsuario });
                }
                else
                {
                    return BadRequest(new { Texterror = "VERSION"});
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.StackTrace);
            }

        }

        // PUT: api/CUsuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCUsuarios(int id, CUsuarios cUsuarios)
        {
            if (id != cUsuarios.IdUsuario)
            {
                return BadRequest();
            }

            _context.Entry(cUsuarios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CUsuariosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CUsuarios
        [HttpPost]
        public async Task<ActionResult<CUsuarios>> PostCUsuarios(CUsuarios cUsuarios)
        {
            _context.CUsuarios.Add(cUsuarios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCUsuarios", new { id = cUsuarios.IdUsuario }, cUsuarios);
        }

        // DELETE: api/CUsuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CUsuarios>> DeleteCUsuarios(int id)
        {
            var cUsuarios = await _context.CUsuarios.FindAsync(id);
            if (cUsuarios == null)
            {
                return NotFound();
            }

            _context.CUsuarios.Remove(cUsuarios);
            await _context.SaveChangesAsync();

            return cUsuarios;
        }

        private bool CUsuariosExists(int id)
        {
            return _context.CUsuarios.Any(e => e.IdUsuario == id);
        }

        private bool UsernameExists(string username)
        {
            return _context.CUsuarios.Any(u => u.Username == username);
        }
    }
}
