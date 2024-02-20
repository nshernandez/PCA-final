using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PCA_final
{
    public partial class Form2 : Form
    {
        private object radioButton41;

        public Form2()
        {
            InitializeComponent();
        }
        public class Vehiculo
        {
            public string Modelo { get; set; }
            public string Marca { get; set; }
            public string Color { get; set; }
            public string Placa { get; set; }

            public Vehiculo(string modelo, string marca, string color, string placa)
            {
                Modelo = modelo;
                Marca = marca;
                Color = color;
                Placa = placa;
            }
        }

        public class Cliente(string nombre, string apellido, string cedula, string telefono, DateTime horaEntrada, DateTime fechaEntrada, Form2.Vehiculo vehiculo)
        {
            public string Nombre { get; set; } = nombre;
            public string Apellido { get; set; } = apellido;
            public string Cedula { get; set; } = cedula;
            public string Telefono { get; set; } = telefono;

            public DateTime HoraEntrada { get; set; } = horaEntrada;

            public DateTime FechaEntrada { get; set; } = fechaEntrada;

            public Vehiculo Vehiculo { get; set; } = vehiculo;

            internal static void Add(Cliente cliente)
            {
                throw new NotImplementedException();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string cedula = textBox3.Text;
            string telefono = textBox4.Text;
            DateTime horaEntrada = DateTime.Now;
            DateTime fechaEntrada = DateTime.Now;

            Vehiculo vehiculo = null;
            if (radioButton4.Checked)
            {
                string modelo = textBox8.Text;
                string marca = textBox6.Text;
                string color = textBox5.Text;
                string placa = textBox9.Text;

                vehiculo = new Vehiculo(modelo, marca, color, placa);

            }


            Cliente cliente = new Cliente(nombre, apellido, cedula, telefono, horaEntrada, fechaEntrada, vehiculo);
            Cliente.Add(cliente);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();   

        }
    }
} 


