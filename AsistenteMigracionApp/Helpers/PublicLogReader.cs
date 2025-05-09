using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenteMigracionApp.Helpers
{
    public class PublicLogReader
    {
        private readonly string _rutaLog;
        private int _filasLeidas;

        public PublicLogReader(string rutaLog)
        {
            _rutaLog = rutaLog;
            _filasLeidas = 0;
        }

        public DataTable LeerLog()
        {
            var tabla = new DataTable();
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Tipo");
            tabla.Columns.Add("Mensaje");

            if (!File.Exists(_rutaLog))
                return tabla;

            try
            {
                using (var fs = new FileStream(_rutaLog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        var linea = sr.ReadLine();
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        var partes = linea.Split('|');
                        if (partes.Length < 3) continue;

                        tabla.Rows.Add(partes[0], partes[1], string.Join("|", partes.Skip(2)));
                    }
                }

                _filasLeidas = tabla.Rows.Count;
                return tabla;
            }
            catch
            {
                return tabla; // Devuelve tabla vacía ante errores
            }
        }

        public bool HaCambiado()
        {
            try
            {
                int totalLineas = File.ReadLines(_rutaLog).Count();
                return totalLineas != _filasLeidas;
            }
            catch
            {
                return false;
            }
        }
    }
}
