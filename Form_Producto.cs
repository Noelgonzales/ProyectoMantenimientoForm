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
    public partial class Form_Producto : Form
    {
        Conectar BDbase = new Conectar();
        public Form_Producto()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtcodigo_producto.Clear();
            txtnombre.Clear();
            txtcantidadProducto.Clear();
            txtcodigo_producto.Focus();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                BDbase.GuardarProductos(Convert.ToInt32(txtcodigo_producto.Text), txtnombre.Text, Convert.ToInt32(txtcantidadProducto.Text));
                MessageBox.Show("Producto Guardado en la BO");
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

                List<Producto> li = new List<Producto>();
                li = BDbase.EncontrarProducto(Convert.ToInt32(txtcodigo_producto.Text));
                if (li.Count > 0)
                {
                    BDbase.ActualizarProducto(Convert.ToInt32(txtcodigo_producto.Text), txtnombre.Text, Convert.ToInt32(txtcantidadProducto.Text));
                }

                MessageBox.Show("Producto Modificado");

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
                if (txtcodigo_producto.Text != "")
                {
                    List<Producto> li = new List<Producto>();
                    li = BDbase.EncontrarProducto(Convert.ToInt32(txtcodigo_producto.Text));
                    if (li.Count > 0)
                    {
                        BDbase.EliminarInvetario(txtcodigo_producto.Text);
                        MessageBox.Show("Producto Eliminado..!!");
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
                if (txtcodigo_producto.Text != "")
                {
                    List<Producto> li = new List<Producto>();
                    li = BDbase.EncontrarProducto(Convert.ToInt32 (txtcodigo_producto.Text));
                    if (li.Count > 0)
                    {
                        MessageBox.Show("Producto Encontrado");
                        foreach (var producto in li)
                        {
                            txtnombre.Text = producto.Nombre_Producto;
                            txtcantidadProducto.Text = producto.Cantidad_Producto.ToString();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Producto No Encontrado..!!!, Crear Nuevo");
                        txtcodigo_producto.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ingrese codigo antes de Buscar....!!!");
                    txtcodigo_producto.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
