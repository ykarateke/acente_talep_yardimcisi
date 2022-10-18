using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acente_talep
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void güvenliÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Yazılım kapatılacak bunu yapmak istediğinize emin misiniz?", "Güvenli Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Yazılım kapatılacak bunu yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gerçekten programı kapatmak istiyor musunuz?", "Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}