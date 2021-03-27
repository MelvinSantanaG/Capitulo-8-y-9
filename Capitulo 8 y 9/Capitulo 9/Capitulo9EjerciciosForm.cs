using Capitulo_8_y_9.Capitulo_9.Exercise_1;
using Capitulo_8_y_9.Capitulo_9.Exercise_3;
using Capitulo_8_y_9.Capitulo_9.Exercise_4;
using System.Windows.Forms;

namespace Capitulo_8_y_9.Capitulo_9
{
    public partial class Capitulo9EjerciciosForm : Form
    {
        public Capitulo9EjerciciosForm()
        {
            InitializeComponent();
        }

        private void Capitulo9Ejercicio1Button_Click(object sender, System.EventArgs e)
        {
            var Capitulo9 = new Capitulo9Ejercicio1();
            Capitulo9.Show();
        }

        private void Capitulo9Ejercicio3Button_Click(object sender, System.EventArgs e)
        {
            var Capitulo9 = new Capitulo9Ejercicio3();
            Capitulo9.Show();
        }

        private void Capitulo9Ejercicio4Button_Click(object sender, System.EventArgs e)
        {
            var Capitulo9 = new Capitulo9Ejercicio4();
            Capitulo9.Show();
        }
    }
}
