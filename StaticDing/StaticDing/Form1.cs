using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticDing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleton1 singleton = new Singleton1();

            MessageBox.Show(Singleton1.ReturnPoep());
           
            
            MessageBox.Show(singleton.Nummer.ToString());
            singleton.Naam = "Tom";
            singleton.Vleugels = 6;

            MessageBox.Show(singleton.Naam);
            MessageBox.Show(singleton.Vleugels.ToString());

            Singleton1 singleton2 = new Singleton1();
            MessageBox.Show(singleton2.Nummer.ToString());

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Singleton singleton = Singleton.getInstance();
            MessageBox.Show(singleton.ReturnRandom().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Singleton singleton = Singleton.getInstance();
            MessageBox.Show(singleton.ReturnRandom().ToString());
        }
    }
}
