using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaAcessoADados_DTO;

namespace CamadaLogicaDeNegocios_BLL
{
    public interface IClassCliente_BLL
    {
        ClassClienteCollection_DTO ConsultaPorNome(string nome);
        string Inserir(ClassCliente_DTO classCliente_DTO);
        string Atualizar(ClassCliente_DTO classCliente_DTO);
        string Deletar(ClassCliente_DTO classcliente_dto);
    }
}
