using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class DatModel
    {
        private Int64 _id;
        private string _archivo;
        private string _sector;
        private string _error;
        private string _observacion;

        public DatModel(long id, string archivo, string sector, string error, string observacion)
        {
            Id = id;
            Archivo = archivo;
            Sector = sector;
            Error = error;
            Observacion = observacion;            
        }
        public DatModel( string archivo, string sector, string error, string observacion)
        {
            
            Archivo = archivo;
            Sector = sector;
            Error = error;
            Observacion = observacion;
        }

        public long Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Archivo
        {
            get
            {
                return _archivo;
            }

            set
            {
                _archivo = value;
            }
        }

        public string Sector
        {
            get
            {
                return _sector;
            }

            set
            {
                _sector = value;
            }
        }

        public string Error
        {
            get
            {
                return _error;
            }

            set
            {
                _error = value;
            }
        }

        public string Observacion
        {
            get
            {
                return _observacion;
            }

            set
            {
                _observacion = value;
            }
        }
    }
}
