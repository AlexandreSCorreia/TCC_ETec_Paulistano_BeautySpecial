namespace Apresentacao
{
    partial class FrmNovaSenha
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
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtBoxRepNovSenha = new System.Windows.Forms.TextBox();
            this.txtBoxNovSenha = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnMostra2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharLog = new System.Windows.Forms.Button();
            this.btnMostra1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSenha.Location = new System.Drawing.Point(42, 230);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(194, 25);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Confirmar senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblUsuario.Location = new System.Drawing.Point(42, 146);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 25);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Senha";
            // 
            // txtBoxRepNovSenha
            // 
            this.txtBoxRepNovSenha.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRepNovSenha.ForeColor = System.Drawing.Color.Black;
            this.txtBoxRepNovSenha.Location = new System.Drawing.Point(39, 262);
            this.txtBoxRepNovSenha.MaxLength = 14;
            this.txtBoxRepNovSenha.Name = "txtBoxRepNovSenha";
            this.txtBoxRepNovSenha.Size = new System.Drawing.Size(363, 26);
            this.txtBoxRepNovSenha.TabIndex = 8;
            this.txtBoxRepNovSenha.UseSystemPasswordChar = true;
            this.txtBoxRepNovSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxRepNovSenha_KeyDown);
            // 
            // txtBoxNovSenha
            // 
            this.txtBoxNovSenha.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNovSenha.ForeColor = System.Drawing.Color.Black;
            this.txtBoxNovSenha.Location = new System.Drawing.Point(39, 178);
            this.txtBoxNovSenha.MaxLength = 14;
            this.txtBoxNovSenha.Name = "txtBoxNovSenha";
            this.txtBoxNovSenha.Size = new System.Drawing.Size(363, 26);
            this.txtBoxNovSenha.TabIndex = 6;
            this.txtBoxNovSenha.UseSystemPasswordChar = true;
            this.txtBoxNovSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxNovSenha_KeyDown);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(111, 312);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(225, 51);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Definir";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnMostra2
            // 
            this.btnMostra2.BackgroundImage = global::BeautySpecial.Properties.Resources.VizualizarSenhad;
            this.btnMostra2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostra2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostra2.Location = new System.Drawing.Point(408, 262);
            this.btnMostra2.Name = "btnMostra2";
            this.btnMostra2.Size = new System.Drawing.Size(39, 26);
            this.btnMostra2.TabIndex = 12;
            this.btnMostra2.UseVisualStyleBackColor = true;
            this.btnMostra2.Click += new System.EventHandler(this.btnMostra2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 73);
            this.label2.TabIndex = 14;
            this.label2.Text = "Definir Senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 60);
            this.label1.TabIndex = 15;
            this.label1.Text = "A senha deverá possuir no minimo 8 caracteres e no maximo 14 caracteres.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFecharLog
            // 
            this.btnFecharLog.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharLog.BackgroundImage = global::BeautySpecial.Properties.Resources.Fechar;
            this.btnFecharLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharLog.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharLog.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharLog.Location = new System.Drawing.Point(414, 12);
            this.btnFecharLog.Name = "btnFecharLog";
            this.btnFecharLog.Size = new System.Drawing.Size(33, 29);
            this.btnFecharLog.TabIndex = 16;
            this.btnFecharLog.UseVisualStyleBackColor = false;
            this.btnFecharLog.Click += new System.EventHandler(this.btnFecharLog_Click);
            // 
            // btnMostra1
            // 
            this.btnMostra1.BackgroundImage = global::BeautySpecial.Properties.Resources.VizualizarSenhad;
            this.btnMostra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostra1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostra1.Location = new System.Drawing.Point(408, 178);
            this.btnMostra1.Name = "btnMostra1";
            this.btnMostra1.Size = new System.Drawing.Size(39, 26);
            this.btnMostra1.TabIndex = 11;
            this.btnMostra1.UseVisualStyleBackColor = true;
            this.btnMostra1.Click += new System.EventHandler(this.btnMostra1_Click);
            // 
            // FrmNovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 375);
            this.Controls.Add(this.btnFecharLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostra2);
            this.Controls.Add(this.btnMostra1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtBoxRepNovSenha);
            this.Controls.Add(this.txtBoxNovSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNovaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNovaSenha";
            this.Load += new System.EventHandler(this.FrmNovaSenha_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNovaSenha_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtBoxRepNovSenha;
        private System.Windows.Forms.TextBox txtBoxNovSenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnMostra1;
        private System.Windows.Forms.Button btnMostra2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharLog;
    }
}