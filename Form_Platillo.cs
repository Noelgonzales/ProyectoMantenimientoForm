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
    public partial class Form_Platillo : Form
    {
        Conectar BDbase = new Conectar();
        public Form_Platillo()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtIDplatillo.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            txtIDplatillo.Focus();

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                BDbase.GuardarPlatillo(Convert.ToInt32 (txtIDplatillo.Text), txtnombre.Text, Convert.ToInt32(txtprecio.Text));
                MessageBox.Show("Platillo Guardado en la BO");
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

                List<Platillo> li = new List<Platillo>();
                li = BDbase.EncontrarPlatillo(Convert.ToInt32(txtIDplatillo.Text));
                if (li.Count > 0)
                {
                    BDbase.ActualizarPlatillo(Convert.ToInt32(txtIDplatillo.Text), txtnombre.Text, Convert.ToInt32(txtprecio.Text));
                }

                MessageBox.Show("Platillo Modificado");
                
                }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDplatillo.Text != "")
                {
                    List<Platillo> li = new List<Platillo>();
                    li = BDbase.EncontrarPlatillo(Convert.ToInt32(txtIDplatillo.Text));
                    if (li.Count > 0)
                    {
                        BDbase.EliminarPlatillo(Convert.ToInt32(txtIDplatillo.Text));
                        MessageBox.Show("Platillo Eliminado..!!");
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
                if (txtIDplatillo.Text != "")
                {
                    List<Platillo> li = new List<Platillo>();
                    li = BDbase.EncontrarPlatillo(Convert.ToInt32(txtIDplatillo.Text));
                    if (li.Count > 0)
                    {
                        MessageBox.Show("Platillo Encontrado");
                        foreach (var platillo in li)
                        {
                            txtnombre.Text = platillo.Nombre_Platillo;
                            txtprecio.Text = platillo.Precio.ToString();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Platillo No Encontrado..!!!, Crear Nuevo");
                        txtIDplatillo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ingrese codigo antes de Buscar....!!!");
                    txtIDplatillo.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Platillo_Load(object sender, EventArgs e)
        {

        }
    }
}
