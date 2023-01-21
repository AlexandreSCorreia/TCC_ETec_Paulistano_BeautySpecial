using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Data.SqlClient;
using WebApi_Mobile_.Properties;

namespace ObjetoTransferenciaDeDados_DAL
{
    public class ClassAcessoBancoDados
    {
        

        //Criar conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.ConexaoString);

        }



        //Parametros que vão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametos(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }



        //Persistencia - Inserir,Atualizar, Excluir
        public object Executa_ComandoSQL(CommandType commandType, string comandosql)
        {
            try
            {   //criar Conexão
                SqlConnection sqlconnection = CriarConexao();
                //Abrir Conexão
                sqlconnection.Open();
                //Criar o comando que irá levar informação para o banco de dados
                SqlCommand sqlcommand = sqlconnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caixa que irá trafegar na conexao)
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = comandosql;
                //Quanto tempo essa conexão pode ficar aberta "Tempo maximo que essa conexão pode ficar aberta"
                sqlcommand.CommandTimeout = 7200;//Em segundos 7200 são 2 horas

                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }
                //Executar comando, ou seja, mandar o comando ir até o banco de dados.
                return sqlcommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Consultar registro no banco de dados
        public DataTable ExecutaConsulta(CommandType commandType, string Comando)
        {
            try
            {

                //criar Conexão
                SqlConnection sqlconnection = CriarConexao();
                //Abrir Conexão
                sqlconnection.Open();
                //Criar o comando que irá levar informação para o banco de dados
                SqlCommand sqlcommand = sqlconnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caixa que irá trafegar na conexao)
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = Comando;
                //Quanto tempo essa conexão pode ficar aberta "Tempo maximo que essa conexão pode ficar aberta"
                sqlcommand.CommandTimeout = 7200;//Em segundos 7200 são 2 horas
                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
                //DataTable = Tabela de Dados vazia onde eu vou colocar os dados que vem no banco
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
