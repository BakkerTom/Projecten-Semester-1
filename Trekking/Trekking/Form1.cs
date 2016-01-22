using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trekking
{
    public partial class Form1 : Form
    {
        //Fields
        private Trekking trekking;

        public Form1()
        {
            InitializeComponent();

            btnTrek.Enabled = false;
            btnSerie.Enabled = false;
            btnSorteer.Enabled = false;
            btnLaatzien.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnLaatzien_Click(object sender, EventArgs e)
        {

        }

        private void btnTrek_Click(object sender, EventArgs e)
        {
            if (!trekking.IsTenEinde) {
                trekking.TrekGetal();
                listBox.Items.Add(trekking.GeefGetal(trekking.AantalGetrokken - 1));
            } 
        }


        private void btnSerie_Click(object sender, EventArgs e)
        {

        }

        private void btnSorteer_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int maxWaarde = Convert.ToInt32(txtMaxwaarde.Text);
            int aantalGewenst = Convert.ToInt32(txtGewenst.Text);

            trekking = new Trekking(maxWaarde, aantalGewenst);

            btnTrek.Enabled = true;
            btnSerie.Enabled = true;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
