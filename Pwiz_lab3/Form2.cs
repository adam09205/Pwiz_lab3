using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pwiz_lab3
{

    public partial class Form2 : Form
    {
        private Form1 okno1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.okno1 = form1;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            okno1.dodawanie(imie.Text, nazw.Text, wiek.Value ,stanowisko.Text);
            this.Close();
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
