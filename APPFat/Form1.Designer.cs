namespace APPFat
{
    partial class Fatura
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sELECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comNfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarLançamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sELECTToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cadastrarFornToolStripMenuItem,
            this.clientesCadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1051, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sELECTToolStripMenuItem
            // 
            this.sELECTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaToolStripMenuItem,
            this.verificarLançamentoToolStripMenuItem});
            this.sELECTToolStripMenuItem.Image = global::APPFat.Properties.Resources.documento_assinado;
            this.sELECTToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.sELECTToolStripMenuItem.Name = "sELECTToolStripMenuItem";
            this.sELECTToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.sELECTToolStripMenuItem.Text = "Custos";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comNfeToolStripMenuItem});
            this.faturaToolStripMenuItem.Image = global::APPFat.Properties.Resources.dolar_da_fatura_do_arquivo;
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.faturaToolStripMenuItem.Text = "Fatura";
            // 
            // comNfeToolStripMenuItem
            // 
            this.comNfeToolStripMenuItem.Image = global::APPFat.Properties.Resources.dolar_da_fatura_do_arquivo;
            this.comNfeToolStripMenuItem.Name = "comNfeToolStripMenuItem";
            this.comNfeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comNfeToolStripMenuItem.Text = "Boleto";
            this.comNfeToolStripMenuItem.Click += new System.EventHandler(this.comNfeToolStripMenuItem_Click);
            // 
            // verificarLançamentoToolStripMenuItem
            // 
            this.verificarLançamentoToolStripMenuItem.Image = global::APPFat.Properties.Resources.copiar_alt;
            this.verificarLançamentoToolStripMenuItem.Name = "verificarLançamentoToolStripMenuItem";
            this.verificarLançamentoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verificarLançamentoToolStripMenuItem.Text = "Alterar Lançamento";
            this.verificarLançamentoToolStripMenuItem.Click += new System.EventHandler(this.verificarLançamentoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 28);
            // 
            // cadastrarFornToolStripMenuItem
            // 
            this.cadastrarFornToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedorToolStripMenuItem,
            this.apagarFornecedorToolStripMenuItem});
            this.cadastrarFornToolStripMenuItem.Image = global::APPFat.Properties.Resources.corporativo;
            this.cadastrarFornToolStripMenuItem.Name = "cadastrarFornToolStripMenuItem";
            this.cadastrarFornToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.cadastrarFornToolStripMenuItem.Text = "Fornecedor";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Image = global::APPFat.Properties.Resources.adicionar_usuario;
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor ";
            this.cadastrarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedorToolStripMenuItem_Click);
            // 
            // apagarFornecedorToolStripMenuItem
            // 
            this.apagarFornecedorToolStripMenuItem.Image = global::APPFat.Properties.Resources.lixo;
            this.apagarFornecedorToolStripMenuItem.Name = "apagarFornecedorToolStripMenuItem";
            this.apagarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.apagarFornecedorToolStripMenuItem.Text = "Deletar fornecedor";
            this.apagarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.apagarFornecedorToolStripMenuItem_Click);
            // 
            // clientesCadastroToolStripMenuItem
            // 
            this.clientesCadastroToolStripMenuItem.Image = global::APPFat.Properties.Resources.adicionar_usuario;
            this.clientesCadastroToolStripMenuItem.Name = "clientesCadastroToolStripMenuItem";
            this.clientesCadastroToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.clientesCadastroToolStripMenuItem.Text = "Cadastro De Clientes";
            this.clientesCadastroToolStripMenuItem.Click += new System.EventHandler(this.clientesCadastroToolStripMenuItem_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::APPFat.Properties.Resources.Modern_Creative_Technology_Logo;
            this.ClientSize = new System.Drawing.Size(1051, 787);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fatura";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sELECTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comNfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarLançamentoToolStripMenuItem;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesCadastroToolStripMenuItem;
    }
}

