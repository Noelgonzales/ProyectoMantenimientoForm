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
    public partial class TablasComedor : Form
    {
        Conectar BD = new Conectar();
        public TablasComedor()
        {
            InitializeComponent();
        }
      
        private void TablasComedor_Load(object sender, EventArgs e)
        {

            try
            {
                dgvcomedor.DataSource = BD.GetComedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
