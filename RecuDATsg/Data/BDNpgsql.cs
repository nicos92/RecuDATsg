using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public sealed class BDNpgsql
    {
        private static BDNpgsql _instance = null;
        private static readonly object _lock = new object();
        private readonly NpgsqlConnection _connection;


        private const string Host = "192.168.0.189";
        //private const string Host = "Localhost";
        private const string Port = "62354";
        private const string Username = "postgres";
        private const string Password = "athena_4116";
        private const string Database = "sggeneral";

        private const string connString = "Host=" + Host + ";Port=" + Port + ";Username=" + Username + ";Password=" + Password + ";Database=" + Database + ";MaxPoolSize=200;";

        private BDNpgsql()
        {
            try
            {

                _connection = new NpgsqlConnection(connString);
            }
            catch (NpgsqlException ex)
            {

                NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();
                mensaje.ShowDialog("Error NpgsqlConnection", ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);
            }
        }

        public static BDNpgsql Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {

                            _instance = new BDNpgsql();
                        }
                    }
                }
                return _instance;
            }
        }

        public NpgsqlConnection GetConnection
        {
            get
            {
                try
                {

                    if (_connection.State != System.Data.ConnectionState.Open)
                        _connection.Open();

                }
                catch (NpgsqlException e)
                {
                    NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();
                    mensaje.ShowDialog("Error al conectar con Base de Datos", e.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);
                    return null;
                }

                return _connection;
            }
        }

        public async Task<NpgsqlConnection> GetConnectionAsync()
        {


            if (_connection.State != System.Data.ConnectionState.Open)
                await _connection.OpenAsync();


            return _connection;

        }

        public async void CloseConnection()
        {
            try
            {

                if (_connection.State != System.Data.ConnectionState.Closed)
                    await _connection.CloseAsync();
            }
            catch (InvalidOperationException e)
            {



                NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();
                mensaje.ShowDialog("Error al Cerrar la conexion ", e.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);

            }
        }

    }
}
