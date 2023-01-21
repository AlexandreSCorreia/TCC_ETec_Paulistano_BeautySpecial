using Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenuContrCadastro : Form
    {
        bool mover = false;
        Point posicao_Inicial;

        public FrmMenuContrCadastro()
        {
            InitializeComponent();
        }

        private void btnMinimizarMenCadas_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnVoltarMenCadas_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnCliMenCadas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCliente>().Count() > 0)
            {
                MessageBox.Show("Cadastro de clientes já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                new FrmCliente().Show();
                this.Hide();
                this.Close();
                this.Dispose();
            }
        }

        private void btnFuncMenCadas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmFuncionario>().Count() > 0)
            {
                MessageBox.Show("Cadastro de funcionário já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                new FrmFuncionario().Show();
                this.Hide();
                this.Close();
                this.Dispose();
            }
        }

        private void btnFecharMenCadas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProdMenCadas_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmProdutos>().Count() > 0)
            {
                MessageBox.Show("Cadastro de produtos já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando form
                new FrmProdutos().Show();
                this.Hide();
                this.Close();
                this.Dispose();
            }
        }

        private void btnServMenCadas_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmServicos>().Count() > 0)
            {
                MessageBox.Show("Cadastro de serviços já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                new FrmServicos().Show();
                this.Hide();
                this.Close();
                this.Dispose();
            }
        }

        private void MoverForm_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_Inicial = new Point(e.X, e.Y);
        }

        private void MoverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
            }
        }

        private void MoverForm_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void btnFecharMenCadas_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAcessMenCadas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmAcessoUsuario>().Count() > 0)
            {
                MessageBox.Show("Cadastro de acesso já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                new FrmAcessoUsuario().Show();
                this.Hide();
                this.Close();
                this.Dispose(); ;
            }
        }
    }

 }
    

