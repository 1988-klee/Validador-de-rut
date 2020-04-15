using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rut._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string rut = textBox1.Text;
            if (rut.Length == 9)
            {
                rut = "0" + rut;

            }
            int n0, n1, n2, n3, n4, n5, n6, n7 = 0;
            n0 = 3 * Int32.Parse(rut[0].ToString());
            n1 = 2 * Int32.Parse(rut[1].ToString());
            n2 = 7 * Int32.Parse(rut[2].ToString());
            n3 = 6 * Int32.Parse(rut[3].ToString());
            n4 = 5 * Int32.Parse(rut[4].ToString());
            n5 = 4 * Int32.Parse(rut[5].ToString());
            n6 = 3 * Int32.Parse(rut[6].ToString());
            n7 = 2 * Int32.Parse(rut[7].ToString());

            double suma = 0;
            suma = n0 + n1 + n2 + n3 + n4 + n5 + n6 + n7;

            double divisiondecimal = 0;
            divisiondecimal = suma / 11;

            int divisionentero = 0;
            divisionentero = (int)divisiondecimal;

            double valordecimal = 0;
            valordecimal = divisiondecimal - divisionentero;
            
            double resta11 = 0;
            resta11 = 11 - (11 * (valordecimal));

            string digitoto = Convert.ToString((int)resta11);

            string digito = "";
            digito = digitoto;


            if (digito == "11")
            {
                digito = "0";
                MessageBox.Show("su digito corresponde " + digito, " y es correcto!!");

            }
            else if (digito == "10")
            {
                digito = "K";


            }        

           


            textBox2.Text = ""+ digito;












        }
    }
}
