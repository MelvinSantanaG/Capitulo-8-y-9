using System;
using System.Windows.Forms;

namespace Capitulo_8_y_9.Capitulo_9.Exercise_1
{
    public partial class Capitulo9Ejercicio1 : Form
    {
        public Capitulo9Ejercicio1()
        {
            InitializeComponent();
        }

        /*1 Crear una estructura para guardar los productos de una tienda.*/
        public struct Products
        {
            public string name;
            public double price;

            public Products(string Name, double Price)
            {
                name = Name;
                price = Price;
            }
        }

        readonly Products[] products = new Products[10];
        int accumulator;

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            products[accumulator].name = NameTextBox.Text;
            products[accumulator].price = Convert.ToDouble(PriceTextBox.Text);
            accumulator++;
        }
    }
}

