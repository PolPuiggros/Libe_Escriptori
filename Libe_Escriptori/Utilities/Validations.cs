using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libe_Escriptori.Utilities
{
    public static class Validations
    {
        public static bool CheckDNI(string dni)
        {
            //Es comprova si el DNI té 9 xifres/characters
            if (dni.Length != 9)
            {
                //DNI invàlid
                return false;
            }

            //Extraction de números
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            //Extraction de lletra
            string dniLeter = dni.Substring(dni.Length - 1, 1);

            //Convertir els números a INT
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No es pot convertir a INT
                return false;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La lletra no és correcta
                return false;
            }
            //DNI VALID
            return true;
        }


        public static string CalculateDNILeter(int dniNumbers)
        {
            //Carreguem els digits de control en un array d'strings
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            //Calcul que verifica que sigui correcte la lletra
            var mod = dniNumbers % 23;
            return control[mod];
        }

        public static bool CheckPhone(string phone)
        {
            //Es comprova si el telefon té 9 xifres/characters
            if (phone.Length != 9)
            {
                //Phone invàlid
                return false;
            }
            //Mirem si el número comença per 6,7,8 o 9
            if (!phone.StartsWith("6") && !phone.StartsWith("7") && !phone.StartsWith("8") && !phone.StartsWith("9"))
            {
                //Phone invàlid
                return false;
            }
            //Convertir els números a INT
            var numbersValid = int.TryParse(phone, out int phoneInteger);
            if (!numbersValid)
            {
                //No es pot convertir a INT, Phone invàlid
                return false;
            }
            return true;
        }

        public static bool CheckEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Verificar si el correo electrónico cumple con el formato adecuado
            Match match = Regex.Match(email, pattern);

            // Devolver true si el correo electrónico es válido, de lo contrario false
            return match.Success;
        }
    }
}
