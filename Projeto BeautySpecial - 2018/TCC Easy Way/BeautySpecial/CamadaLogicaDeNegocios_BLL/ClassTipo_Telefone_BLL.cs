using System;
using System.Data;
using System.Collections.Generic;
//Chamando referencia de outras pastas dentro do projeto
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;


namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassTipo_Telefone_BLL : IClassTipo_Telefone_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Metodo para consultar tipo de telefone
        public List<ClassTipo_Telefone_DTO> ConsultaTipoTelefone()
        {
            try
            {
                //criar uma coleção de tipo de telefone, aqui ela esta vazia
                List<ClassTipo_Telefone_DTO> listaTipoTelefone = new List<ClassTipo_Telefone_DTO>();
                classacessobancodados.LimparParametros();
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableTipoTelefone = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarTipoTelefone");
                //Percorrer o datatable e transforma lo em uma colecao
                //cada linha do datable é um tipo de telefone
                //Data = dados Row = linha
                foreach (DataRow linha in dataTableTipoTelefone.Rows)
                {
                    //criar um objeto vazio
                    //colocar dados da linha nele
                    //adicionar ele na colleção
                    //Tipo de Telefone
                    ClassTipo_Telefone_DTO classTipo_Telefone_DTO = new ClassTipo_Telefone_DTO();
                    if (linha["ID_Tipo_Telefone"] != DBNull.Value) { classTipo_Telefone_DTO.ID_Tipo_Telefone = Convert.ToInt32(linha["ID_Tipo_Telefone"]); }
                    if (linha["Descricao_TTele"] != DBNull.Value) { classTipo_Telefone_DTO.Descricao_TTele = Convert.ToString(linha["Descricao_TTele"]); }
                    //adicionando para a coleção
                    listaTipoTelefone.Add(classTipo_Telefone_DTO);
                }
                //retornando a coleção preenchida
                return listaTipoTelefone;
            }
            catch (Exception ex)
            {
                //Caso de erro
                throw new Exception("Não foi possivel consultar o tipo de telefone. Detalhes: " + ex.Message);
            }
        }
    }
}
