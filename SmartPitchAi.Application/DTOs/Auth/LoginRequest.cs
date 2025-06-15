using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPitchAi.Application.DTOs.Auth
{
    public class LoginRequest
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        //public bool RememberMe { get; set; } = false;
        //public string? RecaptchaToken { get; set; } // For reCAPTCHA validation
    }
}
