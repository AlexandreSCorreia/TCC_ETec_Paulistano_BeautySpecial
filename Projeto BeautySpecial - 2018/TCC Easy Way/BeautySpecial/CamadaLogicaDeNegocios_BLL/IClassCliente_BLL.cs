using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassCliente_BLL
    {
        string InserirCliente(ClassCliente_DTO classcliente_dto);


        //Metodo Atualizar
        string AtualizarCliente(ClassCliente_DTO classcliente_dto);


        //Metodo Excluir
        string ExcluirCliente(ClassCliente_DTO classcliente_dto);


        //Metodo para consultar por nome
        ClassClienteCollection_DTO ConsultaPorNome(string nome);
       
    }
}
