using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IPermissao_BLL
    {
        //Methodo de inserir recebe um objeto como parametro um objeto
        string InserirPermUsuario(Permissao_DTO permissao_DTO);
        //Metodo Excluir
        string ExcluirPermUsuario(int id);
        //Metodo para consultar por nome
        DataTable ConsultaPermGru(int id);
        //Metodo para localizar a permissão do usuario
        DataTable LocalizarPermissao(int id, string nomeform);
       
    }
}
