using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace iMDB
{
    public partial class Form1 : Form
    {
        List<string> filmList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshItems();   
        }

        private void refreshItems() {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\Tom\Desktop\film.db;Version=3;");
            connection.Open();

            string sql = "SELECT * FROM films";

            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["titel"].ToString());
            }

            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\Tom\Desktop\film.db;Version=3;");
            connection.Open();

            string input = txtInput.Text;
            string sql = "INSERT INTO films VALUES('"+ input +"', '2012')";
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.ExecuteNonQuery();

            refreshItems();

            connection.Close();
        }
    }
}
