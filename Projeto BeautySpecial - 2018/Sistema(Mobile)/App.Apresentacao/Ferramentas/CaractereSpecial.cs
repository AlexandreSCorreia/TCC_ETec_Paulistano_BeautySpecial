using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class CaractereSpecial
    {
        public static string VerificarCaractere(string texto)
        {
            texto = texto.ToLower();
            if (texto.Contains("--") || texto.Contains(";") || texto.Contains("'") || texto.Contains("from")
                || texto.Contains("group by") || texto.Contains("having") || texto.Contains("xp_")
                || texto.Contains("drop") || texto.Contains("delete") || texto.Contains("kill"))
            {
                return "Erro";
            }

            return "OK";
        }
    }
}
