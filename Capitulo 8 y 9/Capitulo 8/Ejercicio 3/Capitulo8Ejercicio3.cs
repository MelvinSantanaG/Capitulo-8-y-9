using System;
using System.Windows.Forms;

namespace Capitulo_8_y_9.Capitulo_8.Exercise_3
{
    public partial class Capitulo8Ejercicio3 : Form
    {
        public Capitulo8Ejercicio3()
        {
            InitializeComponent();
        }

        private void DateButton_Click(object sender, EventArgs e)
        {

            /*3 Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.*/

            DateTime date = DateTime.Today;
            string format = "dddd MMMM yyyy d, hh mm";
            ResultadoLabel.Text = date.ToString(format);

        }
    }
}
