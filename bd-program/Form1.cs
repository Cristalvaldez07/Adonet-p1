using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsDatos Datos = new clsDatos();

            dataGridView1.DataSource = Datos.consulta("SELECT Nombre, Status, Carrera, Ingreso , Genero, Direccion, Celular, Correo_electronico FROM Estudiantes");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(id))
            {
                string query = $"SELECT Nombre, Status, Carrera, Ingreso, Genero, Direccion, Celular, Correo_electronico FROM Estudiantes WHERE ID = '{id}'";
                clsDatos Datos = new clsDatos();
                dataGridView1.DataSource = Datos.consulta(query);
                dataGridView1.Visible = true; // Mostrar el DataGridView
            }
            else
            {
                dataGridView1.DataSource = null; // Limpiar los datos del DataGridView
                dataGridView1.Visible = false; // Ocultar el DataGridView
            }
        }
    }
}
