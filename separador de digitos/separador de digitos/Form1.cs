using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace separador_de_digitos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Texto = textBox1.Text;
            int largotexto = Texto.Length;

            int[] arre1; int i = 0;
            arre1 = new int[largotexto];
            int num = 0; string caracter = "";
            for (i = 0; i < largotexto; i++)
            {
                caracter = Texto[i].ToString();
                num = Int32.Parse(caracter);
                arre1[i] = num;
            }
            int suma = 0; int menor = 9;
            int mayor = 0; double promedio = 0;
            for(i=0; i<largotexto; i++)
            {
                suma = suma + arre1[i];
                if(mayor < arre1[i])
                {
                    mayor = arre1[i];
                }
                if(menor > arre1[i])
                {
                    menor = arre1[i];
                }
            }
            promedio = suma / i;
            textBox1.Text = "ingrese numero: ";
                for (i = 0; i < largotexto; i++)
            {
                textBox1.Text = textBox1.Text + arre1[i];
            }
            textBox1.Text = textBox1.Text + (char)13;
            textBox1.Text = textBox1.Text +
                "suma :" = suma.ToString() + (char)13 +
                "menor :" = menor.ToString() + (char)13 +
                "mayor :" = mayor.ToString() + (char)13 +
                "promedio :" = suma.ToString();
        }
    }
}
