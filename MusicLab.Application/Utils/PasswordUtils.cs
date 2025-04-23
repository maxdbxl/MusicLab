using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MusicLab.Application.Utils
{
    public static class PasswordUtils
    {
        public static string HashPassword(string password, Guid salt)
        {
            return Encoding.UTF8.GetString(SHA512.HashData
                (Encoding.UTF8.GetBytes(password + salt)));

        }
            
    }
}
