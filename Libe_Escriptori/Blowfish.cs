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
            contraEncriptada = BCrypt.HashPassword(contrasenya);
            return contraEncriptada;
        }
        public static Boolean verificarContra(String contraEncriptada, String contraUser)
        {
            Boolean validPass = BCrypt.Verify(contraEncriptada, contraUser);
            return validPass;
        }
    }
}
