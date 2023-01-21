using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Chamando referencia de outras pastas dentro do projeto
using ObjetoTransferenciaDeDados_DAL;
using CamadaAcessoADados_DTO;
using System.Data;

namespace CamadaLogicaDeNegocios_BLL
{
    public class Permissao_BLL : IPermissao_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Methodo de inserir recebe um objeto como parametro um objeto
        public string InserirPermUsuario(Permissao_DTO permissao_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure

                //permissaousuario
                classacessobancodados.AdicionarParametos("@ID_Grupo_Per", permissao_DTO.ClassGrupo_DTO.ID_Grupo);
                classacessobancodados.AdicionarParametos("@NomeForm_Per", permissao_DTO.per_nomeform);
                classacessobancodados.AdicionarParametos("@Descricao_Per", permissao_DTO.per_Descricao);
                classacessobancodados.AdicionarParametos("@Bloquear_Per", permissao_DTO.per_bloquear);
                classacessobancodados.AdicionarParametos("@Inserir_Per", permissao_DTO.per_inserir);
                classacessobancodados.AdicionarParametos("@Atualizar_Per", permissao_DTO.per_atualizar);
                classacessobancodados.AdicionarParametos("@Excluir_Per", permissao_DTO.per_excluir);
                classacessobancodados.AdicionarParametos("@Consultar_Per", permissao_DTO.per_consultar);
                //capturando ID ou uma string de erro que volta da procedure*/
                string per_id = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirPermissaoUsu").ToString();
                //retornando id para o methodo
                return per_id;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

       
        //Metodo Excluir
        public string ExcluirPermUsuario(int id)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Grupo_Per", id);
                //capturando ID ou uma string de erro que volta da procedure
                string per_id = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarPermissaoUsu").ToString();
                // retornando id para o methodo
                return per_id;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo para consultar por nome
        public DataTable ConsultaPermGru(int id)
        {
            try
            {
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", id);

                //Data = dados Table = tabela tabela de dados
                DataTable dataTablePermusuario = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarPermGru");

                //retornando a coleção preenchida
                return dataTablePermusuario;
            }
            catch (Exception ex)
            {
                //caso de erro
                throw new Exception("Não foi possivel consultar a permissão do usuario \n\n. Detalhes: " + ex.Message);
            }
        }


        //Metodo para localizar a permissão do usuario
        public DataTable LocalizarPermissao(int id, string nomeform)
        {
            try
            {
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@ID_Grupo_Per", id);
                classacessobancodados.AdicionarParametos("@NomeForm_Per", nomeform);

                //Data = dados Table = tabela tabela de dados
                DataTable dataTablePermusuario = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "LocalizarPermissao");

                //retornando a coleção preenchida
                return dataTablePermusuario;
            }
            catch (Exception ex)
            {
                //caso de erro
                throw new Exception("Não foi possivel consultar a permissão do usuario \n\n. Detalhes: " + ex.Message);
            }
        }

    }
}
