namespace Apresentacao
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersaoSplash = new System.Windows.Forms.Label();
            this.lblDireitosSplash = new System.Windows.Forms.Label();
            this.picBoxLogoEmpresaSplash = new System.Windows.Forms.PictureBox();
            this.picBoxLogoSplash = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarSplash = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoEmpresaSplash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Versão 1.1.1";
            // 
            // lblVersaoSplash
            // 
            this.lblVersaoSplash.AutoSize = true;
            this.lblVersaoSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblVersaoSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoSplash.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblVersaoSplash.Location = new System.Drawing.Point(693, 476);
            this.lblVersaoSplash.Name = "lblVersaoSplash";
            this.lblVersaoSplash.Size = new System.Drawing.Size(75, 15);
            this.lblVersaoSplash.TabIndex = 16;
            this.lblVersaoSplash.Text = "Versão 1.1.1";
            // 
            // lblDireitosSplash
            // 
            this.lblDireitosSplash.AutoSize = true;
            this.lblDireitosSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblDireitosSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireitosSplash.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDireitosSplash.Location = new System.Drawing.Point(159, 475);
            this.lblDireitosSplash.Name = "lblDireitosSplash";
            this.lblDireitosSplash.Size = new System.Drawing.Size(457, 16);
            this.lblDireitosSplash.TabIndex = 15;
            this.lblDireitosSplash.Text = "© 2018 Easy Way Development Technology. Todos os direitos reservados.";
            // 
            // picBoxLogoEmpresaSplash
            // 
            this.picBoxLogoEmpresaSplash.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoEmpresaSplash.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoEmpresaSplash.Image")));
            this.picBoxLogoEmpresaSplash.Location = new System.Drawing.Point(12, 430);
            this.picBoxLogoEmpresaSplash.Name = "picBoxLogoEmpresaSplash";
            this.picBoxLogoEmpresaSplash.Size = new System.Drawing.Size(91, 61);
            this.picBoxLogoEmpresaSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoEmpresaSplash.TabIndex = 14;
            this.picBoxLogoEmpresaSplash.TabStop = false;
            // 
            // picBoxLogoSplash
            // 
            this.picBoxLogoSplash.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoSplash.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoSplash.Image")));
            this.picBoxLogoSplash.Location = new System.Drawing.Point(251, 262);
            this.picBoxLogoSplash.Name = "picBoxLogoSplash";
            this.picBoxLogoSplash.Size = new System.Drawing.Size(242, 183);
            this.picBoxLogoSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoSplash.TabIndex = 13;
            this.picBoxLogoSplash.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarSplash
            // 
            this.progressBarSplash.Location = new System.Drawing.Point(162, 456);
            this.progressBarSplash.Name = "progressBarSplash";
            this.progressBarSplash.Size = new System.Drawing.Size(421, 10);
            this.progressBarSplash.TabIndex = 17;
            this.progressBarSplash.Visible = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.progressBarSplash);
            this.Controls.Add(this.lblVersaoSplash);
            this.Controls.Add(this.lblDireitosSplash);
            this.Controls.Add(this.picBoxLogoEmpresaSplash);
            this.Controls.Add(this.picBoxLogoSplash);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeautySpecial";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplashScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplashScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SplashScreen_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoEmpresaSplash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersaoSplash;
        private System.Windows.Forms.Label lblDireitosSplash;
        private System.Windows.Forms.PictureBox picBoxLogoEmpresaSplash;
        private System.Windows.Forms.PictureBox picBoxLogoSplash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarSplash;
    }
}

