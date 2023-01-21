using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaAcessoADados_DTO
{
    public class ClassTipoPagamento_DTO
    {
        //Declarando atributios
        public int ID_TipoPagamento { get; set; }

        public String Descricao_TP { get; set; }

        public ClassTipoPagamento_DTO() { }

        public ClassTipoPagamento_DTO(int id_tipoPagamento)
        {
            this.ID_TipoPagamento = id_tipoPagamento;
        }
        public ClassTipoPagamento_DTO(int id_tipoPagamento, string descricao_tp)
        {
            this.ID_TipoPagamento = id_tipoPagamento;
            this.Descricao_TP = descricao_tp;
        }

        public override string ToString()
        {
            return this.Descricao_TP;
        }
    }
}
