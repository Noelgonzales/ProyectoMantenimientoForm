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
    public partial class TablasPlatillo : Form
    {
        Conectar BD = new Conectar();
        public TablasPlatillo()
        {
            InitializeComponent();
        }

      
        private void TablasPlatillo_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = BD.GetPlatillo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
