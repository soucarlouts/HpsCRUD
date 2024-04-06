using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace APPFat
{
    public partial class ApagarForn : Form
    {
        private MySqlConnection con;
        private string data_sql = "datasource=localhost;username=root;password=98950021Gbnm@;database=dbtest;";

        public ApagarForn()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Cnpj", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Email", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Celular", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Atividade", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("endereco", 130, HorizontalAlignment.Left);

        }

        private void ApagarForn_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            try
            {
                con = new MySqlConnection(data_sql);
                con.Open();
                string sqlQuery = "SELECT * FROM Fornecedor";
                MySqlCommand command = new MySqlCommand(sqlQuery, con);
                MySqlDataReader reader = command.ExecuteReader();
                listView1.Items.Clear(); // aqui é limpa a lista para que novos valores possam ser mostrados

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    };
                    var linha_listView = new ListViewItem(row);
                    listView1.Items.Add(linha_listView);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "%" + TXTbuscarCtt.Text + "%";

                using (con = new MySqlConnection(data_sql))
                {
                    string sql = "SELECT * FROM fornecedor WHERE nome LIKE @nome";
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
                                //aqui persistia um erro de tipo, por isso o uso do Int32
                                string nome = reader.GetString(1);
                                string cnpj = reader.GetString(2);
                                string celular = reader.GetString(5);
                                string email = reader.GetString(4);
                                string atividade = reader.GetString(3);
                                string endereco = reader.GetString(6);

                                string[] row = { id, nome, cnpj, celular, email, atividade, endereco};
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
        private void listView1_DoubleClick(object sender, EventArgs e) // este bloco de codigo deleta o lançamento selecionado
        {
            try
            {
                if (listView1.SelectedItems.Count > 0) 
                {
                    ListViewItem item = listView1.SelectedItems[0]; 
                    string id = item.SubItems[0].Text; 

                    using (con = new MySqlConnection(data_sql))
                    {
                        con.Open();

                        string delString = "DELETE FROM fornecedor WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(delString, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {

                                MessageBox.Show("Registro excluído com sucesso.");
                                CarregarFornecedores(); 
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro foi excluído.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um fornecedor para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}