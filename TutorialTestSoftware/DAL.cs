using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialTestSoftware
{
    public class DAL
    {
        private static string dataSource = @".\SQLExpress";
        private static string InitialCatalog = "TesteSoftware";
        private static string UserID = "cadu";
        private static string Password = "cadu";

        //Interpolação de String
        private string connectionString = $"Data Source={dataSource}; Initial Catalog={InitialCatalog}; User ID={UserID};Password={Password}";



        private SqlConnection connection;

        //Construtor -  Atalho ctor
        public SqlConnection conectar()
        {

            connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        public void fecharConexao()
        {

            connection.Close();
        }
    }
}
