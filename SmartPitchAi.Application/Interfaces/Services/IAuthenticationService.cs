using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPitchAi.Application.Interfaces.Services
{
    public interface IAuthenticationService
    {
        public string GenerateAuthenticationToken(string userId);
        public bool IsTokenExists(string token);
    }
}
