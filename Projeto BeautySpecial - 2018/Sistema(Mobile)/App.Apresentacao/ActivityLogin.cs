using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Ferramentas;
using System;
using System.Data;
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;
using Android.Views;
using System.Collections.Generic;

namespace App.Apresentacao
{
    [Activity(Theme = "@style/Login.Theme", Label = "App.Apresentacao", Icon = "@drawable/icon", NoHistory = true)]
    public class ActivityLogin : Activity
    {
        ClassLogin_BLL Login_BLL = new ClassLogin_BLL();
        ClassLogin_DTO Login_DTO = new ClassLogin_DTO();
        AlertDialog.Builder alertDialogBuider;
        List<ClassLogin_DTO> colecaoLogin = new List<ClassLogin_DTO>();
        Button btnlogin;
        EditText txtboxEmail;
        EditText txtboxSenha;
        TextView lblRegist;
        TextView lblEscSenh;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Login);
            btnlogin = FindViewById<Button>(Resource.Id.btnlogin);
            txtboxEmail = FindViewById<EditText>(Resource.Id.txtboxEmail);
            txtboxSenha = FindViewById<EditText>(Resource.Id.txtboxSenha);
            lblRegist = FindViewById<TextView>(Resource.Id.lblRegist);
            lblEscSenh = FindViewById<TextView>(Resource.Id.lblEscSenh);
           

            btnlogin.Click += delegate
            {
                if (!Validar())
                {
                    return;
                };

                LogarSist();
            };

            lblRegist.Click += delegate 
            {
                var CadCliente = new Intent(this, typeof(ActivityCadCliente));
                StartActivity(CadCliente);
            };

            lblEscSenh.Click += delegate
            {
                var teste = new Intent(this, typeof(ActivityAutSenha));
                StartActivity(teste);
            };

        }

        public async void LogarSist()
        {
            txtboxEmail = FindViewById<EditText>(Resource.Id.txtboxEmail);
            txtboxSenha = FindViewById<EditText>(Resource.Id.txtboxSenha);
            AlertDialog.Builder alertDialogBuider = new AlertDialog.Builder(this);
            AlertDialog alerta = alertDialogBuider.Create();
            ClassLogin_DTO classLogin_DTO = new ClassLogin_DTO();
            var Menu = new Intent(this, typeof(ActivityMenu));

            try
            {
              
                colecaoLogin = await Login_BLL.LogarNoSistema(txtboxEmail.Text, txtboxSenha.Text);
                foreach (ClassLogin_DTO item in colecaoLogin)
                {
                    classLogin_DTO.classCliente_DTO = new ClassCliente_DTO();
                    classLogin_DTO.classCliente_DTO.ID_Cliente = item.classCliente_DTO.ID_Cliente;
                    classLogin_DTO.classCliente_DTO.Nome_Clie = item.classCliente_DTO.Nome_Clie;
                    classLogin_DTO.classCliente_DTO.Email_Clie = item.classCliente_DTO.Email_Clie;
                    classLogin_DTO.Senha_Log = item.Senha_Log;
                }
                if (txtboxEmail.Text == classLogin_DTO.classCliente_DTO.Email_Clie && txtboxSenha.Text == classLogin_DTO.Senha_Log )
                {
                    StartActivity(Menu);
                    /*DataTable Tabela =*/
                    SessaoUsuario.Session.Instance.ID_Clie = classLogin_DTO.classCliente_DTO.ID_Cliente;
                    SessaoUsuario.Session.Instance.Nome_Clie = classLogin_DTO.classCliente_DTO.Nome_Clie;
                    SessaoUsuario.Session.Instance.Email_Clie = classLogin_DTO.classCliente_DTO.Email_Clie;
                    SessaoUsuario.Session.Instance.Senha_Clie = classLogin_DTO.Senha_Log;
                    this.Dispose();
                }
                else
                {
                    txtboxSenha.Text = "";
                    Toast.MakeText(this, "Usuário e/ou senha invalidos!!", ToastLength.Short).Show();
                    return;
                }
            }
            catch (Exception)
            {
                //Definir o titulo, o icone, a menssagem e os botoes
                alerta.SetTitle("Atenção");
                alerta.SetIcon(Android.Resource.Drawable.StatNotifyError);
                alerta.SetMessage("Um erro ocoreu ao processar os dados \n Tente mais tarde");
                alerta.SetButton("OK", (s, ev) =>
                {

                });

                alerta.Show();
                return;
            }
        }


        public bool Validar()
        {
            alertDialogBuider = new AlertDialog.Builder(this);
            AlertDialog alerta = alertDialogBuider.Create();
            txtboxEmail = FindViewById<EditText>(Resource.Id.txtboxEmail);
            txtboxSenha = FindViewById<EditText>(Resource.Id.txtboxSenha);

            System.Text.StringBuilder msg = new System.Text.StringBuilder();
            bool valida = true;
          
            //Email
            if (txtboxEmail.Text.Equals(String.Empty) || txtboxEmail.Text.Equals("Exemple@exemple.com"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "E-mail não foi preenchido! \n" : "E-mail não foi preenchido!,  \n");
                valida = false;

            }
            //Email Invalido
            if (!txtboxEmail.Text.Contains("@") && !txtboxEmail.Text.Contains("."))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "E-mail invalido! \n" : "E-mail invalido!,  \n");
                valida = false;

            }

            //Senha
            if (txtboxSenha.Text.Equals(String.Empty) || txtboxSenha.Text.Equals("**********"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "Senha não foi preenchido! \n" : "Senha não foi preenchido!,  \n");
                valida = false;

            }
           
            if (!(valida))
            {
                //Definir o titulo, o icone, a menssagem e os botoes
                alerta.SetTitle("Atenção");
                alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);
                alerta.SetMessage("O(s) campo(s) são obrigatórios: \n" + msg.ToString());
                alerta.SetButton("OK", (s, ev) =>
                {

                });

                alerta.Show();

            }

            return valida;

        }

    }
}

