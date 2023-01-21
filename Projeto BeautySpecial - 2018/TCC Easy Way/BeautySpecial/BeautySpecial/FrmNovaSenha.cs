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
    public partial class FrmNovaSenha : Form
    {
        ClassLogin_BLL classLogin_BLL = new ClassLogin_BLL();
        String IDLog;
        bool mover = false;
        Point posicao_Inicial;
        Int32 IDF;
        public FrmNovaSenha(Int32 ID)
        {
            IDF = ID;
            InitializeComponent();
        }

        private void FrmNovaSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnMostra1_Click(object sender, EventArgs e)
        {
            if (txtBoxNovSenha.UseSystemPasswordChar == false)
            {
                txtBoxNovSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxNovSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnMostra2_Click(object sender, EventArgs e)
        {
            if (txtBoxRepNovSenha.UseSystemPasswordChar == false)
            {
                txtBoxRepNovSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxRepNovSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                if (txtBoxNovSenha.Text.Trim().Length<=0 || txtBoxRepNovSenha.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Todos os campos são obrigatorios para registrar a nova senha.","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                if (txtBoxNovSenha.Text.Trim() != txtBoxRepNovSenha.Text.Trim())
                {
                    MessageBox.Show("Senha e confirmar senha devem ser iguais!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            if (txtBoxNovSenha.Text.Trim().Length <= 7 || txtBoxRepNovSenha.Text.Trim().Length <= 7)
            {
                MessageBox.Show("A senha deverá possuir no minimo 8 caracteres e no maximo 14 caracteres.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

             DataTable Tabela = new DataTable();
            
             Tabela = classLogin_BLL.BuscarFuncionarioLog(IDF);
            if (Tabela.Rows.Count > 0)
            {
                ClassLogin_DTO classLogin_DTO = new ClassLogin_DTO();
                classLogin_DTO.classFuncionario_DTO.ID_Funcionario = Convert.ToInt32(IDF);
                classLogin_DTO.Senha_Log = txtBoxRepNovSenha.Text;
                IDLog = classLogin_BLL.AtualizarLogin(classLogin_DTO);
                Tabela.Dispose();
                this.DialogResult = DialogResult.Yes;
                this.Close();
                this.Dispose();
            }
            try
            {
                Int32 ID = Convert.ToInt32(IDLog);
                MessageBox.Show("Senha alterada com sucesso. Lembre-se que sua nova senha deverá ser usada para logar no sistema.","Alteração de senha",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a senha ! \n\n Detalhes: "+ ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

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

        private void btnFecharLog_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
            this.Dispose();
        }

        private void FrmNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirmar_Click(sender,e);
            }
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

        private void txtBoxNovSenha_KeyDown(object sender, KeyEventArgs e)
        {
            FrmNovaSenha_KeyDown(sender,e);
        }

        private void txtBoxRepNovSenha_KeyDown(object sender, KeyEventArgs e)
        {
            FrmNovaSenha_KeyDown(sender, e);
        }
    }
}
