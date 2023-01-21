using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CamadaAcessoADados_DTO
{
    public class ClassAgendamento_DTO
    {

        public int ID_Agendamento { get; set; }
        public ClassCliente_DTO classCliente_DTO { get; set; }
        public ClassServico_DTO classServico_DTO { get; set; }
        public ClassFuncionario_DTO classFuncionario_DTO { get; set; }
        public DateTime Data_Agend { get; set; }
        public ClassHoraSalao classHoraSalao { get; set; }
        public String Observacao_Agend { get; set; }

        public ClassAgendamento_DTO() { }


        public ClassAgendamento_DTO(int id_cliente_agend, int id_servico_agend, int id_funcionario_agend, string duracao, DateTime data_agend, Int32 id_hora_agend, string observacao_agend)
        {

            this.classCliente_DTO = new ClassCliente_DTO();
            this.classCliente_DTO.ID_Cliente = id_cliente_agend;

            this.classServico_DTO = new ClassServico_DTO();
            this.classServico_DTO.ID_Servico = id_servico_agend;
            this.classServico_DTO.Duracao_Serv = duracao;

            this.classFuncionario_DTO = new ClassFuncionario_DTO();
            this.classFuncionario_DTO.ID_Funcionario = id_funcionario_agend;

            this.classHoraSalao = new ClassHoraSalao();
            this.classHoraSalao.ID_HoraSalao = id_hora_agend;
            this.Data_Agend = data_agend;
            this.Observacao_Agend = observacao_agend;
        }
    }
}