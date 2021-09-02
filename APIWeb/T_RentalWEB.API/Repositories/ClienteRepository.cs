using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using T_RentalWEB.API.Domains;
using T_RentalWEB.API.Interfaces;

namespace T_RentalWEB.API.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private string stringConexao = @"Data Source = NOTE0113D3\SQLEXPRESS; initial catalog = T_Rental_Vitor; user Id=sa ; pwd=Senai@132";
        public void AtualizarPeloIdUrl(ClienteDomain clienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public ClienteDomain BuscarPeloId(int idCliente)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ClienteDomain novoCliente)
        {

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string QueryInsert = "INSERT INTO CLIENTE(Nome, Sobrenome, CPF) VALUES ('" + novoCliente.Nome + novoCliente.Sobrenome + novoCliente.CPF +"')";
                con.Open();
      
                using (SqlCommand cmd = new SqlCommand(QueryInsert, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletarPeloId(int idCliente)
        {
            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                
               
            }
        }

        public List<ClienteDomain> ListarClientes()
        {
            List<ClienteDomain> listaClientes = new List<ClienteDomain>();
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string QuerySelectAll = "SELECT idCliente, Nome, Sobrenome, CPF FROM CLIENTE";

                con.Open();
                SqlDataReader lido;
                using (SqlCommand cmd = new SqlCommand(QuerySelectAll, con))
                {
                    lido = cmd.ExecuteReader();
                    while (lido.Read())
                    {
                        ClienteDomain cliente = new ClienteDomain()
                        {
                            idCliente = Convert.ToInt32(lido[0]),
                            Nome = lido[1].ToString(),
                            Sobrenome = lido[2].ToString(),
                            CPF = Convert.ToInt32(lido[3]),
                        };
                        listaClientes.Add(cliente);
                    }
                }
            }
            return listaClientes;
        }
    }
}
