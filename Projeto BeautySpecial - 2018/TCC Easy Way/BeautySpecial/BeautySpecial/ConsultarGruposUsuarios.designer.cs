namespace Apresentacao
{
    partial class ConsultarGruposUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarGruposUsuarios));
            this.lblEmpresaProd = new System.Windows.Forms.Label();
            this.lblMsgConsUsu = new System.Windows.Forms.Label();
            this.btnPesquisarConsGrup = new System.Windows.Forms.Button();
            this.txtBoxPesqConsGrup = new System.Windows.Forms.TextBox();
            this.DataGridConsGrup = new System.Windows.Forms.DataGridView();
            this.ID_ConsUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo_ConsUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnFecharProd = new System.Windows.Forms.Button();
            this.btnMinimizarProd = new System.Windows.Forms.Button();
            this.picBoxLogoProd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConsGrup)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresaProd
            // 
            this.lblEmpresaProd.AutoSize = true;
            this.lblEmpresaProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblEmpresaProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpresaProd.Location = new System.Drawing.Point(86, 19);
            this.lblEmpresaProd.Name = "lblEmpresaProd";
            this.lblEmpresaProd.Size = new System.Drawing.Size(204, 18);
            this.lblEmpresaProd.TabIndex = 99;
            this.lblEmpresaProd.Text = "Easy Way BeautySpecial";
            this.lblEmpresaProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.lblEmpresaProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.lblEmpresaProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // lblMsgConsUsu
            // 
            this.lblMsgConsUsu.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgConsUsu.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsgConsUsu.Location = new System.Drawing.Point(2, 83);
            this.lblMsgConsUsu.Name = "lblMsgConsUsu";
            this.lblMsgConsUsu.Size = new System.Drawing.Size(1062, 60);
            this.lblMsgConsUsu.TabIndex = 94;
            this.lblMsgConsUsu.Text = "Consultar Grupos de Usuários";
            this.lblMsgConsUsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPesquisarConsGrup
            // 
            this.btnPesquisarConsGrup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisarConsGrup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarConsGrup.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarConsGrup.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarConsGrup.Location = new System.Drawing.Point(923, 30);
            this.btnPesquisarConsGrup.Name = "btnPesquisarConsGrup";
            this.btnPesquisarConsGrup.Size = new System.Drawing.Size(108, 37);
            this.btnPesquisarConsGrup.TabIndex = 2;
            this.btnPesquisarConsGrup.Text = "Pesquisar";
            this.btnPesquisarConsGrup.UseVisualStyleBackColor = false;
            this.btnPesquisarConsGrup.Click += new System.EventHandler(this.btnPesquisarConsGrup_Click);
            // 
            // txtBoxPesqConsGrup
            // 
            this.txtBoxPesqConsGrup.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesqConsGrup.Location = new System.Drawing.Point(23, 40);
            this.txtBoxPesqConsGrup.MaxLength = 100;
            this.txtBoxPesqConsGrup.Name = "txtBoxPesqConsGrup";
            this.txtBoxPesqConsGrup.Size = new System.Drawing.Size(884, 26);
            this.txtBoxPesqConsGrup.TabIndex = 1;
            this.txtBoxPesqConsGrup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPesqConsGrup_KeyDown);
            // 
            // DataGridConsGrup
            // 
            this.DataGridConsGrup.AllowUserToAddRows = false;
            this.DataGridConsGrup.AllowUserToDeleteRows = false;
            this.DataGridConsGrup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridConsGrup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridConsGrup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridConsGrup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ConsUsu,
            this.Grupo_ConsUsu});
            this.DataGridConsGrup.Location = new System.Drawing.Point(23, 98);
            this.DataGridConsGrup.MultiSelect = false;
            this.DataGridConsGrup.Name = "DataGridConsGrup";
            this.DataGridConsGrup.RowHeadersVisible = false;
            this.DataGridConsGrup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridConsGrup.Size = new System.Drawing.Size(1009, 380);
            this.DataGridConsGrup.TabIndex = 78;
            this.DataGridConsGrup.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridConsUsu_CellMouseDoubleClick);
            // 
            // ID_ConsUsu
            // 
            this.ID_ConsUsu.DataPropertyName = "ID_Grupo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.ID_ConsUsu.DefaultCellStyle = dataGridViewCellStyle8;
            this.ID_ConsUsu.HeaderText = "Código";
            this.ID_ConsUsu.Name = "ID_ConsUsu";
            this.ID_ConsUsu.ReadOnly = true;
            this.ID_ConsUsu.Width = 60;
            // 
            // Grupo_ConsUsu
            // 
            this.Grupo_ConsUsu.DataPropertyName = "Descricao_Grup";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Format = "0000000000000-0";
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Grupo_ConsUsu.DefaultCellStyle = dataGridViewCellStyle9;
            this.Grupo_ConsUsu.HeaderText = "Grupo";
            this.Grupo_ConsUsu.MaxInputLength = 14;
            this.Grupo_ConsUsu.Name = "Grupo_ConsUsu";
            this.Grupo_ConsUsu.ReadOnly = true;
            this.Grupo_ConsUsu.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DataGridConsGrup);
            this.groupBox1.Controls.Add(this.btnPesquisarConsGrup);
            this.groupBox1.Controls.Add(this.txtBoxPesqConsGrup);
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 494);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.DarkOrchid;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1083, 65);
            this.label23.TabIndex = 95;
            this.label23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.label23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.label23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // btnFecharProd
            // 
            this.btnFecharProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharProd.BackgroundImage = global::BeautySpecial.Properties.Resources.Fechar;
            this.btnFecharProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharProd.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharProd.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharProd.Location = new System.Drawing.Point(1035, 9);
            this.btnFecharProd.Name = "btnFecharProd";
            this.btnFecharProd.Size = new System.Drawing.Size(33, 29);
            this.btnFecharProd.TabIndex = 97;
            this.btnFecharProd.UseVisualStyleBackColor = false;
            this.btnFecharProd.Click += new System.EventHandler(this.btnFecharProd_Click);
            // 
            // btnMinimizarProd
            // 
            this.btnMinimizarProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarProd.BackgroundImage = global::BeautySpecial.Properties.Resources.Minimizar;
            this.btnMinimizarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarProd.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizarProd.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarProd.Location = new System.Drawing.Point(987, 9);
            this.btnMinimizarProd.Name = "btnMinimizarProd";
            this.btnMinimizarProd.Size = new System.Drawing.Size(33, 29);
            this.btnMinimizarProd.TabIndex = 96;
            this.btnMinimizarProd.UseVisualStyleBackColor = false;
            this.btnMinimizarProd.Click += new System.EventHandler(this.btnMinimizarProd_Click);
            // 
            // picBoxLogoProd
            // 
            this.picBoxLogoProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.picBoxLogoProd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoProd.Image")));
            this.picBoxLogoProd.Location = new System.Drawing.Point(6, 7);
            this.picBoxLogoProd.Name = "picBoxLogoProd";
            this.picBoxLogoProd.Size = new System.Drawing.Size(74, 48);
            this.picBoxLogoProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoProd.TabIndex = 98;
            this.picBoxLogoProd.TabStop = false;
            this.picBoxLogoProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.picBoxLogoProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.picBoxLogoProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // ConsultarGruposUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.lblEmpresaProd);
            this.Controls.Add(this.btnFecharProd);
            this.Controls.Add(this.btnMinimizarProd);
            this.Controls.Add(this.picBoxLogoProd);
            this.Controls.Add(this.lblMsgConsUsu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label23);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarGruposUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConsGrup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresaProd;
        private System.Windows.Forms.Button btnFecharProd;
        private System.Windows.Forms.Button btnMinimizarProd;
        private System.Windows.Forms.PictureBox picBoxLogoProd;
        private System.Windows.Forms.Label lblMsgConsUsu;
        private System.Windows.Forms.Button btnPesquisarConsGrup;
        private System.Windows.Forms.TextBox txtBoxPesqConsGrup;
        private System.Windows.Forms.DataGridView DataGridConsGrup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ConsUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo_ConsUsu;
    }
}