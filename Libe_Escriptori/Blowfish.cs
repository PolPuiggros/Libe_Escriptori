using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libe_Escriptori
{
    using BCrypt.Net;
    public static class Blowfish
    {
        public static String encriptarContrasenya(String contrasenya)
        {
            String contraEncriptada;
            return contraEncriptada = BCrypt.HashPassword(contrasenya);
        }
        public static bool verificarContra(string contraEncriptada, string contraUser)
        {
            bool validPass;
            return validPass = BCrypt.Verify(contraUser, contraEncriptada);
        }
    }
}
