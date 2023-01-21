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
    public class ClassTipo_Telefone_DTO
    {
        //Declarando atributios
        public int ID_Tipo_Telefone { get; set; }

        public String Descricao_TTele { get; set; }

        public ClassTipo_Telefone_DTO() { }
        public ClassTipo_Telefone_DTO(string descricao_ttele)
        {
            this.Descricao_TTele = descricao_ttele;
        }
        public ClassTipo_Telefone_DTO(int id_tipo_telefone, string descricao_ttele)
        {
            this.ID_Tipo_Telefone = id_tipo_telefone;
            this.Descricao_TTele = descricao_ttele;
        }
    }
}