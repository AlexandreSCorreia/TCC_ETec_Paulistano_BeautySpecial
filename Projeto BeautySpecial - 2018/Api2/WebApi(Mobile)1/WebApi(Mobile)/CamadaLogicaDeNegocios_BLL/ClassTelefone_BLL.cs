using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassTelefone_BLL :IClassTelefone_BLL
    {

        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();

        public string Inserir(ClassTelefone_DTO classTelefone_dto)
        {
            if (classTelefone_dto == null)
            {

                throw new ArgumentNullException("Erro ao inserir o telefone");
            }
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Funcionario
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Tele", classTelefone_dto.ID_Funcionario_Tele);
                //Cliente
                classacessobancodados.AdicionarParametos("@ID_Cliente_Tele", classTelefone_dto.ID_Cliente_Tele);
                //Telefone
                classacessobancodados.AdicionarParametos("@DDD_Tele", classTelefone_dto.DDD_Tele);
                classacessobancodados.AdicionarParametos("@Telefone_Tele", classTelefone_dto.Telefone_Tele);
                //Tipo de Telefone
                classacessobancodados.AdicionarParametos("@ID_Tipo_Telefone_Tele", classTelefone_dto.classTipo_Telefone.ID_Tipo_Telefone);
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

        public string Atualizar(ClassTelefone_DTO classTelefone_dto)
        {
            if (classTelefone_dto == null)
            {

                throw new ArgumentNullException("Erro ao atualizar cliente");
            }

            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Telefone
                classacessobancodados.AdicionarParametos("@ID_Telefone", classTelefone_dto.ID_Funcionario_Tele);
                classacessobancodados.AdicionarParametos("@DDD_Tele", classTelefone_dto.DDD_Tele);
                classacessobancodados.AdicionarParametos("@Telefone_Tele", classTelefone_dto.Telefone_Tele);
                //Tipo de Telefone
                classacessobancodados.AdicionarParametos("@ID_Tipo_Telefone_Tele", classTelefone_dto.classTipo_Telefone.ID_Tipo_Telefone);
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

        public string Deletar(int id_cliente_tele, int id_funcionario_tele)
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