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
    public partial class TablasVentas : Form
    {
        Conectar BD = new Conectar();
        public TablasVentas()
        {
            InitializeComponent();
        }
    

        private void TablasVentas_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = BD.GetVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
