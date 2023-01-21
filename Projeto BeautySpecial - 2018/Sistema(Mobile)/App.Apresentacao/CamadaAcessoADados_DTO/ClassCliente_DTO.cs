using System;


namespace CamadaAcessoADados_DTO
{
    public class ClassCliente_DTO
    {


        //Declaração da variaveis e definindo a visibilidade
        public Int32 ID_Cliente { get; set; }
        public ClassEndereco_DTO classEndereco_DTO { get; set; }
        public ClassTelefone_DTO classTelefone_DTO { get; set; }
        public String Nome_Clie { get; set; }
        public String RG_Clie { get; set; }
        public String CPF_Clie { get; set; }
        public DateTime DataNasc_Clie { get; set; }
        public DateTime Data_Cadastro_Clie { get; set; }
        public String Email_Clie { get; set; }


        //Construtor sem pedir parametros ao criar objeto
        public ClassCliente_DTO()
        {

        }
        //Construtor que obriga há passar parametros ao ser instanciado
        public ClassCliente_DTO(string cep_Ende, String endereco_Ende, int numero_Ende, String complemento_Ende, String bairro_Ende, String cidade_Ende, string uf_Ende, String nome_clie, string rg_clie, string cpf_clie, String email_clie, DateTime datanasc_clie)

        {
            //Endereço
            this.classEndereco_DTO = new ClassEndereco_DTO(cep_Ende, endereco_Ende, numero_Ende, complemento_Ende, bairro_Ende, cidade_Ende, uf_Ende);
            //Cliente
            this.Nome_Clie = nome_clie;
            this.RG_Clie = rg_clie;
            this.CPF_Clie = cpf_clie;
            this.Email_Clie = email_clie;
            this.DataNasc_Clie = datanasc_clie;
        }
        public ClassCliente_DTO(int id_endereco, string cep_Ende, String endereco_Ende, int numero_Ende, String complemento_Ende,
           String bairro_Ende, String cidade_Ende, string uf_Ende,
           int id_cliente, String nome_clie, string rg_clie, string cpf_clie, String email_clie, DateTime datanasc_clie)
        {
            //Endereço
            this.classEndereco_DTO = new ClassEndereco_DTO(id_endereco, cep_Ende, endereco_Ende, numero_Ende, complemento_Ende, bairro_Ende, cidade_Ende, uf_Ende);
            //Cliente
            this.ID_Cliente = id_cliente;
            this.Nome_Clie = nome_clie;
            this.RG_Clie = rg_clie;
            this.CPF_Clie = cpf_clie;
            this.Email_Clie = email_clie;
            this.DataNasc_Clie = datanasc_clie;
        }
    }
}


