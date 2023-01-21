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
using Ferramentas;

namespace App.Apresentacao
{
    [Activity(Label = "ActivityAgendamento")]
    public class ActivityAgendamento : Activity
    {
        Int32 ID_Cliente = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Agendamento);
            EditText txtboxCliente = FindViewById<EditText>(Resource.Id.txtboxCliente);
            ID_Cliente = SessaoUsuario.Session.Instance.ID_Clie;
            txtboxCliente.Text = SessaoUsuario.Session.Instance.Nome_Clie;
            txtboxCliente.Enabled = false;
        }
    }
}