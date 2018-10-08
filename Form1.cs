using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İmageprocess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renkGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkFormu = new Form2();
            renkFormu.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void griYöntemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 griFormu = new Form3();
            griFormu.ShowDialog();
        }

        private void kanalSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 kanalFormu = new Form4();
            kanalFormu.ShowDialog();
        }


    }
}