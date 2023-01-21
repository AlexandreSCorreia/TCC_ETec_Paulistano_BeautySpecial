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
    [Activity(Label = "ActivityAutSenha")]
    public class ActivityAutSenha : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AuteEsqSenha);
            Button btnConcluir = FindViewById<Button>(Resource.Id.btnConcluir);

            btnConcluir.Click += delegate
            {


                var AutSenha = new Intent(this, typeof(ActivityEsqSenha));
                StartActivity(AutSenha);
            };
        }
    }
}