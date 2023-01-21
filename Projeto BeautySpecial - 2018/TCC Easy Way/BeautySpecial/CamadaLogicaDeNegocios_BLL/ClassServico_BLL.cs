using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Chamando referencia de outras pastas dentro do projeto
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassServico_BLL : IClassServico_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Methodo de inserir recebe um objeto como parametro objeto
        public string InserirServico(ClassServico_DTO classServico_dto)
        {
            try
            {
                //limpar parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@Nome_Serv", classServico_dto.Nome_Serv);
                classacessobancodados.AdicionarParametos("@Preco_Serv", classServico_dto.Preco_Serv);
                classacessobancodados.AdicionarParametos("@Descricao_Serv", classServico_dto.Descricao_Serv);
                classacessobancodados.AdicionarParametos("@Duracao_Serv", classServico_dto.Duracao_Serv);
                //Capturando id retornado
                string Idservico = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirServico").ToString();
                //Retornando id para o metódo
                return Idservico;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AtualizarServico(ClassServico_DTO classServico_dto)
        {
            try
            {
                //Limpar parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Servico", classServico_dto.ID_Servico);
                classacessobancodados.AdicionarParametos("@Nome_Serv", classServico_dto.Nome_Serv);
                classacessobancodados.AdicionarParametos("@Preco_Serv", classServico_dto.Preco_Serv);
                classacessobancodados.AdicionarParametos("@Descricao_Serv", classServico_dto.Descricao_Serv);
                classacessobancodados.AdicionarParametos("@Duracao_Serv", classServico_dto.Duracao_Serv);
                //capturando ID ou uma string de erro que volta da procedure
                string Idservico = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspAtualizarServico").ToString();
                // retornando id para o methodo
                return Idservico;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Metodo Excluir
        public string ExcluirServico(ClassServico_DTO classServico_dto)
        {
            try
            {
                //Passando parametros para procedure
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@ID_Servico", classServico_dto.ID_Servico);
                //capturando ID ou uma string de erro que volta da procedure
                string Idservico = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarServico").ToString();
                // retornando id para o methodo
                return Idservico;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo para consultar por nome
        public ClassServicoCollection_DTO ConsultaPorNome(string nome)
        {
            try
            {
                //criar uma coleção de serviço aqui ela esta vazia
                ClassServicoCollection_DTO servicoColecao = new ClassServicoCollection_DTO();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", nome);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableServico = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarServico");
                //Percorrer o datatable e transforma lo em uma colecao de serviços
                //cada linha do datable é um serviço
                //Data = dados Row = linha
                foreach (DataRow linha in dataTableServico.Rows)
                {
                    //criar um Serviço vazio
                    ClassServico_DTO classServico_DTO = new ClassServico_DTO();
                    //colocar dados da linha nele
                    if (linha["ID_Servico"] != DBNull.Value) { classServico_DTO.ID_Servico = Convert.ToInt32(linha["ID_Servico"]); }
                    if (linha["Nome_Serv"] != DBNull.Value) { classServico_DTO.Nome_Serv = Convert.ToString(linha["Nome_Serv"]); }
                    if (linha["Preco_Serv"] != DBNull.Value) { classServico_DTO.Preco_Serv = Convert.ToDecimal(linha["Preco_Serv"]); }
                    if (linha["Descricao_Serv"] != DBNull.Value)  {classServico_DTO.Descricao_Serv = Convert.ToString(linha["Descricao_Serv"]); }
                    if (linha["Duracao_Serv"] != DBNull.Value) { classServico_DTO.Duracao_Serv = Convert.ToString(linha["Duracao_Serv"]); }
                    //adicionar ele na colleção
                    servicoColecao.Add(classServico_DTO);
                }
                return servicoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o serviço por nome. Detalhes: " + ex.Message);
            }
        }

     }
 }

