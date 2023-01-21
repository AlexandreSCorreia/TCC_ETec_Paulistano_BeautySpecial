using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public interface IClassAgendamento_BLL
    {
        string InserirAgendamento(ClassAgendamento_DTO classAgendamento_dto);

        //Metodo para consultar por nome
        List<ClassAgendamento_DTO> ConsultaPorNome(string nome);


        //Metodo para consultar horarios do salão
        List<ClassHoraSalao> ConsultaHorarioSalao();
      
    }
}
