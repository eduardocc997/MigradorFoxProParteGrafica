using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsistenteMigracionApp.Helpers
{
    public static class Encriptacion
    {
        private static readonly string key = "e!2@z#6Xp$9Vg^1H"; // 🔒 16 chars = 128-bit key (usa una distinta)
        private static readonly string iv = "1Hbfh667adfDEJ78";  // 🔐 16 chars = 128-bit IV

        public static string Encrypt(string textoPlano)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = Encoding.UTF8.GetBytes(iv);
                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                using (var sw = new StreamWriter(cs))
                {
                    sw.Write(textoPlano);
                    sw.Close();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string DecryptSafe(string textoCifrado)
        {
            if (string.IsNullOrEmpty(textoCifrado)) return "";
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = Encoding.UTF8.GetBytes(iv);
                    using (var ms = new MemoryStream(Convert.FromBase64String(textoCifrado)))
                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    using (var sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch
            {
                return ""; // Retorna vacío si hay error de descifrado
            }
        }
    }
}
