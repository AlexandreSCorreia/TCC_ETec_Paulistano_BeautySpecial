using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CamadaAcessoADados_DTO
{
    public class ClassTelefone_DTO
    {
        //Declaração da variaveis e definindo a visibilidade
        public int ID_Telefone { get; set; }

        public int ID_Cliente_Tele { get; set; }

        public ClassTipo_Telefone_DTO classTipo_Telefone { get; set; }

        public Int32 DDD_Tele { get; set; }

        public String Telefone_Tele { get; set; }


        public ClassTelefone_DTO() { }

        public ClassTelefone_DTO(int ddd_tele, string telefone_tele, string descricao_ttele)
        {
            this.DDD_Tele = ddd_tele;
            this.Telefone_Tele = telefone_tele;
            this.classTipo_Telefone = new ClassTipo_Telefone_DTO(descricao_ttele);

        }

        public ClassTelefone_DTO(int id_telefone, int ddd_tele, string telefone_tele, int id_tipo_telefone, string descricao_ttele)
        {
            this.DDD_Tele = ddd_tele;
            this.Telefone_Tele = telefone_tele;
            this.classTipo_Telefone = new ClassTipo_Telefone_DTO(id_tipo_telefone, descricao_ttele);

        }
    }
}