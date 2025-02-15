using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAO;

namespace Domain.Service
{
    public class SectoresService
    {
        private readonly SectoresDao sectores = new SectoresDao();

        public async Task<string[]> GetSectores()
        {
            return await sectores.GetSectores();
        }
    }
}
