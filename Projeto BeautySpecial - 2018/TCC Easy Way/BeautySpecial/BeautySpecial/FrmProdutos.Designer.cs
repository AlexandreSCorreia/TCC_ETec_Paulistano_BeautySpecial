namespace Apresentacao
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmpresaProd = new System.Windows.Forms.Label();
            this.btnFecharProd = new System.Windows.Forms.Button();
            this.btnMinimizarProd = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.lblMsgProdutos = new System.Windows.Forms.Label();
            this.picBoxLogoProd = new System.Windows.Forms.PictureBox();
            this.txtBoxPesqProd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisarProd = new System.Windows.Forms.Button();
            this.btnNovoProd = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.btnConsultarProd = new System.Windows.Forms.Button();
            this.btnAtualizarProd = new System.Windows.Forms.Button();
            this.dataGridProd = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomeprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricaoprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).BeginInit();
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
            this.lblEmpresaProd.TabIndex = 73;
            this.lblEmpresaProd.Text = "Easy Way BeautySpecial";
            this.lblEmpresaProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            this.lblEmpresaProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            this.lblEmpresaProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseUp);
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
            this.btnFecharProd.TabIndex = 71;
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
            this.btnMinimizarProd.TabIndex = 70;
            this.btnMinimizarProd.UseVisualStyleBackColor = false;
            this.btnMinimizarProd.Click += new System.EventHandler(this.btnMinimizarProd_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.DarkOrchid;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1083, 65);
            this.label23.TabIndex = 69;
            this.label23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            this.label23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            this.label23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseUp);
            // 
            // lblMsgProdutos
            // 
            this.lblMsgProdutos.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgProdutos.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsgProdutos.Location = new System.Drawing.Point(2, 83);
            this.lblMsgProdutos.Name = "lblMsgProdutos";
            this.lblMsgProdutos.Size = new System.Drawing.Size(1062, 60);
            this.lblMsgProdutos.TabIndex = 68;
            this.lblMsgProdutos.Text = "Controle de Produtos";
            this.lblMsgProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxLogoProd
            // 
            this.picBoxLogoProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.picBoxLogoProd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoProd.Image")));
            this.picBoxLogoProd.Location = new System.Drawing.Point(6, 7);
            this.picBoxLogoProd.Name = "picBoxLogoProd";
            this.picBoxLogoProd.Size = new System.Drawing.Size(74, 48);
            this.picBoxLogoProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoProd.TabIndex = 72;
            this.picBoxLogoProd.TabStop = false;
            this.picBoxLogoProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            this.picBoxLogoProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            this.picBoxLogoProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseUp);
            // 
            // txtBoxPesqProd
            // 
            this.txtBoxPesqProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesqProd.Location = new System.Drawing.Point(22, 41);
            this.txtBoxPesqProd.Name = "txtBoxPesqProd";
            this.txtBoxPesqProd.Size = new System.Drawing.Size(884, 26);
            this.txtBoxPesqProd.TabIndex = 76;
            this.txtBoxPesqProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPesqProd_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnPesquisarProd);
            this.groupBox1.Controls.Add(this.btnNovoProd);
            this.groupBox1.Controls.Add(this.btnExcluirProd);
            this.groupBox1.Controls.Add(this.btnConsultarProd);
            this.groupBox1.Controls.Add(this.btnAtualizarProd);
            this.groupBox1.Controls.Add(this.dataGridProd);
            this.groupBox1.Controls.Add(this.txtBoxPesqProd);
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 494);
            this.groupBox1.TabIndex = 77;
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
            // btnPesquisarProd
            // 
            this.btnPesquisarProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProd.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarProd.Location = new System.Drawing.Point(923, 30);
            this.btnPesquisarProd.Name = "btnPesquisarProd";
            this.btnPesquisarProd.Size = new System.Drawing.Size(108, 37);
            this.btnPesquisarProd.TabIndex = 83;
            this.btnPesquisarProd.Text = "Pesquisar";
            this.btnPesquisarProd.UseVisualStyleBackColor = false;
            this.btnPesquisarProd.Click += new System.EventHandler(this.btnPesquisarProd_Click);
            // 
            // btnNovoProd
            // 
            this.btnNovoProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNovoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProd.ForeColor = System.Drawing.Color.White;
            this.btnNovoProd.Location = new System.Drawing.Point(422, 428);
            this.btnNovoProd.Name = "btnNovoProd";
            this.btnNovoProd.Size = new System.Drawing.Size(108, 37);
            this.btnNovoProd.TabIndex = 82;
            this.btnNovoProd.Text = "Novo";
            this.btnNovoProd.UseVisualStyleBackColor = false;
            this.btnNovoProd.Click += new System.EventHandler(this.btnNovoProd_Click);
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExcluirProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProd.ForeColor = System.Drawing.Color.White;
            this.btnExcluirProd.Location = new System.Drawing.Point(797, 428);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(108, 37);
            this.btnExcluirProd.TabIndex = 80;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.UseVisualStyleBackColor = false;
            this.btnExcluirProd.Click += new System.EventHandler(this.btnExcluirProd_Click);
            // 
            // btnConsultarProd
            // 
            this.btnConsultarProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProd.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProd.Location = new System.Drawing.Point(672, 428);
            this.btnConsultarProd.Name = "btnConsultarProd";
            this.btnConsultarProd.Size = new System.Drawing.Size(108, 37);
            this.btnConsultarProd.TabIndex = 79;
            this.btnConsultarProd.Text = "Consultar";
            this.btnConsultarProd.UseVisualStyleBackColor = false;
            this.btnConsultarProd.Click += new System.EventHandler(this.btnConsultarProd_Click);
            // 
            // btnAtualizarProd
            // 
            this.btnAtualizarProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAtualizarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarProd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProd.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarProd.Location = new System.Drawing.Point(546, 428);
            this.btnAtualizarProd.Name = "btnAtualizarProd";
            this.btnAtualizarProd.Size = new System.Drawing.Size(108, 37);
            this.btnAtualizarProd.TabIndex = 78;
            this.btnAtualizarProd.Text = "Atualizar";
            this.btnAtualizarProd.UseVisualStyleBackColor = false;
            this.btnAtualizarProd.Click += new System.EventHandler(this.btnAtualizarProd_Click);
            // 
            // dataGridProd
            // 
            this.dataGridProd.AllowUserToAddRows = false;
            this.dataGridProd.AllowUserToDeleteRows = false;
            this.dataGridProd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Nomeprod,
            this.marcaprod,
            this.Descricaoprod,
            this.valorprod,
            this.nomeServ,
            this.quantidadeprod});
            this.dataGridProd.Location = new System.Drawing.Point(22, 100);
            this.dataGridProd.MultiSelect = false;
            this.dataGridProd.Name = "dataGridProd";
            this.dataGridProd.RowHeadersVisible = false;
            this.dataGridProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProd.Size = new System.Drawing.Size(1009, 298);
            this.dataGridProd.TabIndex = 77;
            this.dataGridProd.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridProd_CellFormatting);
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "id_Produto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdProduto.HeaderText = "Código";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Width = 130;
            // 
            // Nomeprod
            // 
            this.Nomeprod.DataPropertyName = "Nome_Prod";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomeprod.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nomeprod.HeaderText = "Nome do Produto";
            this.Nomeprod.MaxInputLength = 30;
            this.Nomeprod.Name = "Nomeprod";
            this.Nomeprod.ReadOnly = true;
            this.Nomeprod.Width = 170;
            // 
            // marcaprod
            // 
            this.marcaprod.DataPropertyName = "Marca_Prod";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaprod.DefaultCellStyle = dataGridViewCellStyle4;
            this.marcaprod.HeaderText = "Marca";
            this.marcaprod.Name = "marcaprod";
            this.marcaprod.ReadOnly = true;
            this.marcaprod.Width = 160;
            // 
            // Descricaoprod
            // 
            this.Descricaoprod.DataPropertyName = "Descricao_Prod";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricaoprod.DefaultCellStyle = dataGridViewCellStyle5;
            this.Descricaoprod.HeaderText = "Descrição";
            this.Descricaoprod.MaxInputLength = 256;
            this.Descricaoprod.Name = "Descricaoprod";
            this.Descricaoprod.ReadOnly = true;
            this.Descricaoprod.Width = 200;
            // 
            // valorprod
            // 
            this.valorprod.DataPropertyName = "Preco_Prod";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "##0.00";
            this.valorprod.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorprod.HeaderText = "Preço";
            this.valorprod.Name = "valorprod";
            this.valorprod.ReadOnly = true;
            // 
            // nomeServ
            // 
            this.nomeServ.DataPropertyName = "classServico_DTO.Nome_Serv";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeServ.DefaultCellStyle = dataGridViewCellStyle7;
            this.nomeServ.HeaderText = "Serviço";
            this.nomeServ.Name = "nomeServ";
            this.nomeServ.ReadOnly = true;
            this.nomeServ.Width = 170;
            // 
            // quantidadeprod
            // 
            this.quantidadeprod.DataPropertyName = "Quantidade_Prod";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeprod.DefaultCellStyle = dataGridViewCellStyle8;
            this.quantidadeprod.HeaderText = "Quantidade";
            this.quantidadeprod.MaxInputLength = 225;
            this.quantidadeprod.Name = "quantidadeprod";
            this.quantidadeprod.ReadOnly = true;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEmpresaProd);
            this.Controls.Add(this.btnFecharProd);
            this.Controls.Add(this.btnMinimizarProd);
            this.Controls.Add(this.picBoxLogoProd);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblMsgProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpresaProd;
        private System.Windows.Forms.Button btnFecharProd;
        private System.Windows.Forms.Button btnMinimizarProd;
        private System.Windows.Forms.PictureBox picBoxLogoProd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblMsgProdutos;
        private System.Windows.Forms.TextBox txtBoxPesqProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridProd;
        private System.Windows.Forms.Button btnNovoProd;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnConsultarProd;
        private System.Windows.Forms.Button btnAtualizarProd;
        private System.Windows.Forms.Button btnPesquisarProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomeprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricaoprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprod;
    }
}