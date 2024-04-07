using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//usando esta linha de codigo acima eu abro a conexão com o mySql

namespace APPFat
{
    public partial class NOTAFISCAL : Form
    {
        MySqlConnection con;

        public NOTAFISCAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                string data_sql = "datasource=localhost;username=root;password=98950021Gbnm@;database=dbtest;";
                //aqui iremos abrir a conexão com o banco de dados
                con = new MySqlConnection(data_sql);



                string sql = "INSERT INTO NF (boleto, nota, valor, nome, DataLançamento, DataVencimento, DESCRICAO, horario)" +
                    "VALUES" +
                    " ('"+Nboleto.Text+"', '"+Nnota.Text+"','"+valor.Text+"', '"+NomeFunc.Text+"'," +
                    " '"+dateTimePicker1.Text+"', '"+dateTimePicker2.Text+"', '"+RTB.Text+"', '"+dateTimePicker3.Text+"')";

               

                MySqlCommand comand = new MySqlCommand(sql, con);
                con.Open();
                comand.ExecuteNonQuery();
                //envia o comando para o banco de dados 
                MessageBox.Show("DEU CERTO");
                //da o feedback ao usuario que a operação funcionou
                Nboleto.Clear(); Nnota.Clear();valor.Clear();NomeFunc.Clear();RTB.Clear();
            }
            catch (Exception ex){

                MessageBox.Show("Erro ao lançar nota: " + ex.Message);
            }
            
            finally { con.Close(); }
        }
        
        }

    
    }

