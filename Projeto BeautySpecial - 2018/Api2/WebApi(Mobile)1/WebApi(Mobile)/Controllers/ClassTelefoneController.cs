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
    public class ClassTelefoneController : ApiController
    {

        private readonly IClassTelefone_BLL classTelefone_BLL;

        public ClassTelefoneController()
        {
            classTelefone_BLL = new ClassTelefone_BLL();
        }

        [HttpPost()]
        public String Post([FromBody] ClassTelefone_DTO classTelefone_DTO)
        {
            String Retorno= classTelefone_BLL.Inserir(classTelefone_DTO);
            return Retorno;
        }

        [HttpPut()]
        public void Put([FromBody]ClassTelefone_DTO classTelefone_DTO)
        {
            classTelefone_BLL.Atualizar(classTelefone_DTO);
        }

        [HttpDelete()]
        public void Delete([FromBody]int id_cliente_tele, int id_funcionario_tele)
        {
            classTelefone_BLL.Deletar(id_cliente_tele, id_funcionario_tele);
        }
    }
}
