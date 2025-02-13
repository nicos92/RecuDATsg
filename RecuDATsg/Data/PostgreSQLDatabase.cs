using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
   

    public sealed class PostgreSQLDatabase
    {
        // Instancia única de la clase
        private static readonly Lazy<PostgreSQLDatabase> _instance = new Lazy<PostgreSQLDatabase>(() => new PostgreSQLDatabase());

        // Objeto para manejar la conexión
        private NpgsqlDataSource _dataSource;
        private const string Host = "192.168.0.189";
        //private const string Host = "Localhost";
        private const string Port = "62354";
        private const string Username = "nicopostgres";
        private const string Password = "athena_4116";
        private const string Database = "sggeneral";

        // Constructor privado para evitar la creación de instancias fuera de la clase
        private PostgreSQLDatabase()
        {
            // Cadena de conexión a la base de datos PostgreSQL
            string connectionString = $"Host={Host};Port={Port};Username={Username};Password={Password};Database={Database};MaxPoolSize=200;";

            // Crear el NpgsqlDataSourceBuilder y configurar la conexión
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
            _dataSource = dataSourceBuilder.Build();
        }

        // Propiedad para acceder a la instancia única
        public static PostgreSQLDatabase Instance => _instance.Value;

        // Método para obtener una conexión a la base de datos
        public NpgsqlConnection GetConnection()
        {
            return _dataSource.CreateConnection();
        }

        // Método para ejecutar una consulta (opcional)
        public void ExecuteQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
