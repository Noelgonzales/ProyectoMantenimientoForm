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
    public partial class Form_Comedor : Form
    {
        Conectar BDbase = new Conectar();
        public Form_Comedor()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtID.Clear();
            txtnombre.Clear();
            txtID.Focus();

        }
        private void Form_Comedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                BDbase.GuardarComedor(txtID.Text,txtnombre.Text);
                MessageBox.Show("Comedor Guardado en la BO");
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
                
                List<Comedor> li = new List<Comedor>();
                li = BDbase.EncontrarComedor(txtID.Text);
                if (li.Count > 0)
                {
                    BDbase.ActualizarComedor(txtID.Text, txtnombre.Text);
                }

                MessageBox.Show("Comedor Modificado");
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
                if (txtID.Text != "")
                {
                    List<Comedor> li = new List<Comedor>();
                    li = BDbase.EncontrarComedor(txtID.Text);
                    if (li.Count > 0)
                    {
                        BDbase.EliminarComedor(txtID.Text);
                        MessageBox.Show("Comedor Eliminado..!!");
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
                if (txtID.Text != "")
                {
                    List<Comedor> li = new List<Comedor>();
                    li = BDbase.EncontrarComedor(txtID.Text);
                    if (li.Count > 0)
                    {
                        MessageBox.Show("Comedor Encontrado");
                        foreach (var come in li)
                        {
                           txtnombre.Text = come.Nombre_Comedor;
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Comedor No Encontrado..!!!, Crear Nuevo");
                        txtnombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ingrese codigo antes de Buscar....!!!");
                    txtID.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

