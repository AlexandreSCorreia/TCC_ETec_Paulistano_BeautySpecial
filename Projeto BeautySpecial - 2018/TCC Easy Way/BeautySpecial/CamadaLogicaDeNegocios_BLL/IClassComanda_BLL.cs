using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassComanda_BLL
    {
        //Methodo de inserir recebe um objeto como parametros
        string InserirComanda(ClassComanda_DTO classComanda_DTO);
        //Methodo de inserir recebe um objeto como parametros
        string InserirServicosComanda(ClassComanda_DTO classComanda_DTO);
        //Methodo atualizar comanda
        string AtualizarComanda(Int32 ID_Comanda, Decimal Valor);
        //Methodo de inserir recebe um objeto como parametros
        string InserirProdutoComanda(ClassComanda_DTO classComanda_DTO);
        //Metodo Excluir
        string ExcluirComanda(ClassComanda_DTO classComanda_dto);
        //Metodo Excluir serviço comanda
        string ExcluirServicoComanda(Int32 ID_Comanda);
        //Metodo Excluir produto comanda
        string ExcluirProdutoComanda(Int32 ID_Comanda);
        //Metodo para consultar por nome
        ClassComanda_Collection_DTO ConsultaPorNome(string nome);
        //Metodo para consultar por nome
        DataTable ConsultaServicoComanda(Int32 ID);
        //Metodo para consultar por nome
        DataTable ConsultaProdutoComanda(Int32 ID);
       

    }
}
