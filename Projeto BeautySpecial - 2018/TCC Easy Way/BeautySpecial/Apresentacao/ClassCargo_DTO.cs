using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaAcessoADados_DTO
{
    public class ClassCargo_DTO
    {
        //Declaração da variaveis e definindo a visibilidade
        public int ID_Cargo { get; set; }
        public String Funcao_Carg { get; set; }
        public Decimal Salario_Carg { get; set; }
        public  String  Horario_Entrada_Carg { get; set; }
        public String Horario_Saida_Carg { get; set; }

        //Construtor sem pedir parametros ao criar objeto
        public ClassCargo_DTO() { }
        //Construtor que pedi parametros ao ser criado o objeto
        public ClassCargo_DTO(string funcao_carg, decimal salario_carg, string horario_entrada_carg, string horario_saida_carg)
        {
            this.Funcao_Carg = funcao_carg;
            this.Salario_Carg = salario_carg;
            this.Horario_Entrada_Carg = horario_entrada_carg;
            this.Horario_Saida_Carg = horario_saida_carg;
        }
        //Construtor que pedi parametros ao ser criado o objeto
        public ClassCargo_DTO(int id_cargo,string funcao_carg, decimal salario_carg, string horario_entrada_carg, string horario_saida_carg)
        {
            this.ID_Cargo = id_cargo;
            this.Funcao_Carg = funcao_carg;
            this.Salario_Carg = salario_carg;
            this.Horario_Entrada_Carg = horario_entrada_carg;
            this.Horario_Saida_Carg = horario_saida_carg;
        }
    }
}
