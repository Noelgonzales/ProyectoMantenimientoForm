namespace Mantenimiento_Chris
{
    partial class TablasDetalledeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDetalledeventa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalledeventa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalledeventa
            // 
            this.dgvDetalledeventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalledeventa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalledeventa.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalledeventa.Name = "dgvDetalledeventa";
            this.dgvDetalledeventa.Size = new System.Drawing.Size(284, 261);
            this.dgvDetalledeventa.TabIndex = 0;
            // 
            // TablasDetalledeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvDetalledeventa);
            this.Name = "TablasDetalledeVenta";
            this.Text = "TablasDetalledeVenta";
            this.Load += new System.EventHandler(this.TablasDetalledeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalledeventa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalledeventa;
    }
}