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
    public class ClassTelefone_BLL
    {
        HttpClient client = new HttpClient();


        // Instanciar - criar um novo objeto baseado em um modelo
        ClassAcessoBancoDados classacessobancodados = new ClassAcessoBancoDados();
        //Methodo de inserir recebe um objeto como parametro classTelefone dto 
        public async Task<String> InserirTelefone(ClassTelefone_DTO classtelefone_dto)
        {
            try
            {
                string url = "http://192.168.0.10:16340/api/ClassTelefone_/{0}";
                var uri = new Uri(string.Format(url, classtelefone_dto.ID_Telefone));
                var data = JsonConvert.SerializeObject(classtelefone_dto);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);
                var ClienteJsonString = await response.Content.ReadAsStringAsync();
                string telefone_dto = JsonConvert.DeserializeObject<String>(ClienteJsonString);
                return telefone_dto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}