using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yahtzee game = new Yahtzee();
            List<string> worpen = new List<string>();

            for (int i = 0; i < 50; i++) {
                game.doeWorp();
                worpen.Add(game);
            }

            foreach (string x in worpen) {
                listBox1.Items.Add(x);
            }
        }
    }
}
