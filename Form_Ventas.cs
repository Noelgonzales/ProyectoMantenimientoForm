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
    public partial class Form_Ventas : Form
    {
        Conectar BDbase = new Conectar();
        public Form_Ventas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtcodigo.Clear();
            txtfechaventa.Clear();
            txtcodigo.Focus();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {

                BDbase.GuardarVentas(txtcodigo.Text,txtfechaventa.Text);
                MessageBox.Show("Venta Guardado en la BO");
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

                List<Ventas> li = new List<Ventas>();
                li = BDbase.EncontrarVentas(txtcodigo.Text);
                if (li.Count > 0)
                {
                    BDbase.ActualizarVentas(txtcodigo.Text, txtfechaventa.Text);
                }

                MessageBox.Show("Venta Modificada");

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
                if (txtcodigo.Text != "")
                {
                    List<Ventas> li = new List<Ventas>();
                    li = BDbase.EncontrarVentas(txtcodigo.Text);
                    if (li.Count > 0)
                    {
                        BDbase.EliminarVentas(txtcodigo.Text);
                        MessageBox.Show("Venta Eliminada..!!");
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
                if (txtcodigo.Text != "")
                {
                    List<Ventas> li = new List<Ventas>();
                    li = BDbase.EncontrarVentas(txtcodigo.Text);
                    if (li.Count > 0)
                    {
                        MessageBox.Show("Venta Encontrada");
                        foreach (var venta in li)
                        {
                            txtfechaventa.Text = venta.Fecha_Venta;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Venta No Encontrada..!!!, Crear Nueva");
                        txtcodigo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ingrese codigo antes de Buscar....!!!");
                    txtcodigo.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
