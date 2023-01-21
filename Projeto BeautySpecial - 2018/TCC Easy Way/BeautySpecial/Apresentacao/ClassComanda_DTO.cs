using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaAcessoADados_DTO
{
    public class ClassComanda_DTO
    {
        public int ID_Comanda { get; set; }
        public ClassCliente_DTO classCliente_DTO { get; set; }
        public ClassServico_DTO classServico_DTO { get; set; }
        public ClassProduto_DTO classProduto_DTO { get; set; }
        public ClassFuncionario_DTO classFuncionario_DTO { get; set; }
        public Decimal ValorTotal_Com { get; set; }
        public DateTime Data_Com { get; set; }
    }
}
