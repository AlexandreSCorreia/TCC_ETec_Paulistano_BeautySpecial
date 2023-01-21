using System;
using System.Data;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
//Chamando referencia de outras pastas dentro do projeto
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    
    public class ClassLogin_BLL
    {
        HttpClient client = new HttpClient();


        //Metodo para logar no sistema
        public async Task<List<ClassLogin_DTO>> LogarNoSistema(string email,string senha)
        {
            try
            {
                string url = "http://192.168.0.10:16340/api/ClassLogin?email="+email+"&senha="+senha;
                HttpResponseMessage response = await client.GetAsync(url);
                var ClienteJsonString = await response.Content.ReadAsStringAsync();
                var cliente_dto = JsonConvert.DeserializeObject<List<ClassLogin_DTO>>(ClienteJsonString);
                return cliente_dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Metodo para logar no sistema
        public async Task<List<ClassLogin_DTO>> BuscarFuncionarioLog(Int32 ID)
        {
            try
            {
                string url = "http://192.168.0.110:19158/api/ClassCliente_/"+ID;
                HttpResponseMessage response = await client.GetAsync(url);
                var ClienteJsonString = await response.Content.ReadAsStringAsync();
                var cliente_dto = JsonConvert.DeserializeObject<List<ClassLogin_DTO>>(ClienteJsonString);
                return cliente_dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        //Methodo de inserir recebe um objeto como parametros
        public async Task InserirLogin(ClassLogin_DTO classLogin_DTO)
        {
            try
            {
                string url = "http://192.168.0.110:19158/api/ClassCliente_/{0}";
                var uri = new Uri(string.Format(url, classLogin_DTO.ID_Login));
                var data = JsonConvert.SerializeObject(classLogin_DTO);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao cadastrar cliente");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       /* //Methodo de inserir recebe um objeto como parametros
        public string AtualizarLogin(ClassLogin_DTO classLogin_DTO)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                //Login
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Log", classLogin_DTO.classFuncionario_DTO.ID_Funcionario);
                classacessobancodados.AdicionarParametos("@Senha_Log", classLogin_DTO.Senha_Log);
                //capturando ID ou uma string de erro que volta da procedure*/
          /*      string Idlogin = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspAtualizarLogin").ToString();
                //retornando id para o methodo
                return Idlogin;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Metodo Excluir
        public string ExcluirLogin(Int32 ID)
        {
            try
            {
                //Limpando Parametros
                classacessobancodados.LimparParametros();
                //Passando parametros para procedure
                classacessobancodados.AdicionarParametos("@ID_Funcionario_Log", ID);
                //capturando ID ou uma string de erro que volta da procedure
                string Idlogin = classacessobancodados.Executa_ComandoSQL(CommandType.StoredProcedure, "uspDeletarLogin").ToString();
                // retornando id para o methodo
                return Idlogin;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }*/
    }
}
