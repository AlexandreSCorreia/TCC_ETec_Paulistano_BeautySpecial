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
    public class ClassCliente_BLL
    {
        HttpClient client = new HttpClient();
       

        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Methodo de inserir recebe um objeto como parametro classcliente dto 
        public async Task<String> InserirCliente(ClassCliente_DTO classcliente_dto)
        {
            try
            {
                  string url = "http://192.168.0.10:16340/api/ClassCliente_/{0}";
                  var uri = new Uri(string.Format(url, classcliente_dto.ID_Cliente));
                  var data = JsonConvert.SerializeObject(classcliente_dto);
                  var content = new StringContent(data, Encoding.UTF8, "application/json");
                  HttpResponseMessage response = null;
                  response = await client.PostAsync(uri, content);

                String Id = response.Content.ReadAsStringAsync().Result;
                return Id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

      

        //Metodo Atualizar
        public async Task AtualizarCliente(ClassCliente_DTO classcliente_dto)
        {
            string url = "http://192.168.0.110:16340/api/ClassCliente_/{0}";
            var uri = new Uri(string.Format(url, classcliente_dto.ID_Cliente));
            var data = JsonConvert.SerializeObject(classcliente_dto);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await client.PutAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao atualizar cliente");
                }
        }

        //Metodo Excluir
        public async Task ExcluirCliente(ClassCliente_DTO classcliente_dto)
        {
            string url = "http://192.168.0.110:19158/api/ClassCliente_/{0}";
            var uri = new Uri(string.Format(url, classcliente_dto.ID_Cliente));
            await client.DeleteAsync(uri);

        }

        //Metodo para consultar por nome
        public async Task<ClassClienteCollection_DTO> ConsultaPorNome(string nome)
        {
                try
                {
                    string url = "http://192.168.0.110:19158/api/ClassCliente_/{0}" + "/" + nome;
                    HttpResponseMessage response = await client.GetAsync(url);
                    var ClienteJsonString = await response.Content.ReadAsStringAsync();
                    var cliente_dto = JsonConvert.DeserializeObject<ClassClienteCollection_DTO>(ClienteJsonString);
                    return cliente_dto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

        }
    }
}
