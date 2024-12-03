using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOCERIACAT
{
    internal class ClienteDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public ClienteDAO() //método construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Cliente prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText =
            @"INSERT INTO 
            Property VALUES 
            (@user, @pass, )";

            Command.Parameters.AddWithValue("@user", prop.User);
            Command.Parameters.AddWithValue("@pass", prop.Pass);
            


            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "cliente no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }


        public void Update(Cliente prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Property SET 
            User = @user,
            Pass = @pass,
           
            WHERE CodProperty = @code";

            Command.Parameters.AddWithValue("@user", prop.User);
            Command.Parameters.AddWithValue("@pass", prop.Pass);
           
            
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização de " +
                    "cliente no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int codcliente)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Cliente
            WHERE CodCliente = @code";
            Command.Parameters.AddWithValue("@code", codcliente);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "cliente no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Cliente> ListAllProperties()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Cliente";

            List<Cliente> props = new List<Cliente>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Cliente prop = new Cliente(
                        (int)rd["CodCliente"],
                        (string)rd["Pass"],
                        (float)rd["User"]
                        );
                    props.Add(prop);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de imóveis no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return props;
        }
    }
}

