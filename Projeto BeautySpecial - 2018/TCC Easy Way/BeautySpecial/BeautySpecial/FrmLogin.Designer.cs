namespace Apresentacao
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mktxtBoxUsuario = new System.Windows.Forms.MaskedTextBox();
            this.PicBoxImgUsu = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFecharLog = new System.Windows.Forms.Button();
            this.btnMinimizarLog = new System.Windows.Forms.Button();
            this.lblEmpresaLog = new System.Windows.Forms.Label();
            this.picBoxMaq = new System.Windows.Forms.PictureBox();
            this.picBoxLogoLog = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxImgUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.mktxtBoxUsuario);
            this.groupBox2.Controls.Add(this.PicBoxImgUsu);
            this.groupBox2.Controls.Add(this.lblSenha);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Controls.Add(this.txtBoxSenha);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(554, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 567);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // mktxtBoxUsuario
            // 
            this.mktxtBoxUsuario.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktxtBoxUsuario.ForeColor = System.Drawing.Color.Black;
            this.mktxtBoxUsuario.Location = new System.Drawing.Point(79, 344);
            this.mktxtBoxUsuario.Mask = "000,000,000-00";
            this.mktxtBoxUsuario.Name = "mktxtBoxUsuario";
            this.mktxtBoxUsuario.Size = new System.Drawing.Size(385, 26);
            this.mktxtBoxUsuario.TabIndex = 1;
            this.mktxtBoxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mktxtBoxUsuario_KeyDown);
            // 
            // PicBoxImgUsu
            // 
            this.PicBoxImgUsu.Image = global::BeautySpecial.Properties.Resources.IconeLogin;
            this.PicBoxImgUsu.Location = new System.Drawing.Point(81, 37);
            this.PicBoxImgUsu.Name = "PicBoxImgUsu";
            this.PicBoxImgUsu.Size = new System.Drawing.Size(383, 249);
            this.PicBoxImgUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxImgUsu.TabIndex = 13;
            this.PicBoxImgUsu.TabStop = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSenha.Location = new System.Drawing.Point(74, 398);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(79, 25);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblUsuario.Location = new System.Drawing.Point(76, 312);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 25);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSenha.Location = new System.Drawing.Point(79, 436);
            this.txtBoxSenha.MaxLength = 14;
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(385, 26);
            this.txtBoxSenha.TabIndex = 2;
            this.txtBoxSenha.UseSystemPasswordChar = true;
            this.txtBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSenha_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogin.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(162, 483);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(-1, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1084, 67);
            this.label2.TabIndex = 24;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // btnFecharLog
            // 
            this.btnFecharLog.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharLog.BackgroundImage = global::BeautySpecial.Properties.Resources.Fechar;
            this.btnFecharLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharLog.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharLog.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharLog.Location = new System.Drawing.Point(1035, 9);
            this.btnFecharLog.Name = "btnFecharLog";
            this.btnFecharLog.Size = new System.Drawing.Size(33, 29);
            this.btnFecharLog.TabIndex = 2;
            this.btnFecharLog.UseVisualStyleBackColor = false;
            this.btnFecharLog.Click += new System.EventHandler(this.btnFecharLog_Click);
            // 
            // btnMinimizarLog
            // 
            this.btnMinimizarLog.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarLog.BackgroundImage = global::BeautySpecial.Properties.Resources.Minimizar;
            this.btnMinimizarLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizarLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarLog.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizarLog.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarLog.Location = new System.Drawing.Point(987, 9);
            this.btnMinimizarLog.Name = "btnMinimizarLog";
            this.btnMinimizarLog.Size = new System.Drawing.Size(33, 29);
            this.btnMinimizarLog.TabIndex = 1;
            this.btnMinimizarLog.UseVisualStyleBackColor = false;
            this.btnMinimizarLog.Click += new System.EventHandler(this.btnMinimizarLog_Click);
            // 
            // lblEmpresaLog
            // 
            this.lblEmpresaLog.AutoSize = true;
            this.lblEmpresaLog.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblEmpresaLog.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpresaLog.Location = new System.Drawing.Point(86, 19);
            this.lblEmpresaLog.Name = "lblEmpresaLog";
            this.lblEmpresaLog.Size = new System.Drawing.Size(204, 18);
            this.lblEmpresaLog.TabIndex = 32;
            this.lblEmpresaLog.Text = "Easy Way BeautySpecial";
            this.lblEmpresaLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.lblEmpresaLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.lblEmpresaLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // picBoxMaq
            // 
            this.picBoxMaq.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMaq.Image")));
            this.picBoxMaq.Location = new System.Drawing.Point(24, 86);
            this.picBoxMaq.Name = "picBoxMaq";
            this.picBoxMaq.Size = new System.Drawing.Size(524, 567);
            this.picBoxMaq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMaq.TabIndex = 0;
            this.picBoxMaq.TabStop = false;
            // 
            // picBoxLogoLog
            // 
            this.picBoxLogoLog.BackColor = System.Drawing.Color.DarkOrchid;
            this.picBoxLogoLog.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoLog.Image")));
            this.picBoxLogoLog.Location = new System.Drawing.Point(6, 7);
            this.picBoxLogoLog.Name = "picBoxLogoLog";
            this.picBoxLogoLog.Size = new System.Drawing.Size(74, 48);
            this.picBoxLogoLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoLog.TabIndex = 29;
            this.picBoxLogoLog.TabStop = false;
            this.picBoxLogoLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.picBoxLogoLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.picBoxLogoLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.lblEmpresaLog);
            this.Controls.Add(this.picBoxMaq);
            this.Controls.Add(this.btnFecharLog);
            this.Controls.Add(this.btnMinimizarLog);
            this.Controls.Add(this.picBoxLogoLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxImgUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PicBoxImgUsu;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxLogoLog;
        private System.Windows.Forms.Button btnFecharLog;
        private System.Windows.Forms.Button btnMinimizarLog;
        private System.Windows.Forms.PictureBox picBoxMaq;
        private System.Windows.Forms.Label lblEmpresaLog;
        private System.Windows.Forms.MaskedTextBox mktxtBoxUsuario;
    }
}