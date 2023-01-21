using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CamadaAcessoADados_DTO
{
    
        //quando estou dizendo que herda uma lista de clientes significa que essa classe 
        //esta se transformando em uma lista de clientes
        public class ClassClienteCollection_DTO : List<ClassCliente_DTO>
        {
        }
    
}