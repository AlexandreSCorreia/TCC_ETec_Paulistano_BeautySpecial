using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
using Java.Interop;

namespace App.Apresentacao
{
    [Activity(Theme = "@style/CadCliente.Theme", Label = "ActivityCadCliente")]
    public class ActivityCadCliente : Activity
    {
        ClassCliente_BLL classCliente_BLL = new ClassCliente_BLL();
        //  Int32 ID_Cliente;
        // Int32 ID_Endereco;
        EditText txtboxNome;
        EditText txtboxRG;
        EditText txtboxCPF;
        EditText txtboxEmail;
        DatePicker txtboxDataNasc;
        EditText txtboxCEP;
        EditText txtboxEndereco;
        EditText txtboxNumero;
        EditText txtboxComplemento;
        EditText txtboxCidade;
        EditText txtboxBairro;
        String txtUF;
        String txtTipoTelefone;
        String RetornoCli;
        EditText txtboxDDD;
        EditText txtboxTelefone;
        Spinner SpnUF;
        ArrayAdapter adapterUF;
        ArrayList ListaUF;
        Spinner txtboxTipoTelefone;
        ArrayAdapter adapter;
        ArrayList TipoDeTelefone;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            AlertDialog.Builder alertDialogBuider = new AlertDialog.Builder(this);
            AlertDialog alerta = alertDialogBuider.Create();
            //cria a instância declarado no arquivo do cadastro de cliente
            txtboxNome = FindViewById<EditText>(Resource.Id.txtboxNome);
            txtboxRG = FindViewById<EditText>(Resource.Id.txtboxRG);
            txtboxCPF = FindViewById<EditText>(Resource.Id.txtboxCPF);
            txtboxEmail = FindViewById<EditText>(Resource.Id.txtboxEmail);
            txtboxDataNasc = FindViewById<DatePicker>(Resource.Id.datePicker1);
            txtboxCEP = FindViewById<EditText>(Resource.Id.txtboxCEP);
            txtboxEndereco = FindViewById<EditText>(Resource.Id.txtboxEnde);
            txtboxNumero = FindViewById<EditText>(Resource.Id.txtboxNumero);
            txtboxComplemento = FindViewById<EditText>(Resource.Id.txtboxCompl);
            txtboxCidade = FindViewById<EditText>(Resource.Id.txtboxCidade);
            txtboxBairro = FindViewById<EditText>(Resource.Id.txtboxBairro);
            txtboxDDD = FindViewById<EditText>(Resource.Id.txtboxDDD);
            txtboxTelefone = FindViewById<EditText>(Resource.Id.txtboxTelefone);
            // Create your application here
            SetContentView(Resource.Layout.CadCliente);
            Button btnCadastrar = FindViewById<Button>(Resource.Id.btnCadastrar);
            TextView lblRegist = FindViewById<TextView>(Resource.Id.lblRegist);
            TextView lblEscSenh = FindViewById<TextView>(Resource.Id.lblEscSenh);




            GetTipoTelefone();
            txtboxTipoTelefone = FindViewById<Spinner>(Resource.Id.spnTTele);
            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, TipoDeTelefone);
            txtboxTipoTelefone.Adapter = adapter;
            txtboxTipoTelefone.ItemSelected += Spinner_ItemSelected;



