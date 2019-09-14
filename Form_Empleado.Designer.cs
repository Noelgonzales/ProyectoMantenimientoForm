namespace Mantenimiento_Chris
{
    partial class Form_Empleado
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdemple = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtrol = new System.Windows.Forms.TextBox();
            this.txtDiastrabajdos = new System.Windows.Forms.TextBox();
            this.txtsueldoDiario = new System.Windows.Forms.TextBox();
            this.txtplanilla = new System.Windows.Forms.TextBox();
            this.Btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(244, 13);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(241, 256);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 16;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(159, 256);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(77, 257);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre del Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sueldo Diario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dias trabajados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total planilla";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Genero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Rol";
            // 
            // txtIdemple
            // 
            this.txtIdemple.Location = new System.Drawing.Point(100, 13);
            this.txtIdemple.Name = "txtIdemple";
            this.txtIdemple.Size = new System.Drawing.Size(100, 20);
            this.txtIdemple.TabIndex = 28;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(100, 40);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 29;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(143, 67);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(280, 20);
            this.txtnombre.TabIndex = 30;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(81, 101);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 31;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(278, 100);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 32;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(81, 138);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 33;
            // 
            // txtrol
            // 
            this.txtrol.Location = new System.Drawing.Point(278, 137);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(100, 20);
            this.txtrol.TabIndex = 34;
            // 
            // txtDiastrabajdos
            // 
            this.txtDiastrabajdos.Location = new System.Drawing.Point(112, 189);
            this.txtDiastrabajdos.Name = "txtDiastrabajdos";
            this.txtDiastrabajdos.Size = new System.Drawing.Size(100, 20);
            this.txtDiastrabajdos.TabIndex = 35;
            // 
            // txtsueldoDiario
            // 
            this.txtsueldoDiario.Location = new System.Drawing.Point(316, 189);
            this.txtsueldoDiario.Name = "txtsueldoDiario";
            this.txtsueldoDiario.Size = new System.Drawing.Size(100, 20);
            this.txtsueldoDiario.TabIndex = 36;
            // 
            // txtplanilla
            // 
            this.txtplanilla.Enabled = false;
            this.txtplanilla.Location = new System.Drawing.Point(187, 225);
            this.txtplanilla.Name = "txtplanilla";
            this.txtplanilla.Size = new System.Drawing.Size(100, 20);
            this.txtplanilla.TabIndex = 37;
            // 
            // Btncalcular
            // 
            this.Btncalcular.Location = new System.Drawing.Point(316, 223);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(75, 23);
            this.Btncalcular.TabIndex = 38;
            this.Btncalcular.Text = "Calcular";
            this.Btncalcular.UseVisualStyleBackColor = true;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // Form_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 292);
            this.Controls.Add(this.Btncalcular);
            this.Controls.Add(this.txtplanilla);
            this.Controls.Add(this.txtsueldoDiario);
            this.Controls.Add(this.txtDiastrabajdos);
            this.Controls.Add(this.txtrol);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtIdemple);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Empleado";
            this.Load += new System.EventHandler(this.Form_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdemple;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.TextBox txtDiastrabajdos;
        private System.Windows.Forms.TextBox txtsueldoDiario;
        private System.Windows.Forms.TextBox txtplanilla;
        private System.Windows.Forms.Button Btncalcular;
    }
}