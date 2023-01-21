using System;
using System.Data;
//Chamando referencia de outras pastas dentro do projeto
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;


namespace CamadaLogicaDeNegocios_BLL
{
    public class ClassFuncionario_BLL : IClassFuncionario_BLL
    {
        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Methodo de inserir recebe um objeto como parametro classfuncionario dto 
        public string InserirFuncionario(ClassFuncionario_DTO classFuncionario_dto)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Endereço
                classacessobancodados.AdicionarParametos("@CEP_Ende", classFuncionario_dto.classEndereco_DTO.CEP_Ende);
                classacessobancodados.AdicionarParametos("@Endereco_Ende", classFuncionario_dto.classEndereco_DTO.Endereco_Ende);
                classacessobancodados.AdicionarParametos("@Numero_Ende", classFuncionario_dto.classEndereco_DTO.Numero_Ende);
                classacessobancodados.AdicionarParametos("@Complemento_Ende", classFuncionario_dto.classEndereco_DTO.Complemento_Ende);
                classacessobancodados.AdicionarParametos("@Bairro_Ende", classFuncionario_dto.classEndereco_DTO.Bairro_Ende);
                classacessobancodados.AdicionarParametos("@Cidade_Ende", classFuncionario_dto.classEndereco_DTO.Cidade_Ende);
                classacessobancodados.AdicionarParametos("@UF_Ende", classFuncionario_dto.classEndereco_DTO.UF_Ende);
                //Funcionario
                classacessobancodados.AdicionarParametos("@Nome_Func", classFuncionario_dto.Nome_Func);
                classacessobancodados.AdicionarParametos("@RG_Func", classFuncionario_dto.RG_Func);
                classacessobancodados.AdicionarParametos("@CPF_Func", classFuncionario_dto.CPF_Func);
                classacessobancodados.AdicionarParametos("@Email_Func", classFuncionario_dto.Email_Func);
                classacessobancodados.AdicionarParametos("@DataNasc_Func", classFuncionario_dto.DataNasc_Func);
                classacessobancodados.AdicionarParametos("@DataAdmissao_Func", classFuncionario_dto.DataAdmissao_Func);
                //Grupo
                classacessobancodados.AdicionarParametos("@ID_Grupo_Func", classFuncionario_dto.classGrupo_DTO.ID_Grupo);
                //Cargo
                classacessobancodados.AdicionarParametos("@Funcao_Carg", classFuncionario_dto.classCargo_DTO.Funcao_Carg);
                classacessobancodados.AdicionarParametos("@Salario_Carg", classFuncionario_dto.classCargo_DTO.Salario_Carg);
                classacessobancodados.AdicionarParametos("@Horario_Entrada_Carg", classFuncionario_dto.classCargo_DTO.Horario_Entrada_Carg);
                classacessobancodados.AdicionarParametos("@Horario_Saida_Carg", classFuncionario_dto.classCargo_DTO.Horario_Saida_Carg);
                //capturando ID ou uma string de erro que volta da procedure
                string Idfuncionario = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspInserirFuncionario").ToString();
                //retornando id para o methodo
                return Idfuncionario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo Atualizar
        public string AtualizarFuncionario(ClassFuncionario_DTO classFuncionario_dto)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Endereço
                classacessobancodados.AdicionarParametos("@ID_Endereco", classFuncionario_dto.classEndereco_DTO.ID_Endereco);
                classacessobancodados.AdicionarParametos("@CEP_Ende", classFuncionario_dto.classEndereco_DTO.CEP_Ende);
                classacessobancodados.AdicionarParametos("@Endereco_Ende", classFuncionario_dto.classEndereco_DTO.Endereco_Ende);
                classacessobancodados.AdicionarParametos("@Numero_Ende", classFuncionario_dto.classEndereco_DTO.Numero_Ende);
                classacessobancodados.AdicionarParametos("@Complemento_Ende", classFuncionario_dto.classEndereco_DTO.Complemento_Ende);
                classacessobancodados.AdicionarParametos("@Bairro_Ende", classFuncionario_dto.classEndereco_DTO.Bairro_Ende);
                classacessobancodados.AdicionarParametos("@Cidade_Ende", classFuncionario_dto.classEndereco_DTO.Cidade_Ende);
                classacessobancodados.AdicionarParametos("@UF_Ende", classFuncionario_dto.classEndereco_DTO.UF_Ende);
                //Funcionario
                classacessobancodados.AdicionarParametos("@ID_Funcionario", classFuncionario_dto.ID_Funcionario);
                classacessobancodados.AdicionarParametos("@Nome_Func", classFuncionario_dto.Nome_Func);
                classacessobancodados.AdicionarParametos("@RG_Func", classFuncionario_dto.RG_Func);
                classacessobancodados.AdicionarParametos("@CPF_Func", classFuncionario_dto.CPF_Func);
                classacessobancodados.AdicionarParametos("@Email_Func", classFuncionario_dto.Email_Func);
                classacessobancodados.AdicionarParametos("@DataNasc_Func", classFuncionario_dto.DataNasc_Func);
                classacessobancodados.AdicionarParametos("@DataAdmissao_Func", classFuncionario_dto.DataAdmissao_Func);
                //Grupo
                classacessobancodados.AdicionarParametos("@ID_Grupo_Func", classFuncionario_dto.classGrupo_DTO.ID_Grupo);
                //Cargo
                classacessobancodados.AdicionarParametos("@ID_Cargo", classFuncionario_dto.classCargo_DTO.ID_Cargo);
                classacessobancodados.AdicionarParametos("@Funcao_Carg", classFuncionario_dto.classCargo_DTO.Funcao_Carg);
                classacessobancodados.AdicionarParametos("@Salario_Carg", classFuncionario_dto.classCargo_DTO.Salario_Carg);
                classacessobancodados.AdicionarParametos("@Horario_Entrada_Carg", classFuncionario_dto.classCargo_DTO.Horario_Entrada_Carg);
                classacessobancodados.AdicionarParametos("@Horario_Saida_Carg", classFuncionario_dto.classCargo_DTO.Horario_Saida_Carg);
                //capturando ID ou uma string de erro que volta da procedure
                string Idfuncionario = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspAtualizarFuncionario").ToString();
                // retornando id para o methodo
                return Idfuncionario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Metodo Excluir
        public string ExcluirFuncionario(ClassFuncionario_DTO classFuncionario_dto)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //instanciando Obejetos
                //Endereço
                classFuncionario_dto.classEndereco_DTO = new ClassEndereco_DTO();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Funcionario", classFuncionario_dto.ID_Funcionario);
                classacessobancodados.AdicionarParametos("@ID_Cargo", classFuncionario_dto.classCargo_DTO.ID_Cargo);
                classacessobancodados.AdicionarParametos("@ID_Endereco", classFuncionario_dto.classEndereco_DTO.ID_Endereco);
                //capturando ID ou uma string de erro que volta da procedure
                string Idfuncionario = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarFuncionario").ToString();
                // retornando id para o methodo
                return Idfuncionario;
            }
            catch (Exception ex)
            {
                //Caso de erro retorna um  erro
                return ex.Message;
            }
        }

        //Metodo para consultar por nome
        public ClassFuncionarioCollection_DTO ConsultaPorNome(string nome)
        {
            try
            {
                //criar uma coleção de funcionarios aqui ela esta vazia
                ClassFuncionarioCollection_DTO funcionarioColecao = new ClassFuncionarioCollection_DTO();
                classacessobancodados.LimparParametros();
                classacessobancodados.AdicionarParametos("@Pesquisa", nome);
                //Data = dados Table = tabela tabela de dados
                DataTable dataTableFuncionario = classacessobancodados.ExecutaConsulta(CommandType.StoredProcedure, "ConsultarFuncionario");

                //Percorrer o datatable e transforma lo em uma colecao de clientes
                //cada linha do datable é um funcionario
                //Data = dados Row = linha
                foreach (DataRow linha in dataTableFuncionario.Rows)
                {
                    //criar um funcionario vazio
                    //colocar dados da linha nele
                    //adicionar ele na colleção
                    //funcionario
                    ClassFuncionario_DTO classFuncionario_DTO = new ClassFuncionario_DTO();
                    if (linha["ID_Funcionario"] != DBNull.Value) { classFuncionario_DTO.ID_Funcionario = Convert.ToInt32(linha["ID_Funcionario"]); }
                    if (linha["Nome_Func"] != DBNull.Value) { classFuncionario_DTO.Nome_Func = Convert.ToString(linha["Nome_Func"]); }
                    if (linha["RG_Func"] != DBNull.Value) { classFuncionario_DTO.RG_Func = Convert.ToString(linha["RG_Func"]); }
                    if (linha["CPF_Func"] != DBNull.Value)  { classFuncionario_DTO.CPF_Func = Convert.ToString(linha["CPF_Func"]); }
                    if (linha["Email_Func"] != DBNull.Value) { classFuncionario_DTO.Email_Func = Convert.ToString(linha["Email_Func"]); }
                    if (linha["DataNasc_Func"] != DBNull.Value)  { classFuncionario_DTO.DataNasc_Func = Convert.ToDateTime(linha["DataNasc_Func"]); }
                    if (linha["DataAdmissao_Func"] != DBNull.Value)  { classFuncionario_DTO.DataAdmissao_Func = Convert.ToDateTime(linha["DataAdmissao_Func"]); }
                    //Grupo
                    classFuncionario_DTO.classGrupo_DTO = new ClassGrupo_DTO();
                    if (linha["ID_Grupo"] != DBNull.Value) { classFuncionario_DTO.classGrupo_DTO.ID_Grupo = Convert.ToInt32(linha["ID_Grupo"]); }
                    if (linha["Descricao_Grup"] != DBNull.Value) { classFuncionario_DTO.classGrupo_DTO.Descricao_Grup = Convert.ToString(linha["Descricao_Grup"]); }
                    //Endereço
                    classFuncionario_DTO.classEndereco_DTO = new ClassEndereco_DTO();
                    if (linha["ID_Endereco"] != DBNull.Value)  { classFuncionario_DTO.classEndereco_DTO.ID_Endereco = Convert.ToInt32(linha["ID_Endereco"]); }
                    if (linha["CEP_Ende"] != DBNull.Value)  { classFuncionario_DTO.classEndereco_DTO.CEP_Ende = Convert.ToString(linha["CEP_Ende"]); }
                    if (linha["Endereco_Ende"] != DBNull.Value) { classFuncionario_DTO.classEndereco_DTO.Endereco_Ende = Convert.ToString(linha["Endereco_Ende"]); }
                    if (linha["Numero_Ende"] != DBNull.Value)  { classFuncionario_DTO.classEndereco_DTO.Numero_Ende = Convert.ToInt32(linha["Numero_Ende"]); }
                    if (linha["Complemento_Ende"] != DBNull.Value)  { classFuncionario_DTO.classEndereco_DTO.Complemento_Ende = Convert.ToString(linha["Complemento_Ende"]); }
                    if (linha["Bairro_Ende"] != DBNull.Value) { classFuncionario_DTO.classEndereco_DTO.Bairro_Ende = Convert.ToString(linha["Bairro_Ende"]); }
                    if (linha["Cidade_Ende"] != DBNull.Value)  { classFuncionario_DTO.classEndereco_DTO.Cidade_Ende = Convert.ToString(linha["Cidade_Ende"]); }
                    if (linha["UF_Ende"] != DBNull.Value)  { classFuncionario_DTO.classEndereco_DTO.UF_Ende = Convert.ToString(linha["UF_Ende"]); }
                    //Cargo
                    classFuncionario_DTO.classCargo_DTO = new ClassCargo_DTO();
                    if (linha["ID_Cargo"] != DBNull.Value)  { classFuncionario_DTO.classCargo_DTO.ID_Cargo = Convert.ToInt32(linha["ID_Cargo"]); }
                    if (linha["Funcao_Carg"] != DBNull.Value)  { classFuncionario_DTO.classCargo_DTO.Funcao_Carg = Convert.ToString(linha["Funcao_Carg"]); }
                    if (linha["Salario_Carg"] != DBNull.Value)  { classFuncionario_DTO.classCargo_DTO.Salario_Carg = Convert.ToDecimal(linha["Salario_Carg"]); }
                    if (linha["Horario_Entrada_Carg"] != DBNull.Value)  { classFuncionario_DTO.classCargo_DTO.Horario_Entrada_Carg = Convert.ToString(linha["Horario_Entrada_Carg"]); }
                    if (linha["Horario_Saida_Carg"] != DBNull.Value)  { classFuncionario_DTO.classCargo_DTO.Horario_Saida_Carg = Convert.ToString(linha["Horario_Saida_Carg"]); }
                    //Telefone
                    classFuncionario_DTO.classTelefone_DTO = new ClassTelefone_DTO();
                    if (linha["ID_Telefone"] != DBNull.Value)  { classFuncionario_DTO.classTelefone_DTO.ID_Telefone = Convert.ToInt32(linha["ID_Telefone"]); }
                    if (linha["DDD_Tele"] != DBNull.Value)  { classFuncionario_DTO.classTelefone_DTO.DDD_Tele = Convert.ToInt32(linha["DDD_Tele"]); }
                    if (linha["Telefone_Tele"] != DBNull.Value)  { classFuncionario_DTO.classTelefone_DTO.Telefone_Tele = Convert.ToString(linha["Telefone_Tele"]); }
                    //Tipo de Telefone
                    classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO();
                    if (linha["ID_Tipo_Telefone"] != DBNull.Value) { classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone = Convert.ToInt32(linha["ID_Tipo_Telefone"]); }
                    if (linha["Descricao_TTele"] != DBNull.Value) { classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele = Convert.ToString(linha["Descricao_TTele"]); }
                    //adicionando para a coleção
                    funcionarioColecao.Add(classFuncionario_DTO);
                }
                //retornando a coleção preenchida
                return funcionarioColecao;
            }
            catch (Exception ex)
            {
                //Caso de erro
                throw new Exception("Não foi possivel consultar o funcionario. Detalhes: " + ex.Message);
            }
        }
    }
}
