using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassAgendamento_BLL
    {
        string InserirAgendamento(ClassAgendamento_DTO classAgendamento_dto);
        //Metodo para consultar por nome
        ClassAgendamento_Collection_DTO ConsultaPorNome(string nome);
        //Metodo para consultar horarios do salão
        List<ClassHoraSalao> ConsultaHorarioSalao();
        //Metodo Excluir
        string ExcluirAgendamento(ClassAgendamento_DTO classAgendamento_dto);
    }
}
