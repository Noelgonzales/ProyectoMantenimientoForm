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
    public partial class Form_Detalle_Venta : Form
    {
        Conectar BDbase = new Conectar();
        public Form_Detalle_Venta()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtcodigo_venta.Clear();
            txtIDplatillo.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            txtcodigo_venta.Focus();

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                BDbase.GuardarDetalledeventa(txtcodigo_venta.Text, txtIDplatillo.Text, txtprecio.Text, Convert.ToInt32(txtcantidad.Text));
                MessageBox.Show("Detalledeventa Guardado en la BO");
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

                List<DetalleVenta> li = new List<DetalleVenta>();
                li = BDbase.EncontrarDetalleventa(txtcodigo_venta.Text);
                if (li.Count > 0)
                {
                    BDbase.ActualizarDetalledeventa(txtcodigo_venta.Text, txtIDplatillo.Text, txtprecio.Text, Convert.ToInt32(txtcantidad.Text));
                }

                MessageBox.Show("Detalle de Venta Modificado");
                ;
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
                if (txtcodigo_venta.Text != "")
                {
                    List<DetalleVenta> li = new List<DetalleVenta>();
                    li = BDbase.EncontrarDetalleventa(txtcodigo_venta.Text);
                    if (li.Count > 0)
                    {
                        BDbase.Eliminardetalle (txtcodigo_venta.Text);
                        MessageBox.Show("Detalle de venta Eliminado..!!");
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
                if (txtcodigo_venta.Text != "")
                {
                    List<DetalleVenta> li = new List<DetalleVenta>();
                    li = BDbase.EncontrarDetalleventa(txtcodigo_venta.Text);
                    if (li.Count > 0)
                    {
                        MessageBox.Show("Detalle de venta Encontrado");
                        foreach (var detalle in li)
                        {
                           txtIDplatillo.Text = detalle.IDplatillo;
                            txtprecio.Text = detalle.Precio;
                            txtcantidad.Text = detalle.Cantidad.ToString();

                        }
                    }
                    else
                    {
                        MessageBox.Show("detalle de venta No Encontrado..!!!, Crear Nuevo");
                        txtcodigo_venta.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ingrese codigo antes de Buscar....!!!");
                    txtcodigo_venta.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
