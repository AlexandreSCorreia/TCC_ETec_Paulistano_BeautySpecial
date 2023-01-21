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

namespace App.Apresentacao
{
    [Activity(Theme = "@style/CadCliente.Theme", Label = "ActivityMenu")]
    public class ActivityMenu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Menu);
            Button btnAgendamento = FindViewById<Button>(Resource.Id.btnagendamento);

            btnAgendamento.Click += delegate 
            {
                var Agendamento = new Intent(this, typeof(ActivityAgendamento));
                StartActivity(Agendamento);


            };
        }
    }
}