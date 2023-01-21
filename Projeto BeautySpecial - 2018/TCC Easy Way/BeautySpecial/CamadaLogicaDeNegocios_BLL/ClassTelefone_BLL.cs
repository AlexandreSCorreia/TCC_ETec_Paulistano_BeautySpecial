using System;
using System.Data;
//Chamando referencia de outras pastas dentro do projeto
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassTelefone_BLL : IClassTelefone_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Methodo de inserir recebe um objeto como parametro classtelefone dto 
        public string InserirTelefone(ClassTelefone_DTO classTelefone_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Funcionario
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Tele", classTelefone_DTO.ID_Funcionario_Tele);
                //Cliente
                classacessobancodados.AdicionarParametos("@ID_Cliente_Tele", classTelefone_DTO.ID_Cliente_Tele);
                //Telefone
                classacessobancodados.AdicionarParametos("@DDD_Tele", classTelefone_DTO.DDD_Tele);
                classacessobancodados.AdicionarParametos("@Telefone_Tele", classTelefone_DTO.Telefone_Tele);
                //Tipo de Telefone
                classacessobancodados.AdicionarParametos("@ID_Tipo_Telefone_Tele", classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone);
                //capturando ID ou uma string de erro que volta da procedure
                string IdTelefone = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirTelefone").ToString();
                //retornando id para o methodo
                return IdTelefone;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo Atualizar
        public string AtualizarTelefone(ClassTelefone_DTO classTelefone_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Telefone
                classacessobancodados.AdicionarParametos("@ID_Telefone", classTelefone_DTO.ID_Funcionario_Tele);
                classacessobancodados.AdicionarParametos("@DDD_Tele", classTelefone_DTO.DDD_Tele);
                classacessobancodados.AdicionarParametos("@Telefone_Tele", classTelefone_DTO.Telefone_Tele);
                //Tipo de Telefone
                classacessobancodados.AdicionarParametos("@ID_Tipo_Telefone_Tele", classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone);
                //capturando ID ou uma string de erro que volta da procedure
                string IdTelefone = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspAtualizarTelefone").ToString();
                // retornando id para o methodo
                return IdTelefone;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo Excluir
        public string ExcluirTelefone(int id_cliente_tele, int id_funcionario_tele)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Instanciando Objetos
                //Tipo de telefone
                var classTelefone_DTO = new ClassTelefone_DTO();
                classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Cliente_Tele", id_cliente_tele);
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Tele", id_funcionario_tele);
                //capturando ID ou uma string de erro que volta da procedure
                string IdTelefone = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarTelefone").ToString();
                // retornando id para o methodo
                return IdTelefone;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