            GetUF();
            SpnUF = FindViewById<Spinner>(Resource.Id.spnUF);
            adapterUF = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, ListaUF);
            SpnUF.Adapter = adapterUF;
            SpnUF.ItemSelected += SpinnerUF_ItemSelected;


            //botão Incluir
            btnCadastrar.Click += delegate
            {
                if (!Validar())
                {
                    return;
                }
                AddCliente();
                try
                {
                    Int32 ID = Convert.ToInt32(RetornoCli);
                    AddTelefone();
                    //Definir o titulo, o icone, a menssagem e os botoes
                    alerta.SetTitle("Informação");
                    alerta.SetIcon(Android.Resource.Drawable.IcDialogInfo);
                    alerta.SetMessage("Cadastro realizado com sucesso!"  + RetornoCli);
                    alerta.SetButton("OK", (s, ev) =>
                    {
                        var Login = new Intent(this, typeof(ActivityLogin));
                        StartActivity(Login);
                        this.Dispose();
                    });
                    alerta.Show();

                }

                catch (Exception ex)
                {
                   
                    //Definir o titulo, o icone, a menssagem e os botoes
                    alerta.SetTitle("Atenção");
                    alerta.SetIcon(Android.Resource.Drawable.StatNotifyError);
                    alerta.SetMessage("Erro ao cadastrar.Detalhes:\n" + ex.Message);
                    alerta.SetButton("OK", (s, ev) =>
                    {

                    });

                    alerta.Show();
                    return;
                }
               

               

            };
        }



        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            txtTipoTelefone = string.Format(spinner.GetItemAtPosition(e.Position).ToString());

        }

        private void GetTipoTelefone()
        {
            TipoDeTelefone = new ArrayList();
            TipoDeTelefone.Add("--Selecione--");
            TipoDeTelefone.Add("Celular");
            TipoDeTelefone.Add("Residencial");
        }

        private void SpinnerUF_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            txtUF = string.Format(spinner.GetItemAtPosition(e.Position).ToString());

        }


        private void GetUF()
        {
            ListaUF = new ArrayList();
            ListaUF.Add("--Selecione--");
            ListaUF.Add("AC");
            ListaUF.Add("AL");
            ListaUF.Add("AM");
            ListaUF.Add("AP");
            ListaUF.Add("BA");
            ListaUF.Add("CE");
            ListaUF.Add("DF");
            ListaUF.Add("ES");
            ListaUF.Add("GO");
            ListaUF.Add("MA");
            ListaUF.Add("MG");
            ListaUF.Add("MS");
            ListaUF.Add("MT");
            ListaUF.Add("PA");
            ListaUF.Add("PB");
            ListaUF.Add("PE");
            ListaUF.Add("PI");
            ListaUF.Add("PR");
            ListaUF.Add("RJ");
            ListaUF.Add("RN");
            ListaUF.Add("RO");
            ListaUF.Add("RR");
            ListaUF.Add("RS");
            ListaUF.Add("SC");
            ListaUF.Add("SE");
            ListaUF.Add("SP");
            ListaUF.Add("TO");
        }

        private async void AddCliente()
        {
            EditText txtboxNome = FindViewById<EditText>(Resource.Id.txtboxNome);
            EditText txtboxRG = FindViewById<EditText>(Resource.Id.txtboxRG);
            EditText txtboxCPF = FindViewById<EditText>(Resource.Id.txtboxCPF);
            EditText txtboxEmail = FindViewById<EditText>(Resource.Id.txtboxEmail);
            DatePicker txtboxDataNasc = FindViewById<DatePicker>(Resource.Id.datePicker1);
            EditText txtboxCEP = FindViewById<EditText>(Resource.Id.txtboxCEP);
            EditText txtboxEndereco = FindViewById<EditText>(Resource.Id.txtboxEnde);
            EditText txtboxNumero = FindViewById<EditText>(Resource.Id.txtboxNumero);
            EditText txtboxComplemento = FindViewById<EditText>(Resource.Id.txtboxCompl);
            EditText txtboxCidade = FindViewById<EditText>(Resource.Id.txtboxCidade);
            EditText txtboxBairro = FindViewById<EditText>(Resource.Id.txtboxBairro);
       
           String Data = Convert.ToString(txtboxDataNasc.Year +"-" +txtboxDataNasc.Month +"-"+txtboxDataNasc.DayOfMonth);
            //passando valores para o construtor
            ClassCliente_DTO classCliente_DTO = new ClassCliente_DTO(
            txtboxCEP.Text.Trim(),txtboxEndereco.Text,Convert.ToInt32(txtboxNumero.Text.Trim()),txtboxComplemento.Text,txtboxBairro.Text,txtboxCidade.Text, txtUF,
            txtboxNome.Text,txtboxRG.Text.Trim(),txtboxCPF.Text.Trim(),txtboxEmail.Text,Convert.ToDateTime(Data));
            RetornoCli = await classCliente_BLL.InserirCliente(classCliente_DTO);
        }

        private async void AddTelefone()
        {
            ClassTelefone_BLL classTelefone_BLL = new ClassTelefone_BLL();
            Spinner txtTTele = FindViewById<Spinner>(Resource.Id.spnTTele);
            EditText txtDDD = FindViewById<EditText>(Resource.Id.txtboxDDD);
            EditText txtTelefone = FindViewById<EditText>(Resource.Id.txtboxTelefone);
            //passando valores para o construtor
            ClassTelefone_DTO classTelefone_DTO = new ClassTelefone_DTO();
            classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO();
            classTelefone_DTO.ID_Cliente_Tele =Convert.ToInt32(RetornoCli);
            classTelefone_DTO.DDD_Tele = Convert.ToInt32(txtDDD.Text);
            classTelefone_DTO.Telefone_Tele = txtTelefone.Text;
            if (txtTipoTelefone == "Residencial")
            {
                classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone = 1;
            }
            else
            {
                classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone = 2;
            }
            await classTelefone_BLL.InserirTelefone(classTelefone_DTO);

        }
        private async void Atualizar()
        {

            EditText txtboxNome = FindViewById<EditText>(Resource.Id.txtboxNome);
            EditText txtboxRG = FindViewById<EditText>(Resource.Id.txtboxRG);
            EditText txtboxCPF = FindViewById<EditText>(Resource.Id.txtboxCPF);
            EditText txtboxEmail = FindViewById<EditText>(Resource.Id.txtboxEmail);
            DatePicker txtboxDataNasc = FindViewById<DatePicker>(Resource.Id.datePicker1);
            EditText txtboxCEP = FindViewById<EditText>(Resource.Id.txtboxCEP);
            EditText txtboxEndereco = FindViewById<EditText>(Resource.Id.txtboxEnde);
            EditText txtboxNumero = FindViewById<EditText>(Resource.Id.txtboxNumero);
            EditText txtboxComplemento = FindViewById<EditText>(Resource.Id.txtboxCompl);
            EditText txtboxCidade = FindViewById<EditText>(Resource.Id.txtboxCidade);
            EditText txtboxBairro = FindViewById<EditText>(Resource.Id.txtboxBairro);
            //passando valores para o construtor
            ClassCliente_DTO classCliente_DTO = new ClassCliente_DTO(
                txtboxCEP.Text.Trim(),
                txtboxEndereco.Text,
                Convert.ToInt32(txtboxNumero.Text.Trim()),
                txtboxComplemento.Text,
                txtboxBairro.Text,
                txtboxCidade.Text,
                txtUF,
                txtboxNome.Text,
                txtboxRG.Text.Trim(),
                txtboxCPF.Text.Trim(),
                txtboxEmail.Text, Convert.ToDateTime(txtboxDataNasc));

            await classCliente_BLL.AtualizarCliente(classCliente_DTO);

        }

        public bool Validar()
        {
            AlertDialog.Builder alertDialogBuider = new AlertDialog.Builder(this);
            AlertDialog alerta = alertDialogBuider.Create();
            EditText txtboxNome = FindViewById<EditText>(Resource.Id.txtboxNome);
            EditText txtboxRG = FindViewById<EditText>(Resource.Id.txtboxRG);
            EditText txtboxCPF = FindViewById<EditText>(Resource.Id.txtboxCPF);
            EditText txtboxEmail = FindViewById<EditText>(Resource.Id.txtboxEmail);
            DatePicker txtboxDataNasc = FindViewById<DatePicker>(Resource.Id.datePicker1);
            EditText txtboxCEP = FindViewById<EditText>(Resource.Id.txtboxCEP);
            EditText txtboxEndereco = FindViewById<EditText>(Resource.Id.txtboxEnde);
            EditText txtboxNumero = FindViewById<EditText>(Resource.Id.txtboxNumero);
            EditText txtboxComplemento = FindViewById<EditText>(Resource.Id.txtboxCompl);
            EditText txtboxCidade = FindViewById<EditText>(Resource.Id.txtboxCidade);
            EditText txtboxBairro = FindViewById<EditText>(Resource.Id.txtboxBairro);
            /*  EditText txtboxTipoTelefone = FindViewById<EditText>(Resource.Id.txtboxNome);
              EditText txtboxDDD = FindViewById<EditText>(Resource.Id.txtboxRG);
              EditText txtboxTelefone = FindViewById<EditText>(Resource.Id.txtboxCPF);*/

            System.Text.StringBuilder msg = new System.Text.StringBuilder();
            bool valida = true;
            //UF
            if (txtUF.Equals(string.Empty) || txtUF.Equals("--Selecione--"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "UF não foi preenchido! \n" : "UF não foi preenchido!,  \n");
                valida = false;
            }

            //Bairro
            if (txtboxBairro.Text.Equals(String.Empty) || txtboxBairro.Text.Equals("Informe o seu bairro"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "Bairro não foi preenchido! \n" : "Bairro não foi preenchido!,  \n");
                valida = false;
            }
            //Cidade
            if (txtboxCidade.Text.Equals(String.Empty) || txtboxCidade.Text.Equals("Informe a sua cidade"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "Cidade não foi preenchida! \n" : "Cidade não foi preenchida!,  \n");
                valida = false;
            }
            //Número
            if (txtboxNumero.Text.Equals("Informe o número") || txtboxNumero.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "Número não foi preenchido! \n" : "Número não foi preenchido!,  \n");
                valida = false;
            }

            //Endereço
            if (txtboxEndereco.Text.Equals(String.Empty) || txtboxEndereco.Text.Equals("Informe o seu endereço"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "Endereço não foi preenchido! \n" : "Endereço não foi preenchido!,  \n");
                valida = false;

            }
            //CEP
            if (txtboxCEP.Text.Equals(String.Empty) || txtboxCEP.Text.Equals("Informe o seu CEP"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "CEP não foi preenchido! \n" : "CEP não foi preenchido!,  \n");
                valida = false;

            }
            //Email
            if (txtboxEmail.Text.Equals(String.Empty) || txtboxEmail.Text.Equals("Informe o seu e-mail"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "E-mail não foi preenchido! \n" : "E-mail não foi preenchido!,  \n");
                valida = false;

            }
           /* //Data de Nascimento
            if (txtboxDataNasc.Text.Equals(String.Empty) || txtboxDataNasc.Text.Equals("Informe a sua data de nascimento"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "Data de nascimento não foi preenchido! \n" : "Data de nascimento não foi preenchido!,  \n");
                valida = false;

            }*/
            //CPF
            if (txtboxCPF.Text.Equals(String.Empty) || txtboxCPF.Text.Equals("Informe o seu CPF"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "CPF não foi preenchido! \n" : "CPF não foi preenchido!,  \n");
                valida = false;

            }

            //RG
            if (txtboxRG.Text.Equals(String.Empty) || txtboxRG.Text.Equals("informe o seu RG"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "RG não foi preenchido! \n" : "RG não foi preenchido!,  \n");
                valida = false;

            }
            //Nome
            if (txtboxNome.Text.Equals(String.Empty) || txtboxNome.Text.Equals("Informe o seu nome"))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "Nome não foi preenchido! \n" : "Nome não foi preenchido!,  \n");
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