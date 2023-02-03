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
    public partial class Tarea1 : Form
    {
        public Tarea1()
        {
            InitializeComponent();
        }

        //Error
        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            if (NumTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(NumTextBox, "Escriba un número");
                return;
            }
            if (EjecutarButton.Text == String.Empty)
            {
                errorProvider1.SetError(NumTextBox, "Escriba un número");
                return;
            }
            errorProvider1.Clear();

            
            int Num = Convert.ToInt32(NumTextBox.Text);
            string R1, R2;

            //Llamar las funciones
            R1 = PoI(Num);
            PoITextBox.Text = R1;

            R2 = PoN(Num);
            PoNTextBox.Text = R2;
        }

        //Funcion de: Par o impar
        private string PoI(int num1)
        {
            string R;
            int PoI = num1 % 2;
            if (PoI == 0)
            {
                R = "Su número es par.";
            }
            else
            {
                R = "Su número es impar.";
            }
            return R;
        }

        //Funcion de: Positivo o Negativo
        private string PoN(int num1)
        {
            string R;
            if (num1 >= 0)
            {
                R = "Positivo";
            }
            else
            {
                R= "Negativo";
            }
            return R;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

