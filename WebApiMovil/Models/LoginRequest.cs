using System.ComponentModel.DataAnnotations;

namespace WebApiMovil.Models
{
    public class LoginRequest
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string imei { get; set; }
        [Required]
        public string version { get; set; }
        [Required]
        public string buildNumber { get; set; }
    }
}
