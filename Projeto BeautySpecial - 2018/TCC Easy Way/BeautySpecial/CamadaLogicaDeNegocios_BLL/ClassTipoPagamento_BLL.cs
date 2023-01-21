using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Chamando referencia de outras pastas dentro do projeto
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;
using System.Data;

namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassTipoPagamento_BLL : IClassTipoPagamento_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Metodo para consultar por nome
        public List<ClassTipoPagamento_DTO> ConsultaTipoPagamento()
        {
            try
            {
                //criar uma coleção de tipo de pagamento aqui ela esta vazia
                List<ClassTipoPagamento_DTO> listaTipoPagamento = new List<ClassTipoPagamento_DTO>();
                classacessobancodados.LimparParametros();
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableTipoPagamento = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarTipoPagamento");
                //Percorrer o datatable e transforma lo em uma colecao
                //cada linha do datable é um tipo de pagamento
                //Data = dados Row = linha
                foreach (DataRow linha in dataTableTipoPagamento.Rows)
                {
                    //criar um objeto vazio
                    //colocar dados da linha nele
                    //adicionar ele na colleção
                    //Tipo de Pagamento
                    ClassTipoPagamento_DTO classTipoPagamento_DTO = new ClassTipoPagamento_DTO();
                    if (linha["ID_TipoPagamento"] != DBNull.Value) { classTipoPagamento_DTO.ID_TipoPagamento = Convert.ToInt32(linha["ID_TipoPagamento"]); }
                    if (linha["Descricao_TP"] != DBNull.Value) { classTipoPagamento_DTO.Descricao_TP = Convert.ToString(linha["Descricao_TP"]); }
                    //adicionando para a coleção
                    listaTipoPagamento.Add(classTipoPagamento_DTO);
                }
                //retornando a coleção preenchida
                return listaTipoPagamento;
            }
            catch (Exception ex)
            {
                //Caso de erro
                throw new Exception("Não foi possivel consultar o tipo de pagamento. Detalhes: " + ex.Message);
            }
        }
    }
}
