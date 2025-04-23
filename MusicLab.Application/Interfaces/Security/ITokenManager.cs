using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLab.Application.Interfaces.Security
{
    public interface ITokenManager
    {
        string CreateToken(int id, string email, string role);
        int ValidateTokenWithoutLifetime(string token);
        
    }
}
