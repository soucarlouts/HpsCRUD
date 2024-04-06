namespace APPFat
{
    partial class ApagarForn
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
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hpsProjetoDataSet = new APPFat.HpsProjetoDataSet();
            this.hpsProjeto = new APPFat.HpsProjeto();
            this.hpsProjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new APPFat.HpsProjetoDataSetTableAdapters.FornecedorTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTbuscarCtt = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.cadastrarFornBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpsProjetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpsProjeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpsProjetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarFornBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.hpsProjetoDataSet;
            // 
            // hpsProjetoDataSet
            // 
            this.hpsProjetoDataSet.DataSetName = "HpsProjetoDataSet";
            this.hpsProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hpsProjeto
            // 
            this.hpsProjeto.DataSetName = "HpsProjeto";
            this.hpsProjeto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hpsProjetoBindingSource
            // 
            this.hpsProjetoBindingSource.DataSource = this.hpsProjeto;
            this.hpsProjetoBindingSource.Position = 0;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(920, 244);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Contato";
            // 
            // TXTbuscarCtt
            // 
            this.TXTbuscarCtt.BackColor = System.Drawing.SystemColors.Info;
            this.TXTbuscarCtt.Location = new System.Drawing.Point(222, 76);
            this.TXTbuscarCtt.Name = "TXTbuscarCtt";
            this.TXTbuscarCtt.Size = new System.Drawing.Size(233, 22);
            this.TXTbuscarCtt.TabIndex = 2;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(528, 76);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(129, 22);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // cadastrarFornBindingSource
            // 
            this.cadastrarFornBindingSource.DataSource = typeof(APPFat.CadastrarForn);
            // 
            // ApagarForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APPFat.Properties.Resources.Modern_Creative_Technology_Logo;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.TXTbuscarCtt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "ApagarForn";
            this.Text = "ApagarForn";
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpsProjetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpsProjeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpsProjetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarFornBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource hpsProjetoBindingSource;
        private HpsProjeto hpsProjeto;
        private System.Windows.Forms.BindingSource cadastrarFornBindingSource;
        private HpsProjetoDataSet hpsProjetoDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private HpsProjetoDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTbuscarCtt;
        private System.Windows.Forms.Button Buscar;
    }
}