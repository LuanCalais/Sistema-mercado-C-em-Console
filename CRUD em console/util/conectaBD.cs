using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_em_console.util
{
    class conectaBD
    {

        private static String name = "localhost";
        private static String port = "5432";
        private static String user = "postgres";
        private static String password = "125678943";
        private static String dataBase = "Produto";

        public static NpgsqlConnection getConexao()
        {
            try
            {
                string stgConexao = String.Format("Server={0};Port={1};UserId={2};Password={3};Database={4}",
                    name, port, user, password, dataBase);
                NpgsqlConnection npgsqlConnection = new NpgsqlConnection(stgConexao);
                npgsqlConnection.Open();

                return npgsqlConnection;

            }catch(Exception e)
            {
                throw new Exception("Erro encontrado na conexão com o BD " + e.Message);
            }

        }

    }
}
