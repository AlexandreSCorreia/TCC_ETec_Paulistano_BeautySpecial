using System;
using System.Data;

//Chamando referencia de outras pastas dentro do projeto
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassProduto_BLL : IClassProduto_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Methodo de inserir recebe um objeto como parametro um objeto 
        public string InserirProduto(ClassProduto_DTO classProduto_dto)
        {
            try
            {
                //limpando parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@Nome_Prod",classProduto_dto.Nome_Prod);
                classacessobancodados.AdicionarParametos("@Marca_Prod", classProduto_dto.Marca_Prod);
                classacessobancodados.AdicionarParametos("@Descricao_Prod", classProduto_dto.Descricao_Prod);
                classacessobancodados.AdicionarParametos("@Preco_Prod", classProduto_dto.Preco_Prod);
                classacessobancodados.AdicionarParametos("@Quantidade_Prod", classProduto_dto.Quantidade_Prod);
                //Capturando ID que foi retornado pela procedure ou uma string de erro
                string Idproduto = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirProduto").ToString();
                //Retornando id para o metódo ou uma msg de erro
                return Idproduto;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Methodo de inserir recebe um objeto como parametros
        public string InserirServicosProduto(ClassProduto_DTO classProduto_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Produto
                classacessobancodados.AdicionarParametos("@ID_Produto", classProduto_DTO.ID_Produto);
                classacessobancodados.AdicionarParametos("@ID_Servico", classProduto_DTO.classServico_DTO.ID_Servico);
                //capturando ID ou uma string de erro que volta da procedure
                string IDProduto = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirServicoProduto").ToString();
                //retornando id para o methodo
                return IDProduto;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Metodo Atualizar
        public string AtualizarProduto(ClassProduto_DTO classProduto_dto)
        {
            try
            {
                //Limpando parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Produto", classProduto_dto.ID_Produto);
                classacessobancodados.AdicionarParametos("@Nome_Prod", classProduto_dto.Nome_Prod);
                classacessobancodados.AdicionarParametos("@Marca_Prod", classProduto_dto.Marca_Prod);
                classacessobancodados.AdicionarParametos("@Descricao_Prod", classProduto_dto.Descricao_Prod);
                classacessobancodados.AdicionarParametos("@Preco_Prod", classProduto_dto.Preco_Prod);
                classacessobancodados.AdicionarParametos("@Quantidade_Prod", classProduto_dto.Quantidade_Prod);
                //Capturando ID que foi retornado
                string Idproduto = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspAtualizarProduto").ToString();
                //Retornando id para o metódo
                return Idproduto;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Metodo Excluir
        public string ExcluirProduto(ClassProduto_DTO classProduto_dto)
        {

            try
            {
                //Limpando parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Produto", classProduto_dto.ID_Produto);
                //Capturando ID que foi retornado
                string Idproduto = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarProduto").ToString();
                //Retornando id para o metódo
                return Idproduto;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo Excluir
        public string ExcluirServicoProduto(ClassProduto_DTO classProduto_dto)
        {
            try
            {
                //Limpando parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Produto", classProduto_dto.ID_Produto);
                classacessobancodados.AdicionarParametos("@ID_Servico", classProduto_dto.classServico_DTO.ID_Servico);
                //Capturando ID que foi retornado
                string Idproduto = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarServicoProduto").ToString();
                //Retornando id para o metódo
                return Idproduto;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Metodo para consultar por nome
        public ClassProdutoCollection_DTO ConsultaPorNome(string nome)
        {
            try
            {
                //criar uma coleção de produto aqui ela esta vazia
                ClassProdutoCollection_DTO produtoColecao = new ClassProdutoCollection_DTO();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", nome);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableProduto = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarProduto");
                //Percorrer o datatable e transforma lo em uma colecao de produtos
                //cada linha do datable é um produto
                //Data = dados, Row = linha
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //criar um produto vazio
                    ClassProduto_DTO classProduto_DTO = new ClassProduto_DTO();
                    classProduto_DTO.classServico_DTO = new ClassServico_DTO();
                    //colocar dados na linha 
                    if (linha["ID_Produto"] != DBNull.Value) { classProduto_DTO.ID_Produto = Convert.ToInt32(linha["ID_Produto"]); }
                    if (linha["Nome_Prod"] != DBNull.Value) { classProduto_DTO.Nome_Prod = Convert.ToString(linha["Nome_Prod"]); }
                    if (linha["Marca_Prod"] != DBNull.Value) { classProduto_DTO.Marca_Prod = Convert.ToString(linha["Marca_Prod"]); }
                    if (linha["Descricao_Prod"] != DBNull.Value) { classProduto_DTO.Descricao_Prod = Convert.ToString(linha["Descricao_Prod"]); }
                    if (linha["Preco_Prod"] != DBNull.Value) { classProduto_DTO.Preco_Prod = Convert.ToDecimal(linha["Preco_Prod"]); }
                    if (linha["Quantidade_Prod"] != DBNull.Value) { classProduto_DTO.Quantidade_Prod = Convert.ToInt32(linha["Quantidade_Prod"]); }
                    if (linha["ID_Servico"] != DBNull.Value) { classProduto_DTO.classServico_DTO.ID_Servico = Convert.ToInt32(linha["ID_Servico"]); }
                    if (linha["Nome_Serv"] != DBNull.Value) { classProduto_DTO.classServico_DTO.Nome_Serv = Convert.ToString(linha["Nome_Serv"]); }
                    //adicionar objeto preenchido na coleção
                    produtoColecao.Add(classProduto_DTO);
                }
                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o produto por nome. Detalhes: " + ex.Message);
            }
        }


        //Metodo para consultar por nome
        public DataTable ConsultaPorNome(Int32 ID )
        {
            try
            {
                //criar uma coleção de produto aqui ela esta vazia
                ClassProdutoCollection_DTO produtoColecao = new ClassProdutoCollection_DTO();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", ID);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableProduto = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarServicoProduto");
                //Percorrer o datatable e transforma lo em uma colecao de produtos
                //cada linha do datable é um produto
                //Data = dados, Row = linha
               /* foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //criar um produto vazio
                    ClassProduto_DTO classProduto_DTO = new ClassProduto_DTO();
                    classProduto_DTO.classServico_DTO = new ClassServico_DTO();
                    //colocar dados na linha 
                    if (linha["ID_Servico"] != DBNull.Value) { classProduto_DTO.classServico_DTO.ID_Servico = Convert.ToInt32(linha["ID_Servico"]); }
                    if (linha["Nome_Serv"] != DBNull.Value) { classProduto_DTO.classServico_DTO.Nome_Serv = Convert.ToString(linha["Nome_Serv"]); }
                    //adicionar objeto preenchido na coleção
                    produtoColecao.Add(classProduto_DTO);
                }*/
                return dataTableProduto;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o serviço do produto. Detalhes: " + ex.Message);
            }
        }
    }
}
