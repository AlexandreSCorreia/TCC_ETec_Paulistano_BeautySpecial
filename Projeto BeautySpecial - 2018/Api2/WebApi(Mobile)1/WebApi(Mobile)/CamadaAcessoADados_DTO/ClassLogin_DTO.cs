using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CamadaAcessoADados_DTO
{
    public class ClassLogin_DTO
    {
        public int ID_Login { get; set; }
        public ClassCliente_DTO classCliente_DTO { get; set; }
        public String Senha_Log { get; set; }


        public ClassLogin_DTO() { }

        public ClassLogin_DTO(string email_clie, string senha_log)
        {
            this.classCliente_DTO = new ClassCliente_DTO();
            this.classCliente_DTO.Email_Clie = email_clie;
            this.Senha_Log = senha_log;

        }
    }
}