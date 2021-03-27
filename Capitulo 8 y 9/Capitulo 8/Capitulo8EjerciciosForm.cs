using Capitulo_8_y_9.Capitulo_8.Exercise_3;
using Capitulo_8_y_9.Capitulo_8.Exercise_5;
using System.Windows.Forms;

namespace Capitulo_8_y_9.Capitulo_8
{
    public partial class Capitulo8EjerciciosForm : Form
    {
        public Capitulo8EjerciciosForm()
        {
            InitializeComponent();
        }

        private void Chapter8Exercise3Button_Click(object sender, System.EventArgs e)
        {
            var Ejercicio3Capitulo8 = new Capitulo8Ejercicio3();
            Ejercicio3Capitulo8.Show();
        }

        private void Chapter8Exercise5Button_Click(object sender, System.EventArgs e)
        {
            var Ejercicio5Capitulo8 = new Capitulo8Ejercicio5();
            Ejercicio5Capitulo8.Show();
        }
    }
}
