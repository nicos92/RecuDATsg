using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.DAO;
using Common.Models;

namespace Domain.Service
{
    public class DatService
    {
        private readonly DatDao datDao = new DatDao();

        public async Task<List<string[]>> GetAllArchivos()
        {
            return await datDao.GetAllArchivos();
        }

        

        public async Task<bool> InsertDat(DatModel datModel)
        {
            return await datDao.InsertarDAT(datModel);
        }
    }
}
