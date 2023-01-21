using System;

namespace CamadaAcessoADados_DTO
{
    public class ClassFuncionario_DTO
    {
        //Declaração da variaveis e definindo a visibilidade
        public int ID_Funcionario { get; set; }
        public ClassTelefone_DTO classTelefone_DTO { get; set; }
        public ClassEndereco_DTO classEndereco_DTO { get; set; }
        public ClassCargo_DTO classCargo_DTO { get; set; }
        public String Nome_Func { get; set; }
        public String RG_Func { get; set; }
        public String CPF_Func { get; set; }
        public DateTime DataAdmissao_Func { get; set; }
        public DateTime DataNasc_Func { get; set; }
        public String Email_Func { get; set; }
        public ClassGrupo_DTO classGrupo_DTO { get; set; }


        //Construtor sem pedir parametros ao criar objeto
        public ClassFuncionario_DTO()
        {
            //Endereço
            this.classEndereco_DTO = new ClassEndereco_DTO(String.Empty, String.Empty, 0, String.Empty, String.Empty, String.Empty, String.Empty);
            //Funcionario
            this.Nome_Func = String.Empty;
            this.RG_Func = String.Empty;
            this.CPF_Func = String.Empty;
            this.Email_Func = String.Empty;
            this.DataAdmissao_Func = DateTime.Now.Date;
            this.DataNasc_Func = DateTime.Now.Date;
            //Cargo
            this.classCargo_DTO = new ClassCargo_DTO(String.Empty,Convert.ToDecimal("0,00"), "00:00", "00:00");
        }
        //Construtor que pedi parametros ao ser criado o objeto
        public ClassFuncionario_DTO(string cep_Ende, String endereco_Ende, int numero_Ende, String complemento_Ende, String bairro_Ende, String cidade_Ende, string uf_Ende,
           String nome_func, string rg_func, string cpf_func, String email_func, DateTime dataadmissao_func, DateTime datanasc_func, Int32 id_grupo_func,
           String funcao_carg, Decimal salario_carg, String horario_entrada_carg, String horario_saida_carg)
        {
            //Endereço
            this.classEndereco_DTO = new ClassEndereco_DTO(cep_Ende.Trim(), endereco_Ende, numero_Ende, complemento_Ende, bairro_Ende, cidade_Ende, uf_Ende);
            //Funcionario
            this.Nome_Func = nome_func;
            this.RG_Func = rg_func.Trim();
            this.CPF_Func = cpf_func.Trim();
            this.Email_Func = email_func;
            this.DataAdmissao_Func = dataadmissao_func;
            this.DataNasc_Func = datanasc_func;
            this.classGrupo_DTO = new ClassGrupo_DTO();
            this.classGrupo_DTO.ID_Grupo = id_grupo_func;
            //Cargo
            this.classCargo_DTO = new ClassCargo_DTO(funcao_carg, salario_carg, horario_entrada_carg.Trim(), horario_saida_carg.Trim());
        }

        public ClassFuncionario_DTO(int id_endereco, string cep_Ende, String endereco_Ende, int numero_Ende, String complemento_Ende, String bairro_Ende, String cidade_Ende, string uf_Ende,
            int id_funcionario, String nome_func, string rg_func, string cpf_func, String email_func, DateTime dataadmissao_func, DateTime datanasc_func, Int32 id_grupo_func,
            int id_cargo, String funcao_carg, Decimal salario_carg, String horario_entrada_carg, String horario_saida_carg)
        {
            //Endereço
            this.classEndereco_DTO = new ClassEndereco_DTO(id_endereco, cep_Ende.Trim(), endereco_Ende, numero_Ende, complemento_Ende, bairro_Ende, cidade_Ende, uf_Ende);
            //Funcionario
            this.ID_Funcionario = id_funcionario;
            this.Nome_Func = nome_func;
            this.RG_Func = rg_func.Trim();
            this.CPF_Func = cpf_func.Trim();
            this.Email_Func = email_func;
            this.DataAdmissao_Func = dataadmissao_func;
            this.DataNasc_Func = datanasc_func;
            this.classGrupo_DTO = new ClassGrupo_DTO();
            this.classGrupo_DTO.ID_Grupo = id_grupo_func;
            //Cargo
            this.classCargo_DTO = new ClassCargo_DTO(id_cargo, funcao_carg, salario_carg, horario_entrada_carg.Trim(), horario_saida_carg.Trim());
        }
    }
}
