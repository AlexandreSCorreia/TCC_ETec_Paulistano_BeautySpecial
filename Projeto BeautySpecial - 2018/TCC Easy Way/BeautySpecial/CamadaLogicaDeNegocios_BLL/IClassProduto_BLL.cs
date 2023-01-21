using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassProduto_BLL
    {



        //Methodo de inserir recebe um objeto como parametro um objeto 
        string InserirProduto(ClassProduto_DTO classProduto_dto);

        //Methodo de inserir recebe um objeto como parametros
        string InserirServicosProduto(ClassProduto_DTO classProduto_DTO);

        //Metodo Atualizar
        string AtualizarProduto(ClassProduto_DTO classProduto_dto);

        //Metodo Excluir
        string ExcluirProduto(ClassProduto_DTO classProduto_dto);


        //Metodo Excluir
        string ExcluirServicoProduto(ClassProduto_DTO classProduto_dto);

        //Metodo para consultar por nome
        ClassProdutoCollection_DTO ConsultaPorNome(string nome);


        //Metodo para consultar por nome
        DataTable ConsultaPorNome(Int32 ID);


    }
}
