using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassServico_BLL
    {
        //Methodo de inserir recebe um objeto como parametro objeto
        string InserirServico(ClassServico_DTO classServico_dto);
       
        string AtualizarServico(ClassServico_DTO classServico_dto);
       
        //Metodo Excluir
        string ExcluirServico(ClassServico_DTO classServico_dto);
      

        //Metodo para consultar por nome
        ClassServicoCollection_DTO ConsultaPorNome(string nome);
       
    }
}
