using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CamadaAcessoADados_DTO
{
    public class ClassTelefone_DTO
    {
        //Declaração da variaveis e definindo a visibilidade
        public int ID_Telefone { get; set; }
        public int ID_Funcionario_Tele { get; set; }

        public int ID_Cliente_Tele { get; set; }
        public ClassTipo_Telefone_DTO classTipo_Telefone { get; set; }

        public Int32 DDD_Tele { get; set; }

        public String Telefone_Tele { get; set; }


        public ClassTelefone_DTO() { }

        public ClassTelefone_DTO(int id_cliente, int id_funcionario, int ddd_tele, string telefone_tele)
        {
            this.ID_Cliente_Tele = id_cliente;
            this.ID_Funcionario_Tele = id_funcionario;
            this.DDD_Tele = ddd_tele;
            this.Telefone_Tele = telefone_tele;

        }

        public ClassTelefone_DTO(int id_telefone, int ddd_tele, string telefone_tele)
        {
            this.ID_Telefone = id_telefone;
            this.DDD_Tele = ddd_tele;
            this.Telefone_Tele = telefone_tele;

        }
    }
}