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
    public partial class Form_Empleado : Form
    {
        Conectar BDbase = new Conectar();
        public Form_Empleado()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtIdemple.Clear();
            txtpass.Clear();
            txttelefono.Clear();
            txtedad.Clear();
            txtDiastrabajdos.Clear();
            txtGenero.Clear();
            txtrol.Clear();
            txtnombre.Clear();
            txtsueldoDiario.Clear();
            txtIdemple.Focus();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int sueldodiario = Convert.ToInt32(txtsueldoDiario.Text);
                int diastrabajdos = Convert.ToInt32(txtDiastrabajdos.Text);
                BDbase.GuardarEmpleado(Convert.ToInt32(txtIdemple.Text), txtnombre.Text, Convert.ToInt32(txttelefono.Text),txtedad.Text, diastrabajdos, sueldodiario, Convert.ToInt32(txtplanilla.Text),txtpass.Text, txtGenero.Text, txtrol.Text);
                MessageBox.Show("Empleado Guardado en la BO");
                Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                int sueldodiario = Convert.ToInt32(txtsueldoDiario.Text);
                int diastrabajdos = Convert.ToInt32(txtDiastrabajdos.Text);
                List<Empleado> li = new List<Empleado>();
                li = BDbase.Encontrar(Convert.ToInt32(txtIdemple.Text));
                if (li.Count > 0)
                {
                    BDbase.ActualizarEmpleado(Convert.ToInt32(txtIdemple.Text), txtnombre.Text, Convert.ToInt32(txttelefono.Text), txtedad.Text, diastrabajdos, sueldodiario, Convert.ToInt32(txtplanilla.Text), txtpass.Text, txtGenero.Text, txtrol.Text);
                }

                MessageBox.Show("Empleado Modificado");
;            }   

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdemple.Text != "")
                {
                    List<Empleado> li = new List<Empleado>();
                    li = BDbase.Encontrar(Convert.ToInt32(txtIdemple.Text));
                    if (li.Count > 0)
                    {
                        BDbase.EliminarEmpleado(Convert.ToInt32(txtIdemple.Text));
                        MessageBox.Show("Empleado Eliminado..!!");
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Digite Codigo Para Eliminar");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdemple.Text != "")
                {
                    List<Empleado> li = new List<Empleado>();
                    li = BDbase.Encontrar(Convert.ToInt32(txtIdemple.Text));
                    if (li.Count > 0)
                    {
                        MessageBox.Show("Empleado Encontrado");
                        foreach (var emple in li)
                        {
                            txtnombre.Text = emple.Nombre_Empleado;
                            txttelefono.Text = emple.Telefono.ToString();
                            txtedad.Text = emple.Edad;
                           txtDiastrabajdos.Text = emple.Dias_trabajados.ToString();
                            txtsueldoDiario.Text = emple.Sueldo_Diario.ToString();
                            txtplanilla.Text = emple.Planilla_Neto.ToString();
                            txtpass.Text = emple.Contraseña;
                            txtGenero.Text = emple.Genero;
                            txtrol.Text=emple.Rol;
                        }
                    }
                    else
                    {
                        MessageBox.Show("empleado No Encontrado..!!!, Crear Nuevo");
                        txtnombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ingrese codigo antes de Buscar....!!!");
                    txtIdemple.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {

            int sueldodiario = Convert.ToInt32(txtsueldoDiario.Text);
            int diastrabajdos = Convert.ToInt32(txtDiastrabajdos.Text);
            int totalplanilla;

          totalplanilla = sueldodiario * diastrabajdos;

            txtplanilla.Text =Convert.ToString(totalplanilla.ToString());
        }

        private void Form_Empleado_Load(object sender, EventArgs e)
        {

        }
    }
}
