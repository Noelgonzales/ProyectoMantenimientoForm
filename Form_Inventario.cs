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
    public partial class Form_Inventario : Form
    {
        Conectar BDbase = new Conectar();
        public Form_Inventario()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtcodigo_producto.Clear();
            txtnombre.Clear();
            txtcantidad.Clear();
            txtcodigo_producto.Focus();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                BDbase.Guardarinventario(txtcodigo_producto.Text,txtnombre.Text,Convert.ToInt32(txtcantidad.Text));
                MessageBox.Show("Inventario Guardado en la BO");
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

                List<Inventario> li = new List<Inventario>();
                li = BDbase.EncontrarInventario(txtcodigo_producto.Text);
                if (li.Count > 0)
                {
                    BDbase.ActualizarInventario(txtcodigo_producto.Text, txtnombre.Text, Convert.ToInt32(txtcantidad.Text));
                }

                MessageBox.Show("Inventario Modificado");
                
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
                    List<Inventario> li = new List<Inventario>();
                    li = BDbase.EncontrarInventario(txtcodigo_producto.Text);
                    if (li.Count > 0)
                    {
                        BDbase.EliminarInvetario(txtcodigo_producto.Text);
                        MessageBox.Show("Inventario Eliminado..!!");
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
                    List<Inventario> li = new List<Inventario>();
                    li = BDbase.EncontrarInventario(txtcodigo_producto.Text);
                    if (li.Count > 0)
                    {
                        MessageBox.Show("inventario Encontrado");
                        foreach (var inventario in li)
                        {
                            txtnombre.Text = inventario.Nombre_producto;
                            txtcantidad.Text = inventario.cantidad_Existente.ToString();
                           

                        }
                    }
                    else
                    {
                        MessageBox.Show("Inventario No Encontrado..!!!, Crear Nuevo");
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
