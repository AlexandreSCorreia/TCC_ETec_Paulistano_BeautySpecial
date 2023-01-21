using System;
using System.Data;
//Chamando referencia de outras pastas dentro do projeto
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    
    public class ClassLogin_BLL : IClassLogin_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();


        //Metodo para logar no sistema
        public DataTable LogarNoSistema(string cpf,string senha)
        {
            try
            {
                //Limpando parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para a procedure

                classacessobancodados.AdicionarParametos("@CPF_Func", cpf);
                classacessobancodados.AdicionarParametos("@Senha_Log", senha);
                //Data = dados Table = tabela tabela de dados
                //Capturando os dados do SELECT na tabela do banco de dados atraves de uma procedure
                DataTable dataTableLogin = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure,"ConsultarLoginFunc");
                //retornando objeto
                return dataTableLogin;

            }
            catch (Exception ex)
            {
                //retornando objeto para o metodo
                throw new Exception(ex.Message);
            }
           
        }
        //Metodo para procurar registro
        public DataTable BuscarFuncionarioLog(Int32 ID)
        {
            try
            {
                //Limpando parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para a procedure
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Log", ID);
                //Data = dados Table = tabela tabela de dados
                //Capturando os dados do SELECT na tabela do banco de dados atraves de uma procedure
                DataTable dataTableLogin = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarFuncionarioLog");
                //retornando objeto
                return dataTableLogin;

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
                classacessobancodados.AdicionarParametos("@ID_Cliente_Log", classLogin_DTO.ClassCliente_DTO.ID_Cliente);
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Log", classLogin_DTO.classFuncionario_DTO.ID_Funcionario);
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
                classacessobancodados.AdicionarParametos("@ID_Cliente_Log", 0);
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Log", classLogin_DTO.classFuncionario_DTO.ID_Funcionario);
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
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Log", ID);
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
