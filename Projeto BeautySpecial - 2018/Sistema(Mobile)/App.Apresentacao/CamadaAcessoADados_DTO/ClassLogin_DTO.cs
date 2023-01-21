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
        public ClassCliente_DTO classCliente_DTO { get; set; }
        public String Senha_Log { get; set; }


        public ClassLogin_DTO()
        {
            this.ID_Login = 0;
            this.classCliente_DTO= new ClassCliente_DTO();
            this.classCliente_DTO.Email_Clie = "";
            this.Senha_Log = "";
        }

        public ClassLogin_DTO(string email_clie, string senha_log)
        {
            this.classCliente_DTO = new ClassCliente_DTO();
            this.classCliente_DTO.Email_Clie = email_clie;
            this.Senha_Log = senha_log;

        }
        public ClassLogin_DTO(Int32 id_cliente, string senha_log)
        {
            this.classCliente_DTO = new ClassCliente_DTO();
            this.classCliente_DTO.ID_Cliente = id_cliente;
            this.Senha_Log = senha_log;

        }
    }
}
