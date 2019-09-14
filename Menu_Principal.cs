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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Empleado ne = new Form_Empleado();
            ne.MdiParent = this;
            ne.Show();
        }

        private void comedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Comedor ne = new Form_Comedor();
            ne.MdiParent = this;
            ne.Show();
        }

        private void proovedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Proovedor ne = new Form_Proovedor();
            ne.MdiParent = this;
            ne.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ventas ne = new Form_Ventas();
            ne.MdiParent = this;
            ne.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Inventario ne = new Form_Inventario();
            ne.MdiParent = this;
            ne.Show();
        }

        private void platilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Platillo ne = new Form_Platillo();
            ne.MdiParent = this;
            ne.Show();
        }

        private void detalleVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Detalle_Venta ne = new Form_Detalle_Venta();
            ne.MdiParent = this;
            ne.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Producto ne = new Form_Producto();
            ne.MdiParent = this;
            ne.Show();
        }

        private void comedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TablasComedor le = new TablasComedor();
            le.MdiParent = this;
            le.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TablasEmpleados le = new TablasEmpleados();
            le.MdiParent = this;
            le.Show();
        }

        private void proovedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TablasProovedor le = new TablasProovedor();
            le.MdiParent = this;
            le.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TablasVentas le = new TablasVentas();
            le.MdiParent = this;
            le.Show();
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablasInventarios le = new TablasInventarios();
            le.MdiParent = this;
            le.Show();
        }

        private void platillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablasPlatillo le = new TablasPlatillo();
            le.MdiParent = this;
            le.Show();
        }

        private void detalleVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablasDetalledeVenta le = new TablasDetalledeVenta();
            le.MdiParent = this;
            le.Show();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TablasProductos le = new TablasProductos();
            le.MdiParent = this;
            le.Show();
        }
    }
}
