using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumsOverrides
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Persoon> L = new List<Persoon>();
            L.Add(new Persoon("Marie", 12, Persoon.Landen.Nederland));
            L.Add(new Persoon("Piet", 14, Persoon.Landen.Duitsland));
            L.Add(new Persoon("Jan", 16, Persoon.Landen.Frankrijk));
            L.Add(new Persoon("Dave", 17, Persoon.Landen.Spanje));
            L.Add(new Persoon("Ronald", 18, Persoon.Landen.Zweden));
            L.Add(new Persoon("Maxime", 19, Persoon.Landen.Frankrijk));

            foreach (Persoon p in L) {
                listBox1.Items.Add(p);                            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persoon.Landen value;
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out value);
        }
    }
}
