using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ucenik> ucenici = new List<ucenik>();
            ucenik a = new ucenik("Pero", "PLankos", 1, "754385743895");
            ucenik b = new ucenik("Kurdon", "Montogram", 1, "754385743895");
            ucenik c = new ucenik("KLompurgon", "Amporgan", 1, "754385743895");

            ucenici.Add(a);
            ucenici.Add(b);
            ucenici.Add(c);

            foreach(ucenik u in ucenici)
            {
                lbUcenik1.Items.Add(u);
            }

        }

        private void lbUcenik1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
