namespace Mantenimiento_Chris
{
    partial class TablasEmpleados
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
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvempleados
            // 
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvempleados.Location = new System.Drawing.Point(0, 0);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.Size = new System.Drawing.Size(284, 261);
            this.dgvempleados.TabIndex = 0;
            // 
            // TablasEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvempleados);
            this.Name = "TablasEmpleados";
            this.Text = "TablasEmpleados";
            this.Load += new System.EventHandler(this.TablasEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvempleados;
    }
}