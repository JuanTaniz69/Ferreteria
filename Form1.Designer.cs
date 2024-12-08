namespace Ferreteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_ReEnt = new System.Windows.Forms.Button();
            this.btn_ReSa = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ReEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(34, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(153, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Seleccione la operacion";
            // 
            // btn_ReEnt
            // 
            this.btn_ReEnt.Location = new System.Drawing.Point(47, 89);
            this.btn_ReEnt.Name = "btn_ReEnt";
            this.btn_ReEnt.Size = new System.Drawing.Size(140, 42);
            this.btn_ReEnt.TabIndex = 1;
            this.btn_ReEnt.Text = "Registrar entrada";
            this.btn_ReEnt.UseVisualStyleBackColor = true;
            this.btn_ReEnt.Click += new System.EventHandler(this.btn_ReEnt_Click);
            // 
            // btn_ReSa
            // 
            this.btn_ReSa.Location = new System.Drawing.Point(47, 149);
            this.btn_ReSa.Name = "btn_ReSa";
            this.btn_ReSa.Size = new System.Drawing.Size(140, 39);
            this.btn_ReSa.TabIndex = 2;
            this.btn_ReSa.Text = "Registrar Salida";
            this.btn_ReSa.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(199, 283);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_ReEmpleado
            // 
            this.btn_ReEmpleado.Location = new System.Drawing.Point(47, 210);
            this.btn_ReEmpleado.Name = "btn_ReEmpleado";
            this.btn_ReEmpleado.Size = new System.Drawing.Size(140, 39);
            this.btn_ReEmpleado.TabIndex = 4;
            this.btn_ReEmpleado.Text = "Registrar Empleado";
            this.btn_ReEmpleado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 328);
            this.Controls.Add(this.btn_ReEmpleado);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ReSa);
            this.Controls.Add(this.btn_ReEnt);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_ReEnt;
        private System.Windows.Forms.Button btn_ReSa;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ReEmpleado;
    }
}

