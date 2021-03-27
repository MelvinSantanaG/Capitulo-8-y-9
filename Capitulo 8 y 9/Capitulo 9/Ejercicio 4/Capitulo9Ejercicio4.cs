using System.Windows.Forms;

namespace Capitulo_8_y_9.Capitulo_9.Exercise_4
{
    public partial class Capitulo9Ejercicio4 : Form
    {
        public Capitulo9Ejercicio4()
        {
            InitializeComponent();
        }

        /*4 Crear una enumeración para los diferentes tipos de neumáticos.*/
        enum tiposNeumaticos { verano, invierno, deportivos, dePista, todoTerreno, antiPincho, todoTiempo, otros }

        /*public void Tipos()
        {
            tiposNeumaticos neumaticos = tiposNeumaticos.antiPincho;
            int opcion = Convert.ToInt32(NumeroTextBox.Text);

            switch (opcion)
            {
                case 1:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.verano);
                    break;

                case 2:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.invierno);
                    break;

                case 3:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.deportivos);
                    break;

                case 4:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.dePista);
                    break;

                case 5:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.todoTerreno);
                    break;

                case 6:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.antiPincho);
                    break;

                case 7:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.todoTiempo);
                    break;

                case 8:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.otros);
                    break;

                default:
                    MessageBox.Show("Pruebe con un numero entre 1 y 8.");
                    break;
            }
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Tipos();
        }*/
    }
}

