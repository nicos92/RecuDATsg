using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class DatCache
    {
        // id, archivoDAT, error, observacion,
        public static Int64 Id { get; set; }
        public static string Sector {  get; set; }
        public static string Archivo { get; set; }
        public static string Error { get; set; }
        public static string Observacion { get; set; }
    }
}
