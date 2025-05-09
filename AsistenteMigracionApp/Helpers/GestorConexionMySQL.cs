using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsistenteMigracionApp.Helpers;

namespace AsistenteMigracionApp.Helpers
{
    public class GestorConexionMySQL
    {
        
        public static void GuardarConexionMySQL(string servidor, string puerto, string usuario, string password, string baseDatos)
        {
            GuardarValor("Server", Encriptacion.Encrypt(servidor));
            GuardarValor("Port", Encriptacion.Encrypt(puerto));
            GuardarValor("User", Encriptacion.Encrypt(usuario));
            GuardarValor("Password", Encriptacion.Encrypt(password));
            GuardarValor("Database", Encriptacion.Encrypt(baseDatos));
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static (string Server, string Port, string User, string Password, string Database) CargarConexion()
        {
            return (
                Encriptacion.DecryptSafe(ConfigurationManager.AppSettings["Server"]),
                Encriptacion.DecryptSafe(ConfigurationManager.AppSettings["Port"]),
                Encriptacion.DecryptSafe(ConfigurationManager.AppSettings["User"]),
                Encriptacion.DecryptSafe(ConfigurationManager.AppSettings["Password"]),
                Encriptacion.DecryptSafe(ConfigurationManager.AppSettings["Database"])
            );
        }

        private static void GuardarValor(string clave, string valor)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[clave] != null)
                config.AppSettings.Settings[clave].Value = valor;
            else
                config.AppSettings.Settings.Add(clave, valor);
            config.Save(ConfigurationSaveMode.Modified);
        }

    }
}
