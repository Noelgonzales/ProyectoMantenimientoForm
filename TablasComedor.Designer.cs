namespace Mantenimiento_Chris
{
    partial class TablasComedor
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
            this.dgvcomedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcomedor
            // 
            this.dgvcomedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcomedor.Location = new System.Drawing.Point(0, 0);
            this.dgvcomedor.Name = "dgvcomedor";
            this.dgvcomedor.Size = new System.Drawing.Size(284, 261);
            this.dgvcomedor.TabIndex = 0;
            // 
            // TablasComedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvcomedor);
            this.Name = "TablasComedor";
            this.Text = "TablasComedor";
            this.Load += new System.EventHandler(this.TablasComedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcomedor;
    }
}