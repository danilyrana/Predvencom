namespace Predven
{
    partial class FrmGraficas
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
            this.btnGrVentasProducto = new System.Windows.Forms.Button();
            this.btnGrVentasporMes = new System.Windows.Forms.Button();
            this.btnGrInventario = new System.Windows.Forms.Button();
            this.btnGrPrediccion = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrVentasProducto
            // 
            this.btnGrVentasProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrVentasProducto.Location = new System.Drawing.Point(42, 94);
            this.btnGrVentasProducto.Name = "btnGrVentasProducto";
            this.btnGrVentasProducto.Size = new System.Drawing.Size(302, 84);
            this.btnGrVentasProducto.TabIndex = 0;
            this.btnGrVentasProducto.Text = "Productos Más Vendidos\r\ndel Último Mes\r\n";
            this.btnGrVentasProducto.UseVisualStyleBackColor = true;
            this.btnGrVentasProducto.Click += new System.EventHandler(this.btnGrVentasProducto_Click);
            // 
            // btnGrVentasporMes
            // 
            this.btnGrVentasporMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrVentasporMes.Location = new System.Drawing.Point(438, 94);
            this.btnGrVentasporMes.Name = "btnGrVentasporMes";
            this.btnGrVentasporMes.Size = new System.Drawing.Size(302, 84);
            this.btnGrVentasporMes.TabIndex = 1;
            this.btnGrVentasporMes.Text = "Ventas por Mes";
            this.btnGrVentasporMes.UseVisualStyleBackColor = true;
            this.btnGrVentasporMes.Click += new System.EventHandler(this.btnGrVentasporMes_Click);
            // 
            // btnGrInventario
            // 
            this.btnGrInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrInventario.Location = new System.Drawing.Point(42, 237);
            this.btnGrInventario.Name = "btnGrInventario";
            this.btnGrInventario.Size = new System.Drawing.Size(302, 84);
            this.btnGrInventario.TabIndex = 2;
            this.btnGrInventario.Text = "Inventario Bajo";
            this.btnGrInventario.UseVisualStyleBackColor = true;
            this.btnGrInventario.Click += new System.EventHandler(this.btnGrInventario_Click);
            // 
            // btnGrPrediccion
            // 
            this.btnGrPrediccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrPrediccion.Location = new System.Drawing.Point(438, 237);
            this.btnGrPrediccion.Name = "btnGrPrediccion";
            this.btnGrPrediccion.Size = new System.Drawing.Size(302, 84);
            this.btnGrPrediccion.TabIndex = 3;
            this.btnGrPrediccion.Text = "Predicción de Demanda";
            this.btnGrPrediccion.UseVisualStyleBackColor = true;
            this.btnGrPrediccion.Click += new System.EventHandler(this.btnGrPrediccion_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Location = new System.Drawing.Point(244, 354);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(302, 84);
            this.btnPrincipal.TabIndex = 4;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gráficas";
            // 
            // FrmGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnGrPrediccion);
            this.Controls.Add(this.btnGrInventario);
            this.Controls.Add(this.btnGrVentasporMes);
            this.Controls.Add(this.btnGrVentasProducto);
            this.Name = "FrmGraficas";
            this.Text = "FrmGraficascs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrVentasProducto;
        private System.Windows.Forms.Button btnGrVentasporMes;
        private System.Windows.Forms.Button btnGrInventario;
        private System.Windows.Forms.Button btnGrPrediccion;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Label label1;
    }
}