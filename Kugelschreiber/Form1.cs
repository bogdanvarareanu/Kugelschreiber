using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kugelschreiber
{
    public partial class Form1 : Form
    {
        private CKugelschreiber Kulli = new CKugelschreiber();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kulli.set_Mienenstellung(false);
            Kulli.set_Tintenstand(100);
            checkBox1.Checked = Kulli.get_Mienenstellung();
            progressBar1.Value = Kulli.get_Tintenstand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kulli.Kappe_drehen();
            checkBox1.Checked = Kulli.get_Mienenstellung();
            progressBar1.Value = Kulli.get_Tintenstand();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Kulli.schreiben(Convert.ToInt32(textBox1.Text)))
                label3.Text = "Schreiben erfolgreich";
            else
                label3.Text = " Schreiben nicht erfolgreich";
            checkBox1.Checked = Kulli.get_Mienenstellung();
            progressBar1.Value = Kulli.get_Tintenstand();
        }
    }
}
