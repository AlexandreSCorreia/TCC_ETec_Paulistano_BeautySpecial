namespace Apresentacao
{
    partial class FrmCadServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadServicos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCadServ = new System.Windows.Forms.Button();
            this.btnSalvarServ = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMsgPrecoServ = new System.Windows.Forms.Label();
            this.lblMsgDuracaoServ = new System.Windows.Forms.Label();
            this.lblMsgNomeServ = new System.Windows.Forms.Label();
            this.mkdTxtBoxDuracServ = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxDescServ = new System.Windows.Forms.TextBox();
            this.lblDescServ = new System.Windows.Forms.Label();
            this.lblMarcServ = new System.Windows.Forms.Label();
            this.txtBoxPrecServ = new System.Windows.Forms.TextBox();
            this.lblPrecServ = new System.Windows.Forms.Label();
            this.txtBoxNomeServ = new System.Windows.Forms.TextBox();
            this.lblNomeServ = new System.Windows.Forms.Label();
            this.lblMsgServicos = new System.Windows.Forms.Label();
            this.lblEmpresaServ = new System.Windows.Forms.Label();
            this.btnFecharServ = new System.Windows.Forms.Button();
            this.btnMinimizarServ = new System.Windows.Forms.Button();
            this.picBoxLogoServ = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoServ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnCancelarCadServ);
            this.groupBox1.Controls.Add(this.btnSalvarServ);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 487);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelarCadServ
            // 
            this.btnCancelarCadServ.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelarCadServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadServ.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadServ.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCadServ.Location = new System.Drawing.Point(935, 429);
            this.btnCancelarCadServ.Name = "btnCancelarCadServ";
            this.btnCancelarCadServ.Size = new System.Drawing.Size(108, 37);
            this.btnCancelarCadServ.TabIndex = 13;
            this.btnCancelarCadServ.Text = "Cancelar";
            this.btnCancelarCadServ.UseVisualStyleBackColor = false;
            this.btnCancelarCadServ.Click += new System.EventHandler(this.btnCancelarCadServ_Click);
            // 
            // btnSalvarServ
            // 
            this.btnSalvarServ.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarServ.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarServ.ForeColor = System.Drawing.Color.White;
            this.btnSalvarServ.Location = new System.Drawing.Point(812, 429);
            this.btnSalvarServ.Name = "btnSalvarServ";
            this.btnSalvarServ.Size = new System.Drawing.Size(108, 37);
            this.btnSalvarServ.TabIndex = 8;
            this.btnSalvarServ.Text = "Salvar";
            this.btnSalvarServ.UseVisualStyleBackColor = false;
            this.btnSalvarServ.Click += new System.EventHandler(this.btnSalvarServ_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 387);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Serviço";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMsgPrecoServ);
            this.groupBox2.Controls.Add(this.lblMsgDuracaoServ);
            this.groupBox2.Controls.Add(this.lblMsgNomeServ);
            this.groupBox2.Controls.Add(this.mkdTxtBoxDuracServ);
            this.groupBox2.Controls.Add(this.txtBoxDescServ);
            this.groupBox2.Controls.Add(this.lblDescServ);
            this.groupBox2.Controls.Add(this.lblMarcServ);
            this.groupBox2.Controls.Add(this.txtBoxPrecServ);
            this.groupBox2.Controls.Add(this.lblPrecServ);
            this.groupBox2.Controls.Add(this.txtBoxNomeServ);
            this.groupBox2.Controls.Add(this.lblNomeServ);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 339);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // lblMsgPrecoServ
            // 
            this.lblMsgPrecoServ.AutoSize = true;
            this.lblMsgPrecoServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgPrecoServ.ForeColor = System.Drawing.Color.Black;
            this.lblMsgPrecoServ.Location = new System.Drawing.Point(131, 130);
            this.lblMsgPrecoServ.Name = "lblMsgPrecoServ";
            this.lblMsgPrecoServ.Size = new System.Drawing.Size(16, 18);
            this.lblMsgPrecoServ.TabIndex = 42;
            this.lblMsgPrecoServ.Text = "*";
            // 
            // lblMsgDuracaoServ
            // 
            this.lblMsgDuracaoServ.AutoSize = true;
            this.lblMsgDuracaoServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgDuracaoServ.ForeColor = System.Drawing.Color.Black;
            this.lblMsgDuracaoServ.Location = new System.Drawing.Point(133, 79);
            this.lblMsgDuracaoServ.Name = "lblMsgDuracaoServ";
            this.lblMsgDuracaoServ.Size = new System.Drawing.Size(16, 18);
            this.lblMsgDuracaoServ.TabIndex = 41;
            this.lblMsgDuracaoServ.Text = "*";
            // 
            // lblMsgNomeServ
            // 
            this.lblMsgNomeServ.AutoSize = true;
            this.lblMsgNomeServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgNomeServ.ForeColor = System.Drawing.Color.Black;
            this.lblMsgNomeServ.Location = new System.Drawing.Point(131, 31);
            this.lblMsgNomeServ.Name = "lblMsgNomeServ";
            this.lblMsgNomeServ.Size = new System.Drawing.Size(16, 18);
            this.lblMsgNomeServ.TabIndex = 40;
            this.lblMsgNomeServ.Text = "*";
            // 
            // mkdTxtBoxDuracServ
            // 
            this.mkdTxtBoxDuracServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdTxtBoxDuracServ.Location = new System.Drawing.Point(155, 72);
            this.mkdTxtBoxDuracServ.Mask = "00:00";
            this.mkdTxtBoxDuracServ.Name = "mkdTxtBoxDuracServ";
            this.mkdTxtBoxDuracServ.PromptChar = ' ';
            this.mkdTxtBoxDuracServ.Size = new System.Drawing.Size(107, 26);
            this.mkdTxtBoxDuracServ.TabIndex = 2;
            this.mkdTxtBoxDuracServ.ValidatingType = typeof(System.DateTime);
            this.mkdTxtBoxDuracServ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkdTxtBoxDuracServ_MaskInputRejected);
            // 
            // txtBoxDescServ
            // 
            this.txtBoxDescServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescServ.Location = new System.Drawing.Point(155, 175);
            this.txtBoxDescServ.Multiline = true;
            this.txtBoxDescServ.Name = "txtBoxDescServ";
            this.txtBoxDescServ.Size = new System.Drawing.Size(390, 145);
            this.txtBoxDescServ.TabIndex = 4;
            // 
            // lblDescServ
            // 
            this.lblDescServ.AutoSize = true;
            this.lblDescServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescServ.Location = new System.Drawing.Point(55, 179);
            this.lblDescServ.Name = "lblDescServ";
            this.lblDescServ.Size = new System.Drawing.Size(77, 18);
            this.lblDescServ.TabIndex = 38;
            this.lblDescServ.Text = "Descrição";
            // 
            // lblMarcServ
            // 
            this.lblMarcServ.AutoSize = true;
            this.lblMarcServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcServ.Location = new System.Drawing.Point(65, 76);
            this.lblMarcServ.Name = "lblMarcServ";
            this.lblMarcServ.Size = new System.Drawing.Size(67, 18);
            this.lblMarcServ.TabIndex = 36;
            this.lblMarcServ.Text = "Duração";
            // 
            // txtBoxPrecServ
            // 
            this.txtBoxPrecServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrecServ.Location = new System.Drawing.Point(155, 119);
            this.txtBoxPrecServ.Name = "txtBoxPrecServ";
            this.txtBoxPrecServ.Size = new System.Drawing.Size(107, 26);
            this.txtBoxPrecServ.TabIndex = 3;
            this.txtBoxPrecServ.TextChanged += new System.EventHandler(this.txtBoxPrecServ_TextChanged);
            this.txtBoxPrecServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // lblPrecServ
            // 
            this.lblPrecServ.AutoSize = true;
            this.lblPrecServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecServ.Location = new System.Drawing.Point(84, 128);
            this.lblPrecServ.Name = "lblPrecServ";
            this.lblPrecServ.Size = new System.Drawing.Size(48, 18);
            this.lblPrecServ.TabIndex = 34;
            this.lblPrecServ.Text = "Preço";
            // 
            // txtBoxNomeServ
            // 
            this.txtBoxNomeServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeServ.Location = new System.Drawing.Point(155, 23);
            this.txtBoxNomeServ.Name = "txtBoxNomeServ";
            this.txtBoxNomeServ.Size = new System.Drawing.Size(267, 26);
            this.txtBoxNomeServ.TabIndex = 1;
            // 
            // lblNomeServ
            // 
            this.lblNomeServ.AutoSize = true;
            this.lblNomeServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeServ.Location = new System.Drawing.Point(83, 32);
            this.lblNomeServ.Name = "lblNomeServ";
            this.lblNomeServ.Size = new System.Drawing.Size(49, 18);
            this.lblNomeServ.TabIndex = 32;
            this.lblNomeServ.Text = "Nome";
            // 
            // lblMsgServicos
            // 
            this.lblMsgServicos.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgServicos.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsgServicos.Location = new System.Drawing.Point(2, 83);
            this.lblMsgServicos.Name = "lblMsgServicos";
            this.lblMsgServicos.Size = new System.Drawing.Size(1062, 60);
            this.lblMsgServicos.TabIndex = 32;
            this.lblMsgServicos.Text = "Cadastro de Serviços";
            this.lblMsgServicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpresaServ
            // 
            this.lblEmpresaServ.AutoSize = true;
            this.lblEmpresaServ.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblEmpresaServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaServ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpresaServ.Location = new System.Drawing.Point(86, 19);
            this.lblEmpresaServ.Name = "lblEmpresaServ";
            this.lblEmpresaServ.Size = new System.Drawing.Size(204, 18);
            this.lblEmpresaServ.TabIndex = 75;
            this.lblEmpresaServ.Text = "Easy Way BeautySpecial";
            this.lblEmpresaServ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.lblEmpresaServ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.lblEmpresaServ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // btnFecharServ
            // 
            this.btnFecharServ.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharServ.BackgroundImage = global::BeautySpecial.Properties.Resources.Fechar;
            this.btnFecharServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharServ.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharServ.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharServ.Location = new System.Drawing.Point(1035, 9);
            this.btnFecharServ.Name = "btnFecharServ";
            this.btnFecharServ.Size = new System.Drawing.Size(33, 29);
            this.btnFecharServ.TabIndex = 2;
            this.btnFecharServ.UseVisualStyleBackColor = false;
            this.btnFecharServ.Click += new System.EventHandler(this.btnFecharServ_Click);
            // 
            // btnMinimizarServ
            // 
            this.btnMinimizarServ.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarServ.BackgroundImage = global::BeautySpecial.Properties.Resources.Minimizar;
            this.btnMinimizarServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarServ.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizarServ.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarServ.Location = new System.Drawing.Point(987, 9);
            this.btnMinimizarServ.Name = "btnMinimizarServ";
            this.btnMinimizarServ.Size = new System.Drawing.Size(33, 29);
            this.btnMinimizarServ.TabIndex = 1;
            this.btnMinimizarServ.UseVisualStyleBackColor = false;
            this.btnMinimizarServ.Click += new System.EventHandler(this.btnMinimizarServ_Click);
            // 
            // picBoxLogoServ
            // 
            this.picBoxLogoServ.BackColor = System.Drawing.Color.DarkOrchid;
            this.picBoxLogoServ.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoServ.Image")));
            this.picBoxLogoServ.Location = new System.Drawing.Point(6, 7);
            this.picBoxLogoServ.Name = "picBoxLogoServ";
            this.picBoxLogoServ.Size = new System.Drawing.Size(74, 48);
            this.picBoxLogoServ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoServ.TabIndex = 74;
            this.picBoxLogoServ.TabStop = false;
            this.picBoxLogoServ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.picBoxLogoServ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.picBoxLogoServ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.DarkOrchid;
            this.label37.Location = new System.Drawing.Point(0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(1083, 65);
            this.label37.TabIndex = 71;
            this.label37.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.label37.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.label37.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // FrmCadServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.lblEmpresaServ);
            this.Controls.Add(this.btnFecharServ);
            this.Controls.Add(this.btnMinimizarServ);
            this.Controls.Add(this.picBoxLogoServ);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.lblMsgServicos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Serviços";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoServ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvarServ;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblMsgServicos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxDescServ;
        private System.Windows.Forms.Label lblDescServ;
        private System.Windows.Forms.Label lblMarcServ;
        private System.Windows.Forms.TextBox txtBoxPrecServ;
        private System.Windows.Forms.Label lblPrecServ;
        private System.Windows.Forms.TextBox txtBoxNomeServ;
        private System.Windows.Forms.Label lblNomeServ;
        private System.Windows.Forms.Label lblEmpresaServ;
        private System.Windows.Forms.Button btnFecharServ;
        private System.Windows.Forms.Button btnMinimizarServ;
        private System.Windows.Forms.PictureBox picBoxLogoServ;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnCancelarCadServ;
        private System.Windows.Forms.MaskedTextBox mkdTxtBoxDuracServ;
        private System.Windows.Forms.Label lblMsgPrecoServ;
        private System.Windows.Forms.Label lblMsgDuracaoServ;
        private System.Windows.Forms.Label lblMsgNomeServ;
    }
}