using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaAcessoADados_DTO
{
    public class ClassLogin_DTO
    {
        public int ID_Login { get; set; }
        public ClassFuncionario_DTO classFuncionario_DTO { get; set; }
        public ClassCliente_DTO ClassCliente_DTO { get; set; }
        public String Senha_Log { get; set; }


        public ClassLogin_DTO()
        {
            this.ID_Login = 0;
            this.classFuncionario_DTO = new ClassFuncionario_DTO();
            this.classFuncionario_DTO.Email_Func = "";
            this.Senha_Log = "";
        }

        public ClassLogin_DTO(string email_func, string senha_log)
        {
            this.classFuncionario_DTO = new ClassFuncionario_DTO();
            this.classFuncionario_DTO.Email_Func = email_func;
            this.Senha_Log = senha_log;

        }
        public ClassLogin_DTO(Int32 id_funcionario, string senha_log)
        {
            this.classFuncionario_DTO = new ClassFuncionario_DTO();
            this.classFuncionario_DTO.ID_Funcionario = id_funcionario;
            this.Senha_Log = senha_log;

        }
    }
}
