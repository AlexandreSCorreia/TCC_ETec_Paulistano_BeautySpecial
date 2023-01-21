using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using CamadaAcessoADados_DTO;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class SplashScreen : Form
    {
        bool mover = false;
        Point posicao_Inicial;

        public SplashScreen()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_Inicial = new Point(e.X, e.Y);
        }
        private void SplashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
            
        }
        private void SplashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
            }
        }

        private void AdicionarEventosControle(Control contenlor)
        {
            foreach (Control control in contenlor.Controls)
            {
                Type tipo = control.GetType();
                if (tipo != typeof(TextBox) && tipo != typeof(Button))
                {
                    control.MouseDown += SplashScreen_MouseDown;
                    control.MouseUp += SplashScreen_MouseUp;
                    control.MouseMove += SplashScreen_MouseMove;
                }
                if (control.Controls.Count != 0)
                {
                    //vai ver se há controles dentro de outros controles
                    AdicionarEventosControle(control);
                }
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            AdicionarEventosControle(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarSplash.Increment(1);
            if (progressBarSplash.Value >= 100)
            {
                timer1.Enabled = false;
                this.DialogResult = DialogResult.Yes;
                progressBarSplash.Visible = false;
                timer1.Enabled = false;
                this.Dispose();
            }
        }
    }
}

