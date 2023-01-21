using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassTipoPagamento_BLL
    {
        //Metodo para consultar por nome
        List<ClassTipoPagamento_DTO> ConsultaTipoPagamento();
        
    }
}
