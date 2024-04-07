using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace APPFat
{

   
    public partial class CadastrarForn : Form
    {
        MySqlConnection con;
        public CadastrarForn()
        {
            InitializeComponent();
        }
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            try {

                string data_sql = "datasource=localhost;username=root;password=98950021Gbnm@;database=dbtest;";
                con = new MySqlConnection(data_sql);

                string sql = "INSERT INTO fornecedor (nome,cnpj,atividade,celular ,email, endereco) VALUES " +
                    "('"+NomeForn.Text+"','"+CnpjTextBOX.Text+"','"+AreaAtuaçãoTextBox.Text+"', '"+CelularTextBox.Text+"', '"+EmailText.Text+"', '"+textEndereço.Text+"');";
                MySqlCommand comand = new MySqlCommand(sql, con);
                con.Open();
                comand.ExecuteNonQuery();
                MessageBox.Show("DEU CERTO");
                con.Close();
                InitializeComponent();

            }


            catch (Exception ex) { MessageBox.Show("ERRO: "+ex.Message); } finally { }
        }
    }
}
