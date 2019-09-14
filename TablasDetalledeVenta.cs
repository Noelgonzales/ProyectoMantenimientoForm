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
    public partial class TablasDetalledeVenta : Form
    {
        Conectar BD = new Conectar();
        public TablasDetalledeVenta()
        {
            InitializeComponent();
        }
        
        private void TablasDetalledeVenta_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDetalledeventa.DataSource = BD.GetDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
