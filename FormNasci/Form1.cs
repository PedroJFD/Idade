using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormNasci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = datenasc.Value;

            if (data < DateTime.Now)
            {
                int idade = DateTime.Now.Year - data.Year;

                if (DateTime.Now.Month < data.Month || (DateTime.Now.Month == data.Month && DateTime.Now.Day < data.Day))
                {
                    idade = idade - 1;
                    label1.Text = idade.ToString();
                }
                else
                {
                    label1.Text = idade.ToString();
                }
            }
            else
            {
                label1.Text = "Idade fornecida incorreta!";
            }
        }
    }
}
