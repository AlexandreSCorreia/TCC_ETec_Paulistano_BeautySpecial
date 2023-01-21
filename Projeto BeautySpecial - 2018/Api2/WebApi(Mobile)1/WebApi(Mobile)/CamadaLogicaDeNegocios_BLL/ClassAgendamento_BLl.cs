using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassAgendamento_BLl : IClassAgendamento_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Methodo de inserir recebe um objeto como parametro um objeto 
        public string InserirAgendamento(ClassAgendamento_DTO classAgendamento_dto)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Endereço
                classacessobancodados.AdicionarParametos("@ID_Cliente_Agend", classAgendamento_dto.classCliente_DTO.ID_Cliente);
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Agend", classAgendamento_dto.classFuncionario_DTO.ID_Funcionario);
                classacessobancodados.AdicionarParametos("@ID_Servico_Agend", classAgendamento_dto.classServico_DTO.ID_Servico);
                classacessobancodados.AdicionarParametos("@Data_Agend", classAgendamento_dto.Data_Agend);
                classacessobancodados.AdicionarParametos("@ID_HoraSalao_Agend", classAgendamento_dto.classHoraSalao.ID_HoraSalao);
                classacessobancodados.AdicionarParametos("@Observacao_Agend", classAgendamento_dto.Observacao_Agend);
                //capturando ID ou uma string de erro que volta da procedure
                string IdAgendamento = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirAgendamento").ToString();
                //retornando id para o methodo
                return IdAgendamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        //Metodo para consultar por nome
        public List<ClassAgendamento_DTO> ConsultaPorNome(string nome)
        {
            try
            {
                //criar uma coleção de agendamento aqui ela esta vazia
                List<ClassAgendamento_DTO> AgendamentoColecao = new List<ClassAgendamento_DTO>();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", nome);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableAgendamento = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarAgendamento");
                //Percorrer o datatable e transforma lo em uma colecao de agendamento
                //cada linha do datable é um agendamento
                //Data = dados, Row = linha
                foreach (DataRow linha in dataTableAgendamento.Rows)
                {
                    //criar um agendamneto vazio
                    ClassAgendamento_DTO classAgendamento_DTO = new ClassAgendamento_DTO();
                    //colocar dados da linha nele
                    //Cliente
                    classAgendamento_DTO.classCliente_DTO = new ClassCliente_DTO();
                    if (linha["ID_Cliente"] != DBNull.Value) { classAgendamento_DTO.classCliente_DTO.ID_Cliente = Convert.ToInt32(linha["ID_Cliente"]); }
                    if (linha["Nome_Clie"] != DBNull.Value) { classAgendamento_DTO.classCliente_DTO.Nome_Clie = Convert.ToString(linha["Nome_Clie"]); }
                    //Funcionario
                    classAgendamento_DTO.classFuncionario_DTO = new ClassFuncionario_DTO();
                    if (linha["ID_Funcionario"] != DBNull.Value) { classAgendamento_DTO.classFuncionario_DTO.ID_Funcionario = Convert.ToInt32(linha["ID_Funcionario"]); }
                    if (linha["Nome_Func"] != DBNull.Value) { classAgendamento_DTO.classFuncionario_DTO.Nome_Func = Convert.ToString(linha["Nome_Func"]); }
                    //Servico
                    classAgendamento_DTO.classServico_DTO = new ClassServico_DTO();
                    if (linha["ID_Servico"] != DBNull.Value) { classAgendamento_DTO.classServico_DTO.ID_Servico = Convert.ToInt32(linha["ID_Servico"]); }
                    if (linha["Nome_Serv"] != DBNull.Value) { classAgendamento_DTO.classServico_DTO.Nome_Serv = Convert.ToString(linha["Nome_Serv"]); }
                    if (linha["Duracao_Serv"] != DBNull.Value) { classAgendamento_DTO.classServico_DTO.Duracao_Serv = Convert.ToString(linha["Duracao_Serv"]); }
                    //Horario do Salão
                    classAgendamento_DTO.classHoraSalao = new ClassHoraSalao();
                    if (linha["ID_HoraSalao_Agend"] != DBNull.Value) { classAgendamento_DTO.classHoraSalao.ID_HoraSalao = Convert.ToInt32(linha["ID_HoraSalao_Agend"]); }
                    if (linha["Horario_Sal"] != DBNull.Value) { classAgendamento_DTO.classHoraSalao.Horario_Sal = Convert.ToString(linha["Horario_Sal"]); }
                    //Agendamento
                    if (linha["Data_Agend"] != DBNull.Value) { classAgendamento_DTO.classCliente_DTO.Data_Cadastro_Clie = Convert.ToDateTime(linha["Data_Agend"]); }
                    if (linha["Observacao_Agend"] != DBNull.Value) { classAgendamento_DTO.Observacao_Agend = Convert.ToString(linha["Observacao_Agend"]); }

                    //adicionando para a coleção
                    AgendamentoColecao.Add(classAgendamento_DTO);
                }
                //retornando a coleção preenchida
                return AgendamentoColecao;
            }
            catch (Exception ex)
            {
                //caso de erro
                throw new Exception("Não foi possivel consultar o agendamento. Detalhes: " + ex.Message);
            }
        }

        //Metodo para consultar horarios do salão
        public List<ClassHoraSalao> ConsultaHorarioSalao()
        {
            try
            {
                //criar uma coleção de tipo de pagamento aqui ela esta vazia
                List<ClassHoraSalao> listaHoraSalao = new List<ClassHoraSalao>();
                classacessobancodados.LimparParametros();
                //Data = dados Table = tabela de dados
                DataTable dataTableHoraSalao = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarHorarioSalao");
                //Percorrer o datatable e transforma lo em uma colecao
                //cada linha do datable é um tipo de pagamento
                //Data = dados Row = linha
                foreach (DataRow linha in dataTableHoraSalao.Rows)
                {
                    //criar um objeto vazio
                    //colocar dados da linha nele
                    //adicionar ele na colleção
                    //Horario Salão
                    ClassHoraSalao classHoraSalao_DTO = new ClassHoraSalao();
                    if (linha["ID_HoraSalao"] != DBNull.Value) { classHoraSalao_DTO.ID_HoraSalao = Convert.ToInt32(linha["ID_HoraSalao"]); }
                    if (linha["Horario_Sal"] != DBNull.Value) { classHoraSalao_DTO.Horario_Sal = Convert.ToString(linha["Horario_Sal"]); }
                    //adicionando para a coleção
                    listaHoraSalao.Add(classHoraSalao_DTO);
                }
                //retornando a coleção preenchida
                return listaHoraSalao;
            }
            catch (Exception ex)
            {
                //Caso de erro
                throw new Exception("Não foi possivel consultar o horario do salão. Detalhes: " + ex.Message);
            }
        }
    }
}