using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using DataAccess;
using Npgsql;
using System.Windows.Forms;

namespace Data.DAO
{
    public class SectoresDao
    {
        private readonly NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();

        public async Task<string[]> GetSectores()
        {
            string[] list;
            try
            {
                int cantidad = 0;
                string sql = "select count(id) from sectores;";
                var con = await BDNpgsql.Instance.GetConnectionAsync();

                using (var command = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            cantidad = reader.GetInt32(0);
                        }
                    }
                }
                BDNpgsql.Instance.CloseConnection();
                list = new string[cantidad];
                sql = "select sector from sectores;";
                con = await BDNpgsql.Instance.GetConnectionAsync();

                using (var command = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        for(int i=0;  await reader.ReadAsync(); i++)
                        {
                            list[i] = reader.GetString(0);
                        }
                    }
                }
                return list;

            }
            catch (NpgsqlException ex)
            {
                mensaje.ShowDialog("Error base de datos", ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);
            }


            catch (Exception ex) { mensaje.ShowDialog("Exception", ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar); }
            finally { BDNpgsql.Instance.CloseConnection(); }

            return null;
        }
    }
}
