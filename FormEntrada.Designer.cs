namespace Ferreteria
{
    partial class frm_entrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_material = new System.Windows.Forms.TextBox();
            this.txt_tipoMaterial = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.grd_entrada = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_idEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_entrada = new System.Windows.Forms.DateTimePicker();
            this.btn_volver1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_entrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor";
            // 
            // txt_material
            // 
            this.txt_material.Location = new System.Drawing.Point(52, 63);
            this.txt_material.Name = "txt_material";
            this.txt_material.Size = new System.Drawing.Size(183, 22);
            this.txt_material.TabIndex = 4;
            // 
            // txt_tipoMaterial
            // 
            this.txt_tipoMaterial.Location = new System.Drawing.Point(52, 117);
            this.txt_tipoMaterial.Name = "txt_tipoMaterial";
            this.txt_tipoMaterial.Size = new System.Drawing.Size(183, 22);
            this.txt_tipoMaterial.TabIndex = 5;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(52, 178);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(183, 22);
            this.txt_cantidad.TabIndex = 6;
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(52, 234);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(183, 22);
            this.txt_proveedor.TabIndex = 7;
            // 
            // grd_entrada
            // 
            this.grd_entrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_entrada.Location = new System.Drawing.Point(294, 63);
            this.grd_entrada.Name = "grd_entrada";
            this.grd_entrada.RowHeadersWidth = 51;
            this.grd_entrada.RowTemplate.Height = 24;
            this.grd_entrada.Size = new System.Drawing.Size(610, 366);
            this.grd_entrada.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_idEmpleado
            // 
            this.txt_idEmpleado.Location = new System.Drawing.Point(56, 407);
            this.txt_idEmpleado.Name = "txt_idEmpleado";
            this.txt_idEmpleado.Size = new System.Drawing.Size(183, 22);
            this.txt_idEmpleado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id del empleado";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(52, 291);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(183, 22);
            this.txt_costo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Costo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "fecha de entrada";
            // 
            // dt_entrada
            // 
            this.dt_entrada.Location = new System.Drawing.Point(52, 350);
            this.dt_entrada.Name = "dt_entrada";
            this.dt_entrada.Size = new System.Drawing.Size(200, 22);
            this.dt_entrada.TabIndex = 30;
            // 
            // btn_volver1
            // 
            this.btn_volver1.Location = new System.Drawing.Point(167, 455);
            this.btn_volver1.Name = "btn_volver1";
            this.btn_volver1.Size = new System.Drawing.Size(85, 39);
            this.btn_volver1.TabIndex = 31;
            this.btn_volver1.Text = "Volver";
            this.btn_volver1.UseVisualStyleBackColor = true;
            // 
            // frm_entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 506);
            this.Controls.Add(this.btn_volver1);
            this.Controls.Add(this.dt_entrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_idEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd_entrada);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_tipoMaterial);
            this.Controls.Add(this.txt_material);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_entrada";
            this.Text = "FormEntrada";
            ((System.ComponentModel.ISupportInitialize)(this.grd_entrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_material;
        private System.Windows.Forms.TextBox txt_tipoMaterial;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.DataGridView grd_entrada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_idEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_entrada;
        private System.Windows.Forms.Button btn_volver1;
    }
}