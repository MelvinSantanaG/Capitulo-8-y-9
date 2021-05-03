using System;
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

        public void Types()
        {
            tiposNeumaticos neumaticos = tiposNeumaticos.antiPincho;
            int option = Convert.ToInt32(NumberTextBox.Text);

            switch (option)
            {
                case 1:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.verano);
                    break;

                case 2:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.invierno);
                    break;

                case 3:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.deportivos);
                    break;

                case 4:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.dePista);
                    break;

                case 5:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.todoTerreno);
                    break;

                case 6:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.antiPincho);
                    break;

                case 7:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.todoTiempo);
                    break;

                case 8:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.otros);
                    break;

                default:
                    MessageBox.Show("Pruebe con un numero entre 1 y 8.");
                    break;
            }
        }

        private void DisplayButton_Click(object sender, System.EventArgs e)
        {
            Types();
        }
    }
}

