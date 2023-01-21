using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CamadaAcessoADados_DTO
{
    public class ClassEndereco_DTO
    {
            //Declaração da variaveis e definindo a visibilidade
            public Int32 ID_Endereco { get; set; }
            public String CEP_Ende { get; set; }
            public String Endereco_Ende { get; set; }
            public int Numero_Ende { get; set; }
            public String Complemento_Ende { get; set; }
            public String Bairro_Ende { get; set; }
            public String Cidade_Ende { get; set; }
            public string UF_Ende { get; set; }


            //Construtor que obriga há passar parametros ao ser instanciado
            public ClassEndereco_DTO() { }
            //Construtor que obriga há passar parametros ao ser instanciado
            public ClassEndereco_DTO(string cep_ende, String endereco_ende, int numero_ende, String complemento_ende,
                String bairro_ende, String cidade_ende, string uf_end)
            {
                this.CEP_Ende = cep_ende;
                this.Endereco_Ende = endereco_ende;
                this.Numero_Ende = numero_ende;
                this.Complemento_Ende = complemento_ende;
                this.Bairro_Ende = bairro_ende;
                this.Cidade_Ende = cidade_ende;
                this.UF_Ende = uf_end;
            }
            //Construtor que obriga há passar parametros ao ser instanciado
            public ClassEndereco_DTO(int id_endereco, string cep_ende, String endereco_ende, int numero_ende, String complemento_ende,
               String bairro_ende, String cidade_ende, string uf_end)
            {
                this.ID_Endereco = id_endereco;
                this.CEP_Ende = cep_ende;
                this.Endereco_Ende = endereco_ende;
                this.Numero_Ende = numero_ende;
                this.Complemento_Ende = complemento_ende;
                this.Bairro_Ende = bairro_ende;
                this.Cidade_Ende = cidade_ende;
                this.UF_Ende = uf_end;
            }


    }
    
}