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
    public class ClassComanda_BLL : IClassComanda_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();

        //Methodo de inserir recebe um objeto como parametros
        public string InserirComanda(ClassComanda_DTO classComanda_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Comanda
                classacessobancodados.AdicionarParametos("@ID_Cliente_Com", classComanda_DTO.classCliente_DTO.ID_Cliente);
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Com", classComanda_DTO.classFuncionario_DTO.ID_Funcionario);
                classacessobancodados.AdicionarParametos("@ValorTotal_Com", classComanda_DTO.ValorTotal_Com);
                //capturando ID ou uma string de erro que volta da procedure
                string IDComanda = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirComanda").ToString();
                //retornando id para o methodo
                return IDComanda;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Methodo de inserir recebe um objeto como parametros
        public string InserirServicosComanda(ClassComanda_DTO classComanda_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Comanda
                classacessobancodados.AdicionarParametos("@ID_Comanda", classComanda_DTO.ID_Comanda);
                classacessobancodados.AdicionarParametos("@ID_Servico", classComanda_DTO.classServico_DTO.ID_Servico);
                //capturando ID ou uma string de erro que volta da procedure
               string IDComanda = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirServicoComanda").ToString();
                //retornando id para o methodo
                return IDComanda;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Methodo atualizar comanda
        public string AtualizarComanda(Int32 ID_Comanda, Decimal Valor)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Comanda
                classacessobancodados.AdicionarParametos("@ID_Comanda", ID_Comanda);
                classacessobancodados.AdicionarParametos("@ValorTotal_Com", Valor);
                //capturando ID ou uma string de erro que volta da procedure
                string IDComanda = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspAtualizarComanda").ToString();
                //retornando id para o methodo
                return IDComanda;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Methodo de inserir recebe um objeto como parametros
        public string InserirProdutoComanda(ClassComanda_DTO classComanda_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Comanda
                classacessobancodados.AdicionarParametos("@ID_Comanda", classComanda_DTO.ID_Comanda);
                classacessobancodados.AdicionarParametos("@ID_Produto", classComanda_DTO.classProduto_DTO.ID_Produto);
                //capturando ID ou uma string de erro que volta da procedure
                string IDComanda = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirProdutoComanda").ToString();
                //retornando id para o methodo
                return IDComanda;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        //Metodo Excluir
        public string ExcluirComanda(ClassComanda_DTO classComanda_dto)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Instanciando Objetos
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Comanda", classComanda_dto.ID_Comanda);
                //capturando ID ou uma string de erro que volta da procedure
                string IdComanda = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarComanda").ToString();
                // retornando id para o methodo
                return IdComanda;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        //Metodo Excluir serviço comanda
        public string ExcluirServicoComanda(Int32 ID_Comanda)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Instanciando Objetos
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Comanda", ID_Comanda);
                //capturando ID ou uma string de erro que volta da procedure
                string IdComanda = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarServicoComanda").ToString();
                // retornando id para o methodo
                return IdComanda;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo Excluir produto comanda
        public string ExcluirProdutoComanda(Int32 ID_Comanda)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Instanciando Objetos
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Comanda", ID_Comanda);
                //capturando ID ou uma string de erro que volta da procedure
                string IdComanda = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarProdutoComanda").ToString();
                // retornando id para o methodo
                return IdComanda;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo para consultar por nome
        public ClassComanda_Collection_DTO ConsultaPorNome(string nome)
        {
            try
            {
                //criar uma coleção, aqui ela esta vazia
                ClassComanda_Collection_DTO comandaColecao = new ClassComanda_Collection_DTO();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", nome);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableComanda = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarComanda");
                //Percorrer o datatable e transforma lo em uma colecao de clientes
                //cada linha do datable é uma comanda
                //Data = dados Row = linha
                foreach (DataRow linha in dataTableComanda.Rows)
                {
                    //criar uma comanda vazia
                   ClassComanda_DTO classComanda_DTO = new ClassComanda_DTO();
                    //colocar dados da linha nele
                    //Comanda
                    if (linha["ID_Comanda"] != DBNull.Value) { classComanda_DTO.ID_Comanda = Convert.ToInt32(linha["ID_Comanda"]); }
                    classComanda_DTO.classCliente_DTO = new ClassCliente_DTO();
                    if (linha["ID_Cliente"] != DBNull.Value) { classComanda_DTO.classCliente_DTO.ID_Cliente = Convert.ToInt32(linha["ID_Cliente"]); }
                    if (linha["Nome_Clie"] != DBNull.Value) { classComanda_DTO.classCliente_DTO.Nome_Clie = Convert.ToString(linha["Nome_Clie"]); }
                    classComanda_DTO.classFuncionario_DTO = new ClassFuncionario_DTO();
                    if (linha["ID_Funcionario"] != DBNull.Value) { classComanda_DTO.classFuncionario_DTO.ID_Funcionario = Convert.ToInt32(linha["ID_Funcionario"]); }
                    if (linha["Nome_Func"] != DBNull.Value) { classComanda_DTO.classFuncionario_DTO.Nome_Func = Convert.ToString(linha["Nome_Func"]); }
                    classComanda_DTO.classServico_DTO = new ClassServico_DTO();
                    if (linha["ID_Servico"] != DBNull.Value) { classComanda_DTO.classServico_DTO.ID_Servico = Convert.ToInt32(linha["ID_Servico"]); }
                    if (linha["Nome_Serv"] != DBNull.Value) { classComanda_DTO.classServico_DTO.Nome_Serv = Convert.ToString(linha["Nome_Serv"]); }
                    if (linha["Preco_Serv"] != DBNull.Value) { classComanda_DTO.classServico_DTO.Preco_Serv = Convert.ToDecimal(linha["Preco_Serv"]); }


                    classComanda_DTO.classProduto_DTO = new ClassProduto_DTO();
                    if (linha["ID_Produto"] != DBNull.Value) { classComanda_DTO.classProduto_DTO.ID_Produto = Convert.ToInt32(linha["ID_Produto"]); }
                    if (linha["Nome_Prod"] != DBNull.Value) { classComanda_DTO.classProduto_DTO.Nome_Prod = Convert.ToString(linha["Nome_Prod"]); }

                    if (linha["ValorTotal_Com"] != DBNull.Value) { classComanda_DTO.ValorTotal_Com = Convert.ToDecimal(linha["ValorTotal_Com"]); }
                    if (linha["Data_Com"] != DBNull.Value) { classComanda_DTO.Data_Com = Convert.ToDateTime(linha["Data_Com"]); }
                    //adicionando para a coleção
                    comandaColecao.Add(classComanda_DTO);
                }
                //retornando a coleção preenchida
                return comandaColecao;
            }
            catch (Exception ex)
            {
                //caso de erro
                throw new Exception("Não foi possivel consultar a comanda. Detalhes: " + ex.Message);
            }
        }

        //Metodo para consultar por nome
        public DataTable ConsultaServicoComanda(Int32 ID)
        {
            try
            {
                //criar uma coleção de produto aqui ela esta vazia
                ClassProdutoCollection_DTO produtoColecao = new ClassProdutoCollection_DTO();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", ID);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableServicoComanda = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarServicoComanda");
               
                return dataTableServicoComanda;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o serviço da comanda. Detalhes: " + ex.Message);
            }
        }


        //Metodo para consultar por nome
        public DataTable ConsultaProdutoComanda(Int32 ID)
        {
            try
            {
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", ID);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableProdutoComanda = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarProdutoComanda");
                //Percorrer o datatable e transforma lo em uma colecao de produtos
                return dataTableProdutoComanda;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o produto da comada. Detalhes: " + ex.Message);
            }
        }
    }
}
