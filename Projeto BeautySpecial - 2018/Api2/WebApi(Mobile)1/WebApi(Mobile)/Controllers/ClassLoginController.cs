using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
using System.Web;
using System.Data;

namespace Controllers
{
    public class ClassLoginController : ApiController
    {
        private readonly IClassLogin_BLL classLogin_BLL;

        public ClassLoginController()
        {
            classLogin_BLL = new ClassLogin_BLL();
        }

        [HttpGet]
        public List<ClassLogin_DTO> LogarNoSistema(string email, string senha)
        {

            return classLogin_BLL.LogarNoSistema(email,senha);
        }


        [HttpGet]
        public DataTable BuscarClienteLog(Int32 ID)
        {

            return classLogin_BLL.BuscarClienteLog(ID);
        }

        [HttpPost()]
        public string Post([FromBody] ClassLogin_DTO classLogin_DTO)
        {
           String Retorno = classLogin_BLL.InserirLogin(classLogin_DTO);
            return Retorno;
        }

        [HttpPut()]
        public string Put([FromBody]ClassLogin_DTO classLogin_DTO)
        {
            String Retorno = classLogin_BLL.AtualizarLogin(classLogin_DTO);
            return Retorno;
        }

        [HttpDelete()]
        public string Delete([FromBody]Int32 ID)
        {
            String Retorno = classLogin_BLL.ExcluirLogin(ID);
            return Retorno;
        }
    }
}
