using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassFuncionario_BLL
    {
        //Methodo de inserir recebe um objeto como parametro classfuncionario dto 
        string InserirFuncionario(ClassFuncionario_DTO classFuncionario_dto);
        //Metodo Atualizar
        string AtualizarFuncionario(ClassFuncionario_DTO classFuncionario_dto);
        //Metodo Excluir
        string ExcluirFuncionario(ClassFuncionario_DTO classFuncionario_dto);
        //Metodo para consultar por nome
        ClassFuncionarioCollection_DTO ConsultaPorNome(string nome);
       
    }
}
