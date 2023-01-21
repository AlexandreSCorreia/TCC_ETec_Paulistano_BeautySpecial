
using Android.App;
using Android.OS;
using App.Apresentacao;
using System.Threading;


namespace CamadaAcessoADados_DTO
{
    [Activity(Theme = "@style/SplashScreen.Theme", MainLauncher = true, NoHistory = true)]
    public class Apresentacao : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Thread.Sleep(4000);
            StartActivity(typeof(ActivityLogin));
        }
    }
}