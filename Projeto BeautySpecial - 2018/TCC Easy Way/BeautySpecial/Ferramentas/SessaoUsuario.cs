using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class SessaoUsuario
    {
        public sealed class Session
        {
            private static volatile Session instance;
            private static object sync = new object();

            private Session() { }

            public static Session Instance
            {

                get
                {
                    if (instance == null)
                    {

                        lock (sync)
                        {
                            if (instance == null)
                            {
                                instance = new Session();
                            }
                        }
                    }
                    return instance;

                }
            }


            ///<sumary>
            /// Propriedade para o ID, Nome e Grupo do usuario
            /// </sumary>

            public int FuncID { get; set; }
            public int GrupoID { get; set; }
            public String NomeFunc { get; set; }
            public String FuncCPF { get; set; }
            public String FuncSenha { get; set; }
            public String UsuGrupo { get; set; }
        }
    }
}
