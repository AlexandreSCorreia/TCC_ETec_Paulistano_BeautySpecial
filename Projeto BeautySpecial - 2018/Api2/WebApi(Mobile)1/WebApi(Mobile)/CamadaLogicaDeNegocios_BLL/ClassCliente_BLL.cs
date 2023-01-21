using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassCliente_BLL : IClassCliente_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();

        public string Inserir(ClassCliente_DTO classcliente_dto)
        {
            if (classcliente_dto == null)
            {

                throw new ArgumentNullException("Erro ao inserir cliente");
            }
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Endereço
                classacessobancodados.AdicionarParametos("@CEP_Ende", classcliente_dto.classEndereco_DTO.CEP_Ende);
                classacessobancodados.AdicionarParametos("@Endereco_Ende", classcliente_dto.classEndereco_DTO.Endereco_Ende);
                classacessobancodados.AdicionarParametos("@Numero_Ende", classcliente_dto.classEndereco_DTO.Numero_Ende);
                classacessobancodados.AdicionarParametos("@Complemento_Ende", classcliente_dto.classEndereco_DTO.Complemento_Ende);
                classacessobancodados.AdicionarParametos("@Bairro_Ende", classcliente_dto.classEndereco_DTO.Bairro_Ende);
                classacessobancodados.AdicionarParametos("@Cidade_Ende", classcliente_dto.classEndereco_DTO.Cidade_Ende);
                classacessobancodados.AdicionarParametos("@UF_Ende", classcliente_dto.classEndereco_DTO.UF_Ende);
                //Cliente
                classacessobancodados.AdicionarParametos("@Nome_Clie", classcliente_dto.Nome_Clie);
                classacessobancodados.AdicionarParametos("@RG_Clie", classcliente_dto.RG_Clie);
                classacessobancodados.AdicionarParametos("@CPF_Clie", classcliente_dto.CPF_Clie);
                classacessobancodados.AdicionarParametos("@Email_Clie", classcliente_dto.Email_Clie);
                classacessobancodados.AdicionarParametos("@DataNasc_Clie", classcliente_dto.DataNasc_Clie);
                //capturando ID ou uma string de erro que volta da procedure*/
                string Idcliente = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirCliente").ToString();
                //retornando id para o methodo
                return Idcliente;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizar(ClassCliente_DTO classcliente_dto)
        {
            if (classcliente_dto == null)
            {

                throw new ArgumentNullException("Erro ao atualizar cliente");
            }
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Endereço
                classacessobancodados.AdicionarParametos("@ID_Endereco", classcliente_dto.classEndereco_DTO.ID_Endereco);
                classacessobancodados.AdicionarParametos("@CEP_Ende", classcliente_dto.classEndereco_DTO.CEP_Ende);
                classacessobancodados.AdicionarParametos("@Endereco_Ende", classcliente_dto.classEndereco_DTO.Endereco_Ende);
                classacessobancodados.AdicionarParametos("@Numero_Ende", classcliente_dto.classEndereco_DTO.Numero_Ende);
                classacessobancodados.AdicionarParametos("@Complemento_Ende", classcliente_dto.classEndereco_DTO.Complemento_Ende);
                classacessobancodados.AdicionarParametos("@Bairro_Ende", classcliente_dto.classEndereco_DTO.Bairro_Ende);
                classacessobancodados.AdicionarParametos("@Cidade_Ende", classcliente_dto.classEndereco_DTO.Cidade_Ende);
                classacessobancodados.AdicionarParametos("@UF_Ende", classcliente_dto.classEndereco_DTO.UF_Ende);
                //Cliente
                classacessobancodados.AdicionarParametos("@ID_Cliente", classcliente_dto.ID_Cliente);
                classacessobancodados.AdicionarParametos("@Nome_Clie", classcliente_dto.Nome_Clie);
                classacessobancodados.AdicionarParametos("@RG_Clie", classcliente_dto.RG_Clie);
                classacessobancodados.AdicionarParametos("@CPF_Clie", classcliente_dto.CPF_Clie);
                classacessobancodados.AdicionarParametos("@Email_Clie", classcliente_dto.Email_Clie);
                classacessobancodados.AdicionarParametos("@DataNasc_Clie", classcliente_dto.DataNasc_Clie);
                //capturando ID ou uma string de erro que volta da procedure
                string Idcliente = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspAtualizarCliente").ToString();
                // retornando id para o methodo
                return Idcliente;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Deletar(ClassCliente_DTO classcliente_dto)
        {
            if (classcliente_dto == null)
            {

                throw new ArgumentNullException("Erro ao deletar cliente");
            }

            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Instanciando Objetos
                //Endereço
                classcliente_dto.classEndereco_DTO = new ClassEndereco_DTO();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Cliente", classcliente_dto.ID_Cliente);
                classacessobancodados.AdicionarParametos("@ID_Endereco", classcliente_dto.classEndereco_DTO.ID_Endereco);
                //capturando ID ou uma string de erro que volta da procedure
                string Idcliente = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarCliente").ToString();
                // retornando id para o methodo
                return Idcliente;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo para consultar por nome
        public ClassClienteCollection_DTO ConsultaPorNome(string nome)
        {
            try
            {
                //criar uma coleção de clientes aqui ela esta vazia
                ClassClienteCollection_DTO clienteColecao = new ClassClienteCollection_DTO();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", nome);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableCliente = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarCliente");
                //Percorrer o datatable e transforma lo em uma colecao de clientes
                //cada linha do datable é um cliente
                //Data = dados Row = linha
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //criar um cliente vazio
                    ClassCliente_DTO classCliente_DTO = new ClassCliente_DTO();
                    //colocar dados da linha nele
                    //Cliente
                    if (linha["ID_Cliente"] != DBNull.Value) { classCliente_DTO.ID_Cliente = Convert.ToInt32(linha["ID_Cliente"]); }
                    if (linha["Nome_Clie"] != DBNull.Value) { classCliente_DTO.Nome_Clie = Convert.ToString(linha["Nome_Clie"]); }
                    if (linha["RG_Clie"] != DBNull.Value) { classCliente_DTO.RG_Clie = Convert.ToString(linha["RG_Clie"]); }
                    if (linha["CPF_Clie"] != DBNull.Value) { classCliente_DTO.CPF_Clie = Convert.ToString(linha["CPF_Clie"]); }
                    if (linha["Email_Clie"] != DBNull.Value) { classCliente_DTO.Email_Clie = Convert.ToString(linha["Email_Clie"]); }
                    if (linha["DataNasc_Clie"] != DBNull.Value) { classCliente_DTO.DataNasc_Clie = Convert.ToDateTime(linha["DataNasc_Clie"]); }
                    if (linha["Data_Cadastro_Clie"] != DBNull.Value) { classCliente_DTO.Data_Cadastro_Clie = Convert.ToDateTime(linha["Data_Cadastro_Clie"]); }
                    //Endereço
                    classCliente_DTO.classEndereco_DTO = new ClassEndereco_DTO();
                    if (linha["ID_Endereco"] != DBNull.Value) { classCliente_DTO.classEndereco_DTO.ID_Endereco = Convert.ToInt32(linha["ID_Endereco"]); }
                    if (linha["CEP_Ende"] != DBNull.Value) { classCliente_DTO.classEndereco_DTO.CEP_Ende = Convert.ToString(linha["CEP_Ende"]); }
                    if (linha["Endereco_Ende"] != DBNull.Value) { classCliente_DTO.classEndereco_DTO.Endereco_Ende = Convert.ToString(linha["Endereco_Ende"]); }
                    if (linha["Numero_Ende"] != DBNull.Value) { classCliente_DTO.classEndereco_DTO.Numero_Ende = Convert.ToInt32(linha["Numero_Ende"]); }
                    if (linha["Complemento_Ende"] != DBNull.Value) { classCliente_DTO.classEndereco_DTO.Complemento_Ende = Convert.ToString(linha["Complemento_Ende"]); }
                    if (linha["Bairro_Ende"] != DBNull.Value) { classCliente_DTO.classEndereco_DTO.Bairro_Ende = Convert.ToString(linha["Bairro_Ende"]); }
                    if (linha["Cidade_Ende"] != DBNull.Value) { classCliente_DTO.classEndereco_DTO.Cidade_Ende = Convert.ToString(linha["Cidade_Ende"]); }
                    if (linha["UF_Ende"] != DBNull.Value) { classCliente_DTO.classEndereco_DTO.UF_Ende = Convert.ToString(linha["UF_Ende"]); }
                    //Telefone
                    classCliente_DTO.classTelefone_DTO = new ClassTelefone_DTO();
                    if (linha["ID_Telefone"] != DBNull.Value) { classCliente_DTO.classTelefone_DTO.ID_Telefone = Convert.ToInt32(linha["ID_Telefone"]); }
                    if (linha["DDD_Tele"] != DBNull.Value) { classCliente_DTO.classTelefone_DTO.DDD_Tele = Convert.ToInt32(linha["DDD_Tele"]); }
                    if (linha["Telefone_Tele"] != DBNull.Value) { classCliente_DTO.classTelefone_DTO.Telefone_Tele = Convert.ToString(linha["Telefone_Tele"]); }
                    //Tipo de Telefone
                    classCliente_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO();
                    if (linha["ID_Tipo_Telefone"] != DBNull.Value) { classCliente_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone = Convert.ToInt32(linha["ID_Tipo_Telefone"]); }
                    if (linha["Descricao_TTele"] != DBNull.Value) { classCliente_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele = Convert.ToString(linha["Descricao_TTele"]); }
                    //adicionando para a coleção
                    clienteColecao.Add(classCliente_DTO);
                }
                //retornando a coleção preenchida
                return clienteColecao;
            }
            catch (Exception ex)
            {
                //caso de erro
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + ex.Message);
            }
        }
    }
}