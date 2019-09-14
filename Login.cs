using Conexion1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Chris
{
    public partial class Login : Form
    {
        Conectar BDbase = new Conectar();
        ConexionComedorEntities Base1 = new ConexionComedorEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(txtID.Text.Trim());
                string pass = txtPass.Text.Trim();
                bool encontrado = false;

                encontrado = BDbase.Validar(cod, pass);
                if (encontrado)
                {
                   
                    MessageBox.Show("Credenciales Correctas : bienvenido"); 
                    Menu_Principal Mn = new Menu_Principal();
                    Mn.WindowState = FormWindowState.Maximized; //Maximiza la ventada
                    Mn.Show();// muestra ambas ventanas
                    this.Hide();
                    //Mn.ShowDialog();//muetra solo una ventana y la otra trabaja

                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas");
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Empleado Mn = new Form_Empleado();
            Mn.Show();// muestra ambas ventanas
        
        }
    }
}
