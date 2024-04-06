using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace APPFat
{
    public partial class Fatura : Form
    {

        MySqlConnection con;
        public Fatura()
        {
            InitializeComponent();
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

        }

        private void comNfeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var Form2 = new NOTAFISCAL();
            Form2.Show();
        }

        private void semNfeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void verificarLançamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form4 = new Form4();
            Form4.Show();
                
        }


        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormCadastro = new CadastrarForn();
            FormCadastro.Show();
        }

        private void apagarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormDelForn = new ApagarForn();
            FormDelForn.Show();
        }

        private void clientesCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadastroClientes = new CadastroCliente();
            CadastroClientes.Show();
        }

 
    }


}