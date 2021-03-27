using Capitulo_8_y_9.Capitulo_8;
using Capitulo_8_y_9.Capitulo_9;
using System;
using System.Windows.Forms;

namespace Capitulo_8_y_9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Capitulo8Button_Click(object sender, EventArgs e)
        {
            var Menu = new Capitulo8EjerciciosForm();
            Menu.Show();
        }

        private void Capitulo9Button_Click(object sender, EventArgs e)
        {
            var Menu = new Capitulo9EjerciciosForm();
            Menu.Show();
        }
    }
}
