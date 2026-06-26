using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregarPracticaJunio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoVehiculo.Items.Add("Motocicleta");
            cmbTipoVehiculo.Items.Add("Automovil");
            cmbTipoVehiculo.Items.Add("Camioneta");
            cmbTipoVehiculo.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtHoras.Text, out int horas) || horas <= 0)
            {
                MessageBox.Show("Ingrese horas válidas.");
                return;
            }

            Vehiculo vehiculo;

            if (cmbTipoVehiculo.Text == "Motocicleta")
            {
                vehiculo = new Motocicleta(horas, 150);
            }

            else if (cmbTipoVehiculo.Text == "Automovil")
            {
                vehiculo = new Automovil(horas, "ABC-123");
            }
            else
                vehiculo = new Camioneta(horas, 2);

            lblResultado.Text = "Total a pagar: $" + vehiculo.CalcularTarifa();
        }

    }   
}
