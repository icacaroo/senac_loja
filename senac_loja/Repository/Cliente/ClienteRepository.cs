using senac_loja.Interfaces.Cliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Repository.Cliente
{
    public class ClienteRepository : IClienteRepository
    {
        Conexao conexao = new Conexao(TipoConexao.Conexao.WebConfig);

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Entidades.Cliente.Cliente> Listar()
        {
            try
            {
                SqlDataReader reader;
                string query = "select * from tb_cliente";
                SqlCommand cmd = new SqlCommand(query, conexao.conn);
                cmd.CommandType = System.Data.CommandType.Text;

                // Abre nossa Conexao
                if (conexao.OpenConexao() == false)
                {
                    //setMensagemErro(conexao.mErro);
                    return null;
                }

                reader = cmd.ExecuteReader();
                IList<Entidades.Cliente.Cliente> lista = new List<Entidades.Cliente.Cliente>() { };
                while (reader.Read())
                {
                   Entidades.Cliente.Cliente cliente = new  Entidades.Cliente.Cliente () { };
                    

                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = (string)reader["Nome"];
                    cliente.Cpf = (string)reader["Cpf"];
                    cliente.Dh_Nascimento  = (DateTime?)reader["Dh_Nascimento"];
                    cliente.Id_Tipo = Convert.ToInt32(reader["Tipo"]);
                    cliente.Ativo = (bool)reader["Ativo"];

                    lista.Add(cliente);
                }
                return lista;
            }
            catch (SqlException e)
            {
                return null;
                //setMensagemErro(e.Message.ToString());
            }
              
        }

        public Entidades.Cliente.Cliente ListarPeloId(int id)
        {
            try
            {
                SqlDataReader reader;
                string query = string.Format("select * from tb_cliente where id ={0}", id.ToString());
                SqlCommand cmd = new SqlCommand(query, conexao.conn);
                cmd.CommandType = System.Data.CommandType.Text;

                // Abre nossa Conexao
                if (conexao.OpenConexao() == false)
                {
                    //setMensagemErro(conexao.mErro);
                    return null;
                }

                reader = cmd.ExecuteReader();
                Entidades.Cliente.Cliente cliente = new Entidades.Cliente.Cliente() { };
                while (reader.Read())
                {
                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = (string)reader["Nome"];
                    cliente.Cpf = (string)reader["Cpf"];
                    cliente.Dh_Nascimento = (DateTime?)reader["Dh_Nascimento"];
                    cliente.Id_Tipo = Convert.ToInt32(reader["Tipo"]);
                    cliente.Ativo = (bool)reader["Ativo"];
                }
                return cliente;
            }
            catch (SqlException e)
            {
                return null;
                //setMensagemErro(e.Message.ToString());
            }
        }

        public void Salvar(Entidades.Cliente.Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
