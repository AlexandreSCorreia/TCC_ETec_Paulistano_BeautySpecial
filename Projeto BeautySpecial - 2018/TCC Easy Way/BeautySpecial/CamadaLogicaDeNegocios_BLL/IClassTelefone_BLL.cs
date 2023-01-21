using CamadaAcessoADados_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogicaDeNegocios_BLL
{
    interface IClassTelefone_BLL
    {
        string InserirTelefone(ClassTelefone_DTO classTelefone_DTO);
        //Metodo Atualizar
        string AtualizarTelefone(ClassTelefone_DTO classTelefone_DTO);
        //Metodo Excluir
        string ExcluirTelefone(int id_cliente_tele, int id_funcionario_tele);
       
    }
}
