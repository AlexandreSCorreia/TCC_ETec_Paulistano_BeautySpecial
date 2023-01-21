using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CamadaAcessoADados_DTO;
using ObjetoTransferenciaDeDados_DAL;

namespace CamadaLogicaDeNegocios_BLL
{
    public interface IClassLogin_BLL
    {
        //Metodo para logar no sistema
        List<ClassLogin_DTO> LogarNoSistema(string email, string senha);

        //Metodo para logar no sistema
        DataTable BuscarClienteLog(Int32 ID);

        //Methodo de inserir recebe um objeto como parametros
        string InserirLogin(ClassLogin_DTO classLogin_DTO);

        //Methodo de inserir recebe um objeto como parametros
        string AtualizarLogin(ClassLogin_DTO classLogin_DTO);

        //Metodo Excluir
        string ExcluirLogin(Int32 ID);
   
    }
}
