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
    public class ClassAgendamentoController : ApiController
    {
        private readonly IClassAgendamento_BLL classAgendamento_BLL;

        public ClassAgendamentoController()
        {
            classAgendamento_BLL = new ClassAgendamento_BLl();
        }

        [HttpGet]
        public List<ClassAgendamento_DTO> ConsultaPorNome(string nome)
        {

            return classAgendamento_BLL.ConsultaPorNome(nome);
        }


        [HttpGet]
        public List<ClassHoraSalao> ConsultaHorarioSalao()
        {

            return classAgendamento_BLL.ConsultaHorarioSalao();
        }

        [HttpPost()]
        public String Post([FromBody] ClassAgendamento_DTO ClassAgendamento_DTO)
        {
            String Retorno = classAgendamento_BLL.InserirAgendamento(ClassAgendamento_DTO);
            return Retorno;
        }

       /* [HttpPut()]
        public void Put([FromBody]ClassAgendamento_DTO ClassAgendamento_DTO)
        {
            classAgendamento_BLL.Atualizar(ClassAgendamento_DTO);
        }

        [HttpDelete()]
        public void Delete([FromBody]ClassAgendamento_DTO ClassAgendamento_DTO)
        {
            classAgendamento_BLL.Deletar(ClassAgendamento_DTO);
        }*/
    }
}
