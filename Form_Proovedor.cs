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
    public partial class Form_Proovedor : Form
    {
        Conectar BDbase = new Conectar();
        public Form_Proovedor()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtnumero.Clear();
            txtfecha.Clear();
            txtcodigo.Focus();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                BDbase.GuardarProovedor(Convert.ToInt32(txtcodigo.Text), txtnombre.Text, Convert.ToInt32(txtnumero.Text),txtfecha.Text);
                MessageBox.Show("Proovedor Guardado en la BO");
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

                List<Proovedores> li = new List<Proovedores>();
                li = BDbase.EncontrarProovedor(Convert.ToInt32(txtcodigo.Text));
                if (li.Count > 0)
                {
                    BDbase.ActualizarProovedor(Convert.ToInt32(txtcodigo.Text), txtnombre.Text, Convert.ToInt32(txtnumero.Text), txtfecha.Text);
                }

                MessageBox.Show("Proovedor Modificado");

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
                    List<Proovedores> li = new List<Proovedores>();
                    li = BDbase.EncontrarProovedor(Convert.ToInt32(txtcodigo.Text));
                    if (li.Count > 0)
                    {
                        BDbase.EliminarProovedor(Convert.ToInt32(txtcodigo.Text));
                        MessageBox.Show("Proovedor Eliminado..!!");
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
                    List<Proovedores> li = new List<Proovedores>();
                    li = BDbase.EncontrarProovedor(Convert.ToInt32(txtcodigo.Text));
                    if (li.Count > 0)
                    {
                        MessageBox.Show("Proovedor Encontrado");
                        foreach (var proovedor in li)
                        {
                            txtnombre.Text = proovedor.Nombre_Provedor;
                            txtnumero.Text = proovedor.Numero_Pedido.ToString();
                            txtfecha.Text = proovedor.Fecha_Entrega;


                        }
                    }
                    else
                    {
                        MessageBox.Show("Proovedor No Encontrado..!!!, Crear Nuevo");
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
