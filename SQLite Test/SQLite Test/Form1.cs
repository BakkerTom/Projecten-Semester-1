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

namespace SQLite_Test
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection conn = Connection.getInstance();
            refreshItems(conn.getConnection());
        }

        private void refreshItems(SQLiteConnection connection)
        {
            Connection conn = Connection.getInstance();

            string sql = "SELECT * FROM film";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn.getConnection());
            SQLiteDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();

            while (reader.Read())
            {
                string title = reader["title"].ToString();
                int uitgavejaar = Convert.ToInt32(reader["uitgavejaar"].ToString());
                Film f = new Film(title, uitgavejaar);

                listBox1.Items.Add(f.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Connection conn = Connection.getInstance();

            string titel = txtTitel.Text;
            int jaar = Convert.ToInt32(txtJaar.Text);

            string sql = "INSERT INTO film(title, uitgavejaar) VALUES ('" + titel + "', " + jaar + ")";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn.getConnection());

            cmd.ExecuteNonQuery();

            refreshItems(conn.getConnection());
        }
    }
}
