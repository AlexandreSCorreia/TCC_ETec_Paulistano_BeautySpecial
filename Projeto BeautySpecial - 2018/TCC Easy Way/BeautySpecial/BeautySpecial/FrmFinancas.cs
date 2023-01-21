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
    public partial class FrmFinancas : Form
    {
        bool mover = false;
        Point posicao_Inicial;

        public FrmFinancas()
        {
            InitializeComponent();
        }

        private void btnMinimizarFin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label23_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_Inicial = new Point(e.X, e.Y);
        }

        private void label23_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
            }
        }

        private void label23_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
    }
}
