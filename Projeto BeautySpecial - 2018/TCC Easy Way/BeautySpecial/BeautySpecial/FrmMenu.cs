using Microsoft.Win32;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Ferramentas;
using CamadaLogicaDeNegocios_BLL;
using System.Data;
using System.Collections.Generic;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {

        // bool mover = false;
        //  Point posicao_Inicial;
        Permissao_BLL permissaousuarioBLL = new Permissao_BLL();
        DataTable tabela = new DataTable();
        public FrmMenu()
        {
            InitializeComponent();
            menuStripMenu.RenderMode = ToolStripRenderMode.Professional;
            menuStripMenu.Renderer = new ToolStripProfessionalRenderer(new CoresStrip());
        }
        private void btnMinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharMenu_Click(object sender, EventArgs e)
        {
            //Perguntar se ele quer realmente sair do sistema
            DialogResult Resultado = MessageBox.Show("Tem certeza que quer sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.No)
            {
                return;

            }
            Application.Exit();
            this.Dispose();
        }

        private void btnAgendMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmAgendamento>().Count() > 0)
            {
                MessageBox.Show("O agendamento já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmAgendamento frmAgendamento = new FrmAgendamento();
                //Abrindo form
                frmAgendamento.Show();
            }

        }

        private void btnContrCadasMenu_Click(object sender, EventArgs e)
        {
            //Instanciando o formulario
            FrmMenuContrCadastro MenuContrCadastro = new FrmMenuContrCadastro();

            if (Application.OpenForms.OfType<FrmMenuContrCadastro>().Count() > 0)
            {
                MessageBox.Show("O controle de cadastro já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Serviços
                tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.GrupoID, "FrmServicos");
                if (tabela.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(tabela.Rows[0][3]) == true)
                    {
                        MenuContrCadastro.btnServMenCadas.Enabled = false;
                        tabela.Dispose();
                    }
                }
                //Produto
                tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.GrupoID, "FrmProdutos");
                if (tabela.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(tabela.Rows[0][3]) == true)
                    {
                        MenuContrCadastro.btnProdMenCadas.Enabled = false;
                        tabela.Dispose();
                    }
                }
                //Cliente
                tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.GrupoID, "FrmCliente");
                if (tabela.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(tabela.Rows[0][3]) == true)
                    {
                        MenuContrCadastro.btnCliMenCadas.Enabled = false;
                        tabela.Dispose();
                    }
                }
                if (SessaoUsuario.Session.Instance.UsuGrupo != "Administrador")
                {
                    //Abrindo form

                    MenuContrCadastro.btnAcessMenCadas.Enabled = false;
                    MenuContrCadastro.btnAcessMenCadas.Enabled = false;
                    MenuContrCadastro.btnFuncMenCadas.Enabled = false;
                    MenuContrCadastro.Show();
                }
                MenuContrCadastro.Show();
            }
        }

        private void btnFinMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmFinancas>().Count() > 0)
            {
                MessageBox.Show("Finanças já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmFinancas frmFinancas = new FrmFinancas();
                //Abrindo form
                frmFinancas.Show();
            }
        }


        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            //Perguntar se ele quer realmente sair do sistema
            DialogResult Resultado = MessageBox.Show("Tem certeza que quer sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.No)
            {
                return;

            }
            Application.Exit();
            this.Dispose();
        }

        private void btnCaixaMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCaixa>().Count() > 0)
            {
                MessageBox.Show("O caixa já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmCaixa frmCaixa = new FrmCaixa();
                //Abrindo form
                frmCaixa.Show();
            }
        }

        private void btnComMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmControleComanda>().Count() > 0)
            {
                MessageBox.Show("A comanda já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmControleComanda controleComanda = new FrmControleComanda();
                //Abrindo form
                controleComanda.Show();
            }
        }

        private void toolStripMenuCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCliente>().Count() > 0)
            {
                MessageBox.Show("O controle de cliente já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmCliente frmCliente = new FrmCliente();
                //Abrindo form
                frmCliente.Show();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmFuncionario>().Count() > 0)
            {
                MessageBox.Show("O controle de funcionario já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmFuncionario frmFuncionario = new FrmFuncionario();
                //Abrindo form
                frmFuncionario.Show();
            }
        }

        private void toolStripMenuProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmProdutos>().Count() > 0)
            {
                MessageBox.Show("O controle de produtos já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmProdutos frmProdutos = new FrmProdutos();
                //Abrindo form
                frmProdutos.Show();
            }
        }

        private void toolStripMenuServico_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmServicos>().Count() > 0)
            {
                MessageBox.Show("O controle de serviços já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmServicos frmServicos = new FrmServicos();
                //Abrindo form
                frmServicos.Show();
            }
        }


        private void toolStripMenuTrocarUsuario_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            SessaoUsuario.Session.Instance.FuncID = 0;
            SessaoUsuario.Session.Instance.GrupoID = 0;
            SessaoUsuario.Session.Instance.NomeFunc = "";
            SessaoUsuario.Session.Instance.FuncCPF = "";
            SessaoUsuario.Session.Instance.FuncSenha = "";
            SessaoUsuario.Session.Instance.UsuGrupo = "";
            frmLogin.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void toolStripMenuAjuda_Click(object sender, EventArgs e)
        {

        }

        private void MoverForm_MouseDown(object sender, MouseEventArgs e)
        {
            /*mover = true;
            posicao_Inicial = new Point(e.X, e.Y);*/
        }

        private void MoverForm_MouseMove(object sender, MouseEventArgs e)
        {
            /*   if (mover)
               {
                   Point novo = PointToScreen(e.Location);
                   Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
               }*/
        }

        private void MoverForm_MouseUp(object sender, MouseEventArgs e)
        {
            /*
                 mover = false;*/

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Maximizar();
            //Finanças
            tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.GrupoID, "FrmFinancas");
            if (tabela.Rows.Count > 0)
            {
                if (Convert.ToBoolean(tabela.Rows[0][3]) == true)
                {
                    StripMenuFinancas.Visible = false;
                    btnFinMenu.Enabled = false;
                    tabela.Dispose();
                }
            }
            //Funcionario
            tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.GrupoID, "FrmFuncionario");
            if (tabela.Rows.Count > 0)
            {
                if (Convert.ToBoolean(tabela.Rows[0][3]) == true)
                {
                    StripMenuFunc.Visible = false;
                    tabela.Dispose();
                }
            }
            //Serviços
            tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.GrupoID, "FrmServicos");
            if (tabela.Rows.Count > 0)
            {
                if (Convert.ToBoolean(tabela.Rows[0][3]) == true)
                {
                    StripMenuServico.Visible = false;
                    tabela.Dispose();
                }
            }

            if (SessaoUsuario.Session.Instance.UsuGrupo != "Administrador")
            {
                StripAcessoUsu.Enabled = false;
                StripAcessoUsu.Visible = false;
            }
        }

        private void Maximizar()
        {
            Screen tela = Screen.FromPoint(this.Location);
            this.Size = tela.WorkingArea.Size;
            this.Location = Point.Empty;
        }


        class CoresStrip : ProfessionalColorTable
        {
           
           
            public override System.Drawing.Color MenuItemSelected
            {
                get
                {
                    return Color.DarkOrchid;
                }
            }
            /// <summary>
            /// MenuItemBorder
            /// </summary>
            public override System.Drawing.Color MenuItemBorder
            {
                get
                {
                    return Color.White;
                }
            }
            /// <summary>
            /// MenuItemPressedGradientBegin
            /// </summary>
            public override System.Drawing.Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }
            /// <summary>
            /// MenuItemPressedGradientMiddle
            /// </summary>
            public override System.Drawing.Color MenuItemPressedGradientMiddle
            {
                get
                {
                    return Color.NavajoWhite;
                }
            }
            /// <summary>
            /// MenuItemPressedGradientEnd
            /// </summary>
            public override System.Drawing.Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.DarkOrchid;
                }
            }
        


        }

        private void abrirAgendTlStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmAgendamento>().Count() > 0)
            {
                MessageBox.Show("O agendamento já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmAgendamento frmAgendamento = new FrmAgendamento();
                //Abrindo form
                frmAgendamento.Show();
            }
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCaixa>().Count() > 0)
            {
                MessageBox.Show("O caixa já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmCaixa frmCaixa = new FrmCaixa();
                //Abrindo form
                frmCaixa.Show();
            }
        }

        private void acessoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCaixa>().Count() > 0)
            {
                MessageBox.Show("Acesso de usuários já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmAcessoUsuario frmAcesso = new FrmAcessoUsuario();
                //Abrindo form
                frmAcesso.Show();
            }
        }

        private void abrirComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmControleComanda>().Count() > 0)
            {
                MessageBox.Show("A comanda já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmControleComanda frmControleComanda = new FrmControleComanda();
                //Abrindo form
                frmControleComanda.Show();
            }
        }

        private void abrirFinançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmFinancas>().Count() > 0)
            {
                MessageBox.Show("Finanças já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instanciando o formulario
                FrmFinancas frmFinancas = new FrmFinancas();
                //Abrindo form
                frmFinancas.Show();
            }
        }
    }
}
