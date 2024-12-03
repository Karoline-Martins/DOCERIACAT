using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOCERIACAT
{
    
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ3021939DOCERIAKAROL";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";
        public Connection() {
                string stringconnection =
                @"data source = " + Server
                + "; initial catalog = " + DataBase
                + "; user id =" + Username
                + "; password =" + Password
                + "; encrypt = false";
               

            con = new SqlConnection(stringconnection);
            con.Open();   //Abrir a conexão com o banco de dados
        }

        //Tenta fechar a conexão com o banco
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }

    }
}
          