using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaAcessoADados_DTO;

namespace CamadaLogicaDeNegocios_BLL
{
    public interface IClassTelefone_BLL
    {
        string Inserir(ClassTelefone_DTO classTelefone_dto);
        string Atualizar(ClassTelefone_DTO classTelefone_dto);
        string Deletar(int id_cliente_tele, int id_funcionario_tele);
    }
}
