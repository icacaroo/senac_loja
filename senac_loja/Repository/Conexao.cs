using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Repository
{
    public class Conexao
    {

        public string mErro = "";


        // Variavel de definição para acesso a connectionStrings do Web.Config
        private string ConexaoWebConfig = "SqlServer";

        // Variaveis de configuração de acesso ao banco de dados
        private string Server = "localhost\\sqlexpress";
        private string Database = "projeto_senac_loja";
        private string Integracao = "True";
        private string Usuario = "sa";
        private string Senha = "123456";


        public SqlConnection conn;

        public Conexao(TipoConexao.Conexao TConexao)
        {
            GetConexao(TConexao);
        }
        public Conexao()
        {
            GetConexao(TipoConexao.Conexao.Classe);
        }

        // Verifica se existe erro
        public Boolean ExisteErro()
        {
            if (mErro.Length > 0)
            {
                return true;
            }
            return false;
        }

        // Faz a Conexao com o Banco de Dados
        private void GetConexao(TipoConexao.Conexao TConexao)
        {
            try
            {
                string connectionStrings = string.Format("Server={0};Database={1};Integrated Security={2}", this.Server, this.Database, this.Integracao);             
                this.conn = new SqlConnection(connectionStrings);
            }
            catch (Exception erro)
            {
                this.mErro = erro.Message;
                this.conn = null;
            }
        }

        // Abre conexao com o Banco de Dados
        public Boolean OpenConexao()
        {
            Boolean _return = true;
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                this.mErro = erro.Message;
                _return = false;
            }

            return _return;
        }

        // Fecha conexao com o Banco de Dados
        public void CloseConexao()
        {
            conn.Close();
            conn.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variavel"></param>
        /// <returns></returns>
        //public string getWebConfig(string Variavel)
        //{
        //    string strValue = "";
        //    System.Configuration.Configuration rootWebConfig =
        //        System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/");
        //    System.Configuration.ConnectionStringSettings connString;
        //    if (0 < rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
        //    {
        //        connString = rootWebConfig.ConnectionStrings.ConnectionStrings[Variavel];
        //        if (null != connString)
        //            strValue = connString.ConnectionString;
        //        else
        //            strValue = "erro";
        //    }

        //    return strValue;
        //}
    }
    /// <summary>
    /// Definição de tipos de Conexão 
    /// </summary>
    public class TipoConexao
    {
        public enum Conexao { WebConfig = 1, Classe = 2 };
    }
}
