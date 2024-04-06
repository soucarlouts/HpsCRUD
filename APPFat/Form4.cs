using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace APPFat
{
    public partial class Form4 : Form
    {

        MySqlConnection con;
        string data_sql = "datasource=localhost;username=root;password=98950021Gbnm@;database=dbtest;";

        public Form4()
        {
            InitializeComponent();

            // Configurando o ListView
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("boleto", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("nota", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("valor", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("data de lançamento", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("data de vencimento", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Descrição", 500, HorizontalAlignment.Left);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                using (con = new MySqlConnection(data_sql))
                {
                    string sql = "SELECT * FROM nf";
                    using (MySqlCommand command = new MySqlCommand(sql, con))
                    {
                        con.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listView1.Items.Clear();

                            while (reader.Read())
                            {
                                string id = reader.GetInt32(0).ToString();
                                string nome = reader.GetString(1);
                                string boleto = reader.GetString(2);
                                string nota = reader.GetString(3);
                                decimal valor = reader.GetDecimal(4);
                                DateTime DataLancamento = reader.GetDateTime(5);
                                DateTime DataVencimento = reader.GetDateTime(6);
                                string descricao = reader.GetString(7);

                                string[] row = { id, nome, boleto, nota, valor.ToString(), DataLancamento.ToString(), DataVencimento.ToString(), descricao };
                                var linha_listView = new ListViewItem(row);
                                listView1.Items.Add(linha_listView);
                            }
                        }
                    }
                }
                MessageBox.Show("Dados carregados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void buscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string q = "%" + textBox1.Text + "%";

                using (con = new MySqlConnection(data_sql))
                {
                    string sql = "SELECT * FROM nf WHERE nome LIKE @nome";
                    using (MySqlCommand comand = new MySqlCommand(sql, con))
                    {
                        comand.Parameters.AddWithValue("@nome", q);
                        con.Open();

                        using (MySqlDataReader reader = comand.ExecuteReader())
                        {
                            listView1.Items.Clear();

                            while (reader.Read())
                            {
                                string id = reader.GetInt32(0).ToString();
                                string nome = reader.GetString(1);
                                string boleto = reader.GetString(2);
                                string nota = reader.GetString(3);
                                string valor = reader.GetString(4);
                                string DataLançamento = reader.GetString(5);
                                string DataVencimento = reader.GetString(6);
                                string descricao = reader.GetString(7);

                                string[] row = { id, nome, boleto, nota, valor, DataLançamento, DataVencimento, descricao };
                                var linha_listView = new ListViewItem(row);
                                listView1.Items.Add(linha_listView);
                            }
                        }
                    }
                }
                MessageBox.Show("Consulta realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
