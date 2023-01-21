using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassLogin_BLL :IClassLogin_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();


        //Metodo para logar no sistema
        public List<ClassLogin_DTO> LogarNoSistema(string email, string senha)
        {
            try
            {
                //Limpando parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para a procedure
                classacessobancodados.AdicionarParametos("@Email_Clie", email);
                classacessobancodados.AdicionarParametos("@Senha_Log", senha);
                //Data = dados Table = tabela tabela de dados
                //Capturando os dados do SELECT na tabela do banco de dados atraves de uma procedure
                DataTable dataTableLogin = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarLoginClie");
                List<ClassLogin_DTO> ColecaoLogin = new List<ClassLogin_DTO>();

                foreach (DataRow linha in dataTableLogin.Rows)
                {
                    ClassLogin_DTO classLogin_DTOs = new ClassLogin_DTO();
                    classLogin_DTOs.classCliente_DTO = new ClassCliente_DTO();
                    if (linha["ID_Cliente"] != DBNull.Value) { classLogin_DTOs.classCliente_DTO.ID_Cliente = Convert.ToInt32(linha["ID_Cliente"]); }
                    if (linha["Nome_Clie"] != DBNull.Value) { classLogin_DTOs.classCliente_DTO.Nome_Clie = Convert.ToString(linha["Nome_Clie"]); }
                    if (linha["Email_Clie"] != DBNull.Value) { classLogin_DTOs.classCliente_DTO.Email_Clie = Convert.ToString(linha["Email_Clie"]); }
                    if (linha["Senha_Log"] != DBNull.Value) { classLogin_DTOs.Senha_Log = Convert.ToString(linha["Senha_Log"]); }
                    //adicionando para a coleção
                    ColecaoLogin.Add(classLogin_DTOs);
                }
                //retornando objeto
                return ColecaoLogin;

            }
            catch (Exception ex)
            {
                //retornando objeto para o metodo
                throw new Exception(ex.Message);
            }

        }
        //Metodo para logar no sistema
        public DataTable BuscarClienteLog(Int32 ID)
        {
            try
            {
                //Limpando parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para a procedure
                classacessobancodados.AdicionarParametos("@ID_Cliente_Log", ID);
                //Data = dados Table = tabela tabela de dados
                //Capturando os dados do SELECT na tabela do banco de dados atraves de uma procedure
                DataTable dataTableLogin = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarClienteLog");
                //retornando objeto
                return dataTableLogin;

            }
            catch (Exception ex)
            {
                //retornando objeto para o metodo
                throw new Exception(ex.Message);
            }

        }


        //Methodo de inserir recebe um objeto como parametros
        public string InserirLogin(ClassLogin_DTO classLogin_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Login
                classacessobancodados.AdicionarParametos("@ID_Cliente_Log", classLogin_DTO.classCliente_DTO.ID_Cliente);
                classacessobancodados.AdicionarParametos("@Senha_Log", classLogin_DTO.Senha_Log);
                //capturando ID ou uma string de erro que volta da procedure*/
                string Idlogin = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirLogin").ToString();
                //retornando id para o methodo
                return Idlogin;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Methodo de inserir recebe um objeto como parametros
        public string AtualizarLogin(ClassLogin_DTO classLogin_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Login
                classacessobancodados.AdicionarParametos("@ID_Cliente_Log", classLogin_DTO.classCliente_DTO.ID_Cliente);
                classacessobancodados.AdicionarParametos("@Senha_Log", classLogin_DTO.Senha_Log);
                //capturando ID ou uma string de erro que volta da procedure*/
                string Idlogin = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspAtualizarLogin").ToString();
                //retornando id para o methodo
                return Idlogin;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Metodo Excluir
        public string ExcluirLogin(Int32 ID)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Cliente_Log", ID);
                //capturando ID ou uma string de erro que volta da procedure
                string Idlogin = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarLogin").ToString();
                // retornando id para o methodo
                return Idlogin;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}