using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.CODPRODUCTO = Int32.Parse(textBox1.Text.Trim());
            producto.CODIGOBAR = textBox2.Text;

            label3.Text = "Codigo producto " + producto.CODPRODUCTO + "\n";
            label3.Text += "Codigo de Barra " + producto.CODIGOBAR + "\n";

        }
    }
}
