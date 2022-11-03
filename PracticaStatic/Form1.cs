using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado() { Nombre = "Juan", Apellido = "Rodriguez", Id = 1 };
            Empleado empleado2 = new Empleado() { Nombre = "Abril", Apellido = "Perez", Id = 2 };

            MessageBox.Show("Comision: " + Empleado.Comision.ToString());

            Empleado.Comision = 500;

            Empleado empleado3 = new Empleado() { Nombre = "Laura", Apellido = "Sanchez", Id = 3 };
            Empleado empleado4 = new Empleado() { Nombre = "Marcos", Apellido = "Quevedo", Id = 4 };

            MessageBox.Show("Comision: " + Empleado.Comision.ToString());

        }
    }
}
