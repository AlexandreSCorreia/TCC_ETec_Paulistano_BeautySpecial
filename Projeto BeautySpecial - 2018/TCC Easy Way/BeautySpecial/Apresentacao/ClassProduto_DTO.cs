using System;

namespace CamadaAcessoADados_DTO
{
    public class ClassProduto_DTO
    {
        public int ID_Produto { get; set; }
        public ClassServico_DTO classServico_DTO { get; set; }
        public String Nome_Prod { get; set; }
        public String Marca_Prod { get; set; }
        public string Descricao_Prod { get; set; }
        public Decimal Preco_Prod { get; set; }
        public int Quantidade_Prod { get; set; }




        public ClassProduto_DTO() { }

        public ClassProduto_DTO(string nome_prod, string marca_prod, string descricao_prod, decimal preco_prod, int quantidade_prod)
        {
            this.Nome_Prod = nome_prod;
            this.Marca_Prod = marca_prod;
            this.Descricao_Prod = descricao_prod;
            this.Preco_Prod = preco_prod;
            this.Quantidade_Prod = quantidade_prod;
        }

        public ClassProduto_DTO(int id_produto, string nome_prod, string marca_prod, string descricao_prod, decimal preco_prod,int quantidade_prod )
        {
            this.ID_Produto = id_produto;
            this.Nome_Prod = nome_prod;
            this.Marca_Prod = marca_prod;
            this.Descricao_Prod = descricao_prod;
            this.Preco_Prod = preco_prod;
            this.Quantidade_Prod = quantidade_prod;
        }
    }
}
