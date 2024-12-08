namespace Ferreteria
{
    partial class FormSalida
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
            this.txt_idEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grd_salida = new System.Windows.Forms.DataGridView();
            this.txt_cantidadSa = new System.Windows.Forms.TextBox();
            this.txt_tipoMaterialSa = new System.Windows.Forms.TextBox();
            this.txt_materialSa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_salida = new System.Windows.Forms.DateTimePicker();
            this.btn_volver2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_salida)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idEmpleado
            // 
            this.txt_idEmpleado.Location = new System.Drawing.Point(41, 334);
            this.txt_idEmpleado.Name = "txt_idEmpleado";
            this.txt_idEmpleado.Size = new System.Drawing.Size(183, 22);
            this.txt_idEmpleado.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Id del empleado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grd_salida
            // 
            this.grd_salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_salida.Location = new System.Drawing.Point(283, 67);
            this.grd_salida.Name = "grd_salida";
            this.grd_salida.RowHeadersWidth = 51;
            this.grd_salida.RowTemplate.Height = 24;
            this.grd_salida.Size = new System.Drawing.Size(610, 366);
            this.grd_salida.TabIndex = 22;
            // 
            // txt_cantidadSa
            // 
            this.txt_cantidadSa.Location = new System.Drawing.Point(41, 208);
            this.txt_cantidadSa.Name = "txt_cantidadSa";
            this.txt_cantidadSa.Size = new System.Drawing.Size(183, 22);
            this.txt_cantidadSa.TabIndex = 20;
            // 
            // txt_tipoMaterialSa
            // 
            this.txt_tipoMaterialSa.Location = new System.Drawing.Point(41, 147);
            this.txt_tipoMaterialSa.Name = "txt_tipoMaterialSa";
            this.txt_tipoMaterialSa.Size = new System.Drawing.Size(183, 22);
            this.txt_tipoMaterialSa.TabIndex = 19;
            // 
            // txt_materialSa
            // 
            this.txt_materialSa.Location = new System.Drawing.Point(41, 93);
            this.txt_materialSa.Name = "txt_materialSa";
            this.txt_materialSa.Size = new System.Drawing.Size(183, 22);
            this.txt_materialSa.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo de material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "fecha de salida";
            // 
            // dt_salida
            // 
            this.dt_salida.Location = new System.Drawing.Point(41, 278);
            this.dt_salida.Name = "dt_salida";
            this.dt_salida.Size = new System.Drawing.Size(200, 22);
            this.dt_salida.TabIndex = 29;
            // 
            // btn_volver2
            // 
            this.btn_volver2.Location = new System.Drawing.Point(156, 459);
            this.btn_volver2.Name = "btn_volver2";
            this.btn_volver2.Size = new System.Drawing.Size(85, 39);
            this.btn_volver2.TabIndex = 30;
            this.btn_volver2.Text = "Volver";
            this.btn_volver2.UseVisualStyleBackColor = true;
            // 
            // FormSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 506);
            this.Controls.Add(this.btn_volver2);
            this.Controls.Add(this.dt_salida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_idEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd_salida);
            this.Controls.Add(this.txt_cantidadSa);
            this.Controls.Add(this.txt_tipoMaterialSa);
            this.Controls.Add(this.txt_materialSa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSalida";
            this.Text = "FormSalida";
            ((System.ComponentModel.ISupportInitialize)(this.grd_salida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_idEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grd_salida;
        private System.Windows.Forms.TextBox txt_cantidadSa;
        private System.Windows.Forms.TextBox txt_tipoMaterialSa;
        private System.Windows.Forms.TextBox txt_materialSa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_salida;
        private System.Windows.Forms.Button btn_volver2;
    }
}