namespace Apresentacao
{
    partial class FrmServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicos));
            this.dataGridServ = new System.Windows.Forms.DataGridView();
            this.IDServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracaoServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxPesqServ = new System.Windows.Forms.TextBox();
            this.lblEmpresaProd = new System.Windows.Forms.Label();
            this.btnFecharProd = new System.Windows.Forms.Button();
            this.btnMinimizarProd = new System.Windows.Forms.Button();
            this.picBoxLogoProd = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblMsgServicos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovoServ = new System.Windows.Forms.Button();
            this.btnExcluirServ = new System.Windows.Forms.Button();
            this.btnConsultarServ = new System.Windows.Forms.Button();
            this.btnAtualizarServ = new System.Windows.Forms.Button();
            this.btnPesquisarServ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridServ
            // 
            this.dataGridServ.AllowUserToAddRows = false;
            this.dataGridServ.AllowUserToDeleteRows = false;
            this.dataGridServ.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridServ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDServico,
            this.NomeServ,
            this.PrecoServ,
            this.DescricaoServ,
            this.DuracaoServ});
            this.dataGridServ.Location = new System.Drawing.Point(22, 100);
            this.dataGridServ.MultiSelect = false;
            this.dataGridServ.Name = "dataGridServ";
            this.dataGridServ.RowHeadersVisible = false;
            this.dataGridServ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServ.Size = new System.Drawing.Size(1009, 298);
            this.dataGridServ.TabIndex = 77;
            this.dataGridServ.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridServ_CellFormatting);
            // 
            // IDServico
            // 
            this.IDServico.DataPropertyName = "ID_Servico";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDServico.DefaultCellStyle = dataGridViewCellStyle2;
            this.IDServico.HeaderText = "Código";
            this.IDServico.Name = "IDServico";
            this.IDServico.ReadOnly = true;
            this.IDServico.Width = 130;
            // 
            // NomeServ
            // 
            this.NomeServ.DataPropertyName = "Nome_Serv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeServ.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomeServ.HeaderText = "Serviço";
            this.NomeServ.Name = "NomeServ";
            this.NomeServ.ReadOnly = true;
            this.NomeServ.Width = 150;
            // 
            // PrecoServ
            // 
            this.PrecoServ.DataPropertyName = "Preco_Serv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "##.#0";
            this.PrecoServ.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecoServ.HeaderText = "Preço";
            this.PrecoServ.Name = "PrecoServ";
            this.PrecoServ.ReadOnly = true;
            this.PrecoServ.Width = 120;
            // 
            // DescricaoServ
            // 
            this.DescricaoServ.DataPropertyName = "Descricao_Serv";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescricaoServ.DefaultCellStyle = dataGridViewCellStyle5;
            this.DescricaoServ.HeaderText = "Descrição";
            this.DescricaoServ.MaxInputLength = 256;
            this.DescricaoServ.Name = "DescricaoServ";
            this.DescricaoServ.ReadOnly = true;
            this.DescricaoServ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescricaoServ.Width = 250;
            // 
            // DuracaoServ
            // 
            this.DuracaoServ.DataPropertyName = "Duracao_Serv";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuracaoServ.DefaultCellStyle = dataGridViewCellStyle6;
            this.DuracaoServ.HeaderText = "Duração";
            this.DuracaoServ.Name = "DuracaoServ";
            this.DuracaoServ.ReadOnly = true;
            // 
            // txtBoxPesqServ
            // 
            this.txtBoxPesqServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesqServ.Location = new System.Drawing.Point(22, 41);
            this.txtBoxPesqServ.Name = "txtBoxPesqServ";
            this.txtBoxPesqServ.Size = new System.Drawing.Size(885, 26);
            this.txtBoxPesqServ.TabIndex = 76;
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
            this.lblEmpresaProd.TabIndex = 83;
            this.lblEmpresaProd.Text = "Easy Way BeautySpecial";
            this.lblEmpresaProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label23_MouseDown);
            this.lblEmpresaProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label23_MouseMove);
            this.lblEmpresaProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label23_MouseUp);
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
            this.btnFecharProd.TabIndex = 81;
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
            this.btnMinimizarProd.TabIndex = 80;
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
            this.picBoxLogoProd.TabIndex = 82;
            this.picBoxLogoProd.TabStop = false;
            this.picBoxLogoProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label23_MouseDown);
            this.picBoxLogoProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label23_MouseMove);
            this.picBoxLogoProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label23_MouseUp);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.DarkOrchid;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1083, 65);
            this.label23.TabIndex = 79;
            this.label23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label23_MouseDown);
            this.label23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label23_MouseMove);
            this.label23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label23_MouseUp);
            // 
            // lblMsgServicos
            // 
            this.lblMsgServicos.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgServicos.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsgServicos.Location = new System.Drawing.Point(2, 83);
            this.lblMsgServicos.Name = "lblMsgServicos";
            this.lblMsgServicos.Size = new System.Drawing.Size(1062, 60);
            this.lblMsgServicos.TabIndex = 78;
            this.lblMsgServicos.Text = "Controle de Serviços";
            this.lblMsgServicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNovoServ);
            this.groupBox1.Controls.Add(this.btnExcluirServ);
            this.groupBox1.Controls.Add(this.btnConsultarServ);
            this.groupBox1.Controls.Add(this.btnAtualizarServ);
            this.groupBox1.Controls.Add(this.btnPesquisarServ);
            this.groupBox1.Controls.Add(this.dataGridServ);
            this.groupBox1.Controls.Add(this.txtBoxPesqServ);
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 494);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(923, 428);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 37);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovoServ
            // 
            this.btnNovoServ.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNovoServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoServ.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoServ.ForeColor = System.Drawing.Color.White;
            this.btnNovoServ.Location = new System.Drawing.Point(422, 428);
            this.btnNovoServ.Name = "btnNovoServ";
            this.btnNovoServ.Size = new System.Drawing.Size(108, 37);
            this.btnNovoServ.TabIndex = 83;
            this.btnNovoServ.Text = "Novo";
            this.btnNovoServ.UseVisualStyleBackColor = false;
            this.btnNovoServ.Click += new System.EventHandler(this.btnNovoServ_Click);
            // 
            // btnExcluirServ
            // 
            this.btnExcluirServ.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExcluirServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirServ.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirServ.ForeColor = System.Drawing.Color.White;
            this.btnExcluirServ.Location = new System.Drawing.Point(797, 428);
            this.btnExcluirServ.Name = "btnExcluirServ";
            this.btnExcluirServ.Size = new System.Drawing.Size(108, 37);
            this.btnExcluirServ.TabIndex = 81;
            this.btnExcluirServ.Text = "Excluir";
            this.btnExcluirServ.UseVisualStyleBackColor = false;
            this.btnExcluirServ.Click += new System.EventHandler(this.btnExcluirServ_Click);
            // 
            // btnConsultarServ
            // 
            this.btnConsultarServ.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarServ.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarServ.ForeColor = System.Drawing.Color.White;
            this.btnConsultarServ.Location = new System.Drawing.Point(672, 428);
            this.btnConsultarServ.Name = "btnConsultarServ";
            this.btnConsultarServ.Size = new System.Drawing.Size(108, 37);
            this.btnConsultarServ.TabIndex = 80;
            this.btnConsultarServ.Text = "Consultar";
            this.btnConsultarServ.UseVisualStyleBackColor = false;
            this.btnConsultarServ.Click += new System.EventHandler(this.btnConsultarServ_Click);
            // 
            // btnAtualizarServ
            // 
            this.btnAtualizarServ.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAtualizarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarServ.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarServ.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarServ.Location = new System.Drawing.Point(546, 428);
            this.btnAtualizarServ.Name = "btnAtualizarServ";
            this.btnAtualizarServ.Size = new System.Drawing.Size(108, 37);
            this.btnAtualizarServ.TabIndex = 79;
            this.btnAtualizarServ.Text = "Atualizar";
            this.btnAtualizarServ.UseVisualStyleBackColor = false;
            this.btnAtualizarServ.Click += new System.EventHandler(this.btnAtualizarServ_Click);
            // 
            // btnPesquisarServ
            // 
            this.btnPesquisarServ.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarServ.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarServ.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarServ.Location = new System.Drawing.Point(923, 30);
            this.btnPesquisarServ.Name = "btnPesquisarServ";
            this.btnPesquisarServ.Size = new System.Drawing.Size(108, 37);
            this.btnPesquisarServ.TabIndex = 78;
            this.btnPesquisarServ.Text = "Pesquisar";
            this.btnPesquisarServ.UseVisualStyleBackColor = false;
            this.btnPesquisarServ.Click += new System.EventHandler(this.btnPesquisarServ_Click);
            // 
            // FrmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.lblEmpresaProd);
            this.Controls.Add(this.btnFecharProd);
            this.Controls.Add(this.btnMinimizarProd);
            this.Controls.Add(this.picBoxLogoProd);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblMsgServicos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicos";
            this.Load += new System.EventHandler(this.FrmServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridServ;
        private System.Windows.Forms.TextBox txtBoxPesqServ;
        private System.Windows.Forms.Label lblEmpresaProd;
        private System.Windows.Forms.Button btnFecharProd;
        private System.Windows.Forms.Button btnMinimizarProd;
        private System.Windows.Forms.PictureBox picBoxLogoProd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblMsgServicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisarServ;
        private System.Windows.Forms.Button btnNovoServ;
        private System.Windows.Forms.Button btnExcluirServ;
        private System.Windows.Forms.Button btnConsultarServ;
        private System.Windows.Forms.Button btnAtualizarServ;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracaoServ;
    }
}