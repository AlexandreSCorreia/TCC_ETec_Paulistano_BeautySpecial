using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassLogin_BLL
    {
        //Metodo para logar no sistema
        DataTable LogarNoSistema(string cpf, string senha);
        //Metodo para logar no sistema
        DataTable BuscarFuncionarioLog(Int32 ID);
        //Methodo de inserir recebe um objeto como parametros
        string InserirLogin(ClassLogin_DTO classLogin_DTO);
        //Methodo de inserir recebe um objeto como parametros
        string AtualizarLogin(ClassLogin_DTO classLogin_DTO);
        //Metodo Excluir
        string ExcluirLogin(Int32 ID);
       
    }
}
