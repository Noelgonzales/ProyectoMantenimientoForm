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
    public partial class TablasEmpleados : Form
    {
        Conectar BD = new Conectar();
        public TablasEmpleados()
        {
            InitializeComponent();
        }

        private void TablasEmpleados_Load(object sender, EventArgs e)
        {
           try
            {
               dgvempleados.DataSource = BD.GetEmpleados() ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
