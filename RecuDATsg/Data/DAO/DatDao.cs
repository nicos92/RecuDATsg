using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Models;
using Npgsql;

namespace Data.DAO
{
    public class DatDao
    {
        private readonly NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();
        public async Task<List<string[]>> GetAllArchivos()
        {
            List<string[]> mistrings = new List<string[]>();
            DatModel model;
            try
            {
                string sql = "select id, archivo, sector, cartelerror, observacion from archivosdat;";
                var con = await BDNpgsql.Instance.GetConnectionAsync();

                using (var command = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string[] list2 = new string[5];
                            model = new DatModel(
                                reader.GetInt64(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                                );

                            list2[0] = model.Id.ToString();
                            list2[1] = model.Archivo;
                            list2[2] = model.Sector;
                            list2[3] = model.Error;
                            list2[4] = model.Observacion;
                            mistrings.Add(list2);
                        }
                    }
                }


            }
            catch (NpgsqlException ex)
            {
                mensaje.ShowDialog("Error base de datos", ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);

            }


            catch (Exception ex) { mensaje.ShowDialog("Exception", ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar); }
            finally { BDNpgsql.Instance.CloseConnection(); }



            return mistrings;
        }

        public async Task<bool> InsertarDAT(DatModel datModel)
        {
            var con = await BDNpgsql.Instance.GetConnectionAsync();
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.CommandText = "insert into archivosdat(archivo, sector, cartelerror, observacion) values(@archivo,@sector, @error, @observacion)";
                    command.Parameters.AddWithValue("@archivo", datModel.Archivo);
                    command.Parameters.AddWithValue("@sector", datModel.Sector);
                    command.Parameters.AddWithValue("@error", datModel.Error);
                    command.Parameters.AddWithValue("@observacion", datModel.Observacion);
                    command.Connection = con;
                    int reader = await command.ExecuteNonQueryAsync();
                    if (reader > 0)
                    {
                        return true;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                mensaje.ShowDialog("Error base de datos", ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);

            }


            catch (Exception ex)
            {
                mensaje.ShowDialog("Exception", ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);
            }
            finally { BDNpgsql.Instance.CloseConnection(); }

            return false;
        }
    }
}
