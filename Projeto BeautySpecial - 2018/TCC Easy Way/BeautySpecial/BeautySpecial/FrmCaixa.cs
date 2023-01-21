using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//chamando pastas referenciadas
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;
using Ferramentas;

namespace Apresentacao
{
    public partial class FrmCaixa : Form
    {
        Double Valor1 = 0;
        Double Valor2 = 0;
        Double Resultado = 0;
        bool mover = false;
        Point posicao_Inicial;
        ClassCliente_BLL classCliente_BLL = new ClassCliente_BLL();
        //ClassServico_BLL classServico_BLL = new ClassServico_BLL();
        ClassComanda_BLL classComanda_BLL = new ClassComanda_BLL();
        ClassTipoPagamento_BLL classTipoPagamento_BLL = new ClassTipoPagamento_BLL();

        public FrmCaixa()
        {
            InitializeComponent();
        }

        private void btnFecharProd_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnMinimizarProd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            dateTimePickerCaix.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            cmbBoxOperCaix.Text= SessaoUsuario.Session.Instance.NomeFunc;
            CarregarCombos();
        }

        private void CarregarCombos()
        {
            //Cliente
            cmbBoxNomCliCaix.Items.Clear();
            cmbBoxNomCliCaix.Items.Add("--Selecione--");
            var classCliente_BLL = new ClassCliente_BLL();
            foreach (ClassCliente_DTO classCliente_DTO in classCliente_BLL.ConsultaPorNome(""))
            {
                cmbBoxNomCliCaix.Items.Add(classCliente_DTO);
            }
            cmbBoxNomCliCaix.Text = "--Selecione--";
            //Tipo de Pagamento
            cmbBoxTipPagCaix.Items.Clear();
            foreach (ClassTipoPagamento_DTO classTipoPagamento_DTO in classTipoPagamento_BLL.ConsultaTipoPagamento())
            {
                cmbBoxTipPagCaix.Items.Add(classTipoPagamento_DTO);
            }
            cmbBoxTipPagCaix.SelectedIndex = 0;

            cmbBoxComCaix.Items.Add("--Selecione--");
            cmbBoxComCaix.Text = "--Selecione--";
        }

        private void cmbBoxComCaix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxComCaix.SelectedItem != null)
            {
                if (cmbBoxComCaix.Text != "--Selecione--")
                {
                    txtBoxTotCaix.Text = ((ClassComanda_DTO)cmbBoxComCaix.SelectedItem).ValorTotal_Com.ToString();
                    Valor2 = Convert.ToDouble(txtBoxTotCaix.Text);
                }
            }
            if (txtBoxValorRecCaix.Text.Trim().Length >0)
            {
                Resultado = Valor1 - Valor2;
                txtBoxTrocCaix.Text = Resultado.ToString();

            }
        }

        public static void Moeda(ref TextBox textBox)
        {
            string numero = String.Empty;
            double valor = 0;
            try
            {
                numero = textBox.Text.Replace(",", "").Replace(".", "");
                if (numero.Equals(""))
                    numero = "";
                numero = numero.PadLeft(3, '0');
                if (numero.Length > 3 & numero.Substring(0, 1) == "0")
                    numero = numero.Substring(1, numero.Length - 1);
                valor = Convert.ToDouble(numero) / 100;
                textBox.Text = string.Format("{0:N}", valor);
                textBox.SelectionStart = textBox.Text.Length;
            }
            catch (Exception)
            {
            }

        }

        private void txtBoxTotCaix_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtBoxTotCaix);
        }

        private void txtBoxValorRecCaix_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtBoxValorRecCaix);
        }

        private void MoverForm_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_Inicial = new Point(e.X, e.Y);

        }
        private void MoverForm_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void MoverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
            }
        }

        private void txtBoxValorRecCaix_Leave(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(txtBoxValorRecCaix.Text);
            Resultado = Valor1 - Valor2;
            txtBoxTrocCaix.Text = Resultado.ToString();
        }

        private void btnCancelarCaix_Click(object sender, EventArgs e)
        {
            cmbBoxNomCliCaix.Text = "--Selecione--";
            cmbBoxComCaix.Text = "--Selecione--";
            cmbBoxTipPagCaix.Text = "--Selecione--";
            txtBoxValorRecCaix.Text = "0,00";
            txtBoxTotCaix.Text = "0,00";
            txtBoxTrocCaix.Text = "0,00";
        }

        private void cmbBoxNomCliCaix_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comanda
            if (cmbBoxNomCliCaix.Text.Trim().Length < 0 || cmbBoxNomCliCaix.Text != "--Selecione--")
            {
                cmbBoxComCaix.Items.Clear();
                cmbBoxComCaix.Items.Add("--Selecione--");
                foreach (ClassComanda_DTO classComanda_DTO in classComanda_BLL.ConsultaPorNome(((ClassCliente_DTO)cmbBoxNomCliCaix.SelectedItem).Nome_Clie))
                {
                    cmbBoxComCaix.Items.Add(classComanda_DTO);
                }
                cmbBoxComCaix.Text = "--Selecione--";
            }
        }
    }
}
