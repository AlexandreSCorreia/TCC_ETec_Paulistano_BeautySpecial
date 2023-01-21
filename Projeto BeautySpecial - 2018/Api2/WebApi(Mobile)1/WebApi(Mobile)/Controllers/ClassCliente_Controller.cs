using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
using System.Web;

namespace Controllers
{
    public class ClassCliente_Controller : ApiController
    {
        private readonly IClassCliente_BLL classCliente_BLL;

        public ClassCliente_Controller()
        {
            classCliente_BLL = new ClassCliente_BLL();
        }

        [HttpGet]
        public ClassClienteCollection_DTO ConsultaPorNome(string nome)
       {

            return classCliente_BLL.ConsultaPorNome(nome);
        }

        [HttpPost()]
        public string Post([FromBody] ClassCliente_DTO classCliente_DTO)
        {
          String Retorno =  classCliente_BLL.Inserir(classCliente_DTO);
          return Retorno;
        }

        [HttpPut()]
        public void Put([FromBody]ClassCliente_DTO classCliente_DTO)
        {
            classCliente_BLL.Atualizar(classCliente_DTO);
        }

        [HttpDelete()]
        public void Delete([FromBody]ClassCliente_DTO classCliente_DTO)
        {
            classCliente_BLL.Deletar(classCliente_DTO);
        }
    }
}