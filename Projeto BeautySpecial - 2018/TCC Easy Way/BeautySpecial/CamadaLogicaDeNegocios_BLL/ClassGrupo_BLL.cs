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
    public class ClassGrupo_BLL : IClassGrupo_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Metodo para consultar por nome
        public List<ClassGrupo_DTO> ConsultaGrupo(String nome)
        {
            try
            {
                //criar uma coleção de grupos, aqui ela esta vazia
                List<ClassGrupo_DTO> listaGrupo = new List<ClassGrupo_DTO>();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", nome);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableGrupo = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarGrupo");
                //Percorrer o datatable e transforma lo em uma colecao de grupo
                //cada linha do datable é um grupo
                //Data = dados Row = linha
                foreach (DataRow linha in dataTableGrupo.Rows)
                {
                    //criar um grupo vazio
                    //colocar dados da linha nele
                    //adicionar ele na colleção
                    //grupo
                    ClassGrupo_DTO classGrupo_DTO = new ClassGrupo_DTO();
                    if (linha["ID_Grupo"] != DBNull.Value) { classGrupo_DTO.ID_Grupo = Convert.ToInt32(linha["ID_Grupo"]); }
                    if (linha["Descricao_Grup"] != DBNull.Value) { classGrupo_DTO.Descricao_Grup = Convert.ToString(linha["Descricao_Grup"]); }
                    //adicionando para a coleção
                    listaGrupo.Add(classGrupo_DTO);
                }
                //retornando a coleção preenchida
                return listaGrupo;
            }
            catch (Exception ex)
            {
                //Caso de erro
                throw new Exception("Não foi possivel consultar o grupo. Detalhes: " + ex.Message);
            }
        }

        //Metodo para localizar funcionario por id
        public DataTable LocalizarGruPorID(int id)
        {
            try
            {
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", id);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableGrupo = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "LocalizarGruPorID");
                //retornando a coleção preenchida
                return dataTableGrupo;


            }
            catch (Exception ex)
            {
                //caso de erro
                throw new Exception("Não foi possivel localizar o grupo pelo código. \n\n Detalhes: " + ex.Message);
            }
        }
    }
}
