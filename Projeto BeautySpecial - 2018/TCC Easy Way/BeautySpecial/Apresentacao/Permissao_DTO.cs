using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaAcessoADados_DTO
{
    public class Permissao_DTO
    {
        public int per_id { get; set; }
        public ClassGrupo_DTO ClassGrupo_DTO{ get; set; }
        public string per_nomeform { get; set; }
        public String per_Descricao { get; set; }
        public string per_bloquear { get; set; }
        public string per_inserir { get; set; }
        public string per_atualizar { get; set; }
        public string per_excluir { get; set; }
        public string per_consultar { get; set; }

    }
}
