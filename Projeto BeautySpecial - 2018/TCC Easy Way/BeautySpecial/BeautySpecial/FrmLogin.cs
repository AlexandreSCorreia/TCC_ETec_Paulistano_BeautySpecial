using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using Ferramentas;
using System.Windows.Forms;
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;

namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        bool mover = false;
        Point posicao_Inicial;
        ClassLogin_BLL Login_BLL = new ClassLogin_BLL();
        ClassLogin_DTO Login_DTO = new ClassLogin_DTO();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnMinimizarLog_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharLog_Click(object sender, EventArgs e)
        {
            //Perguntar se ele quer realmente sair do sistema
            DialogResult Resultado = MessageBox.Show("Tem certeza que quer sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.No)
            {
                return;

            }
            this.Close();

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Tabela = Login_BLL.LogarNoSistema(mktxtBoxUsuario.Text.Trim(), txtBoxSenha.Text);

            if (!Validar())
            {
                if (Tabela.Rows.Count == 1)
                {
                    FrmNovaSenha frmNovaSenha = new FrmNovaSenha(Convert.ToInt32(Tabela.Rows[0][2]));
                    DialogResult dialogResult = frmNovaSenha.ShowDialog();
                    Tabela.Dispose();
                    if (dialogResult == DialogResult.Yes)
                    {
                        txtBoxSenha.Text = "";
                    }
                    frmNovaSenha.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha invalidos!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                return;
            }


            try
            {
                if (mktxtBoxUsuario.Text.Trim().Length == 0 || txtBoxSenha.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Os campos (Usuário e Senha) são de preenchimento obrigátorio! \n\n"
                    + "Preencha os dados e click novamente em entrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mktxtBoxUsuario.Focus();
                    return;
                }
                DataTable TabelaDentroTry = Login_BLL.LogarNoSistema(mktxtBoxUsuario.Text.Trim(), txtBoxSenha.Text);

                if (TabelaDentroTry.Rows.Count == 1)
                {
                    SessaoUsuario.Session.Instance.FuncID = Convert.ToInt32(TabelaDentroTry.Rows[0][2].ToString());
                    SessaoUsuario.Session.Instance.GrupoID = Convert.ToInt32(TabelaDentroTry.Rows[0][5].ToString());
                    SessaoUsuario.Session.Instance.NomeFunc = TabelaDentroTry.Rows[0][3].ToString();
                    SessaoUsuario.Session.Instance.FuncCPF = TabelaDentroTry.Rows[0][4].ToString();
                    SessaoUsuario.Session.Instance.FuncSenha = TabelaDentroTry.Rows[0][1].ToString();
                    SessaoUsuario.Session.Instance.UsuGrupo = TabelaDentroTry.Rows[0][6].ToString();
                    this.Hide();
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.ShowDialog();
                    TabelaDentroTry.Dispose();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha invalidos!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Um erro ocoreu ao processar os dados \n Tente mais tarde" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public bool Validar()
        {
            bool valida = true;

            if (txtBoxSenha.Text == "BeUtySpV111")
            {
                valida = false;
               
            }
            if (txtBoxSenha.Text == "Spe203cialBea")
            {
                valida = false;
                
            }
            if (txtBoxSenha.Text == "2B85eau111Sp")
            {
                valida = false;
              
            }
            if (txtBoxSenha.Text == "Specc88753Dalg")
            {
                valida = false;
            }
            if (txtBoxSenha.Text == "sp8897Autyz7T")
            {
                valida = false;
            }
            if (txtBoxSenha.Text == "Sis7Rt2kjmmk")
            {
                valida = false;
            }
            return valida;
        }





        private void MoverForm_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
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
      
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //Perguntar se ele quer realmente sair do sistema
                DialogResult Resultado = MessageBox.Show("Tem certeza que quer sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Resultado == DialogResult.No)
                {
                    return;

                }
                this.Close();
            }

        }

        private void mktxtBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (mktxtBoxUsuario.Text.Trim().Replace(".", "").Replace("-", "").Length > 0 && txtBoxSenha.Text.Trim().Length > 0)
                {
                    btnLogin_Click(sender, e);

                }
                else
                {
                    txtBoxSenha.Focus();
                }
            }
        }

        private void txtBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (mktxtBoxUsuario.Text.Trim().Replace(".", "").Replace("-", "").Length > 0 && txtBoxSenha.Text.Trim().Length > 0)
                {
                    btnLogin_Click(sender, e);

                }
                else if (mktxtBoxUsuario.Text.Trim().Replace(".", "").Replace("-", "").Length < 0)
                {
                    mktxtBoxUsuario.Focus();
                }
                else
                {
                    txtBoxSenha.Focus();

                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
          
        }
    }
}
