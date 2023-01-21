using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;

namespace Apresentacao
{
    public partial class ConsultarGruposUsuarios : Form
    {
        public ClassGrupo_DTO ClassGrupo_DTO = new ClassGrupo_DTO();
        bool mover = false;
        Point posicao_Inicial;
        public ConsultarGruposUsuarios()
        {
            InitializeComponent();
            DataGridConsGrup.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            ClassGrupo_BLL classGrupo_BLL = new ClassGrupo_BLL();
            DataGridConsGrup.DataSource = null;
            DataGridConsGrup.DataSource = classGrupo_BLL.ConsultaGrupo(txtBoxPesqConsGrup.Text);

            DataGridConsGrup.Update();
            DataGridConsGrup.Refresh();

        }

        private void DataGridConsUsu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClassGrupo_DTO = (DataGridConsGrup.SelectedRows[0].DataBoundItem as ClassGrupo_DTO);
            this.Close();
        }

        private void btnPesquisarConsGrup_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
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

        private void txtBoxPesqConsGrup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisarConsGrup_Click(sender,e);
            }
        }
    }
}
