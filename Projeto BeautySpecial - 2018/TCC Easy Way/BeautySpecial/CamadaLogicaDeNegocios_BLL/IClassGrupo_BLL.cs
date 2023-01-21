using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassGrupo_BLL
    {
        //Metodo para consultar por nome
        List<ClassGrupo_DTO> ConsultaGrupo(String nome);
        //Metodo para localizar funcionario por id
        DataTable LocalizarGruPorID(int id);
        
    }
}
