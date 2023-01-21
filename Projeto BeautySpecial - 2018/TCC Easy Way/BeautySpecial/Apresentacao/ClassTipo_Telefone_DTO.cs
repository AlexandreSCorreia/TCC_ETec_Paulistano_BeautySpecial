using System;

namespace CamadaAcessoADados_DTO
{
    public class ClassTipo_Telefone_DTO
    {
        //Declarando atributios
        public int ID_Tipo_Telefone { get; set; }

        public String Descricao_TTele { get; set; }

        public ClassTipo_Telefone_DTO() { }
        public ClassTipo_Telefone_DTO(int id_tipo_telefone)
        {
            this.ID_Tipo_Telefone = id_tipo_telefone;
        }
        public ClassTipo_Telefone_DTO(int id_tipo_telefone, string descricao_ttele)
        {
            this.ID_Tipo_Telefone = id_tipo_telefone;
            this.Descricao_TTele = descricao_ttele;
        }

        public override string ToString()
        {
            return this.Descricao_TTele;
        }
    }
}
