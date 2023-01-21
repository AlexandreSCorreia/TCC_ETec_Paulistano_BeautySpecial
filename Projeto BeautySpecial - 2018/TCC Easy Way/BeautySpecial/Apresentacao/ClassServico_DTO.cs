using System;

namespace CamadaAcessoADados_DTO
{
    public class ClassServico_DTO
    {
        public int ID_Servico { get; set; }
        public String Nome_Serv { get; set; }
        public Decimal Preco_Serv { get; set; }
        public String Duracao_Serv { get; set; }
        public String Descricao_Serv { get; set; }



        public ClassServico_DTO() { }

        public ClassServico_DTO(string nome_serv, decimal preco_serv, String duracao_serv, string descricao_serv)
        {
            
            this.Nome_Serv = nome_serv;
            this.Preco_Serv = preco_serv;
            this.Duracao_Serv = duracao_serv;
            this.Descricao_Serv = descricao_serv;
        }

        public ClassServico_DTO(int id_servico,string nome_serv, decimal preco_serv, String duracao_serv, string descricao_serv)
        {
            this.ID_Servico = id_servico;
            this.Nome_Serv = nome_serv;
            this.Preco_Serv = preco_serv;
            this.Duracao_Serv = duracao_serv;
            this.Descricao_Serv = descricao_serv;
        }
    }


}


