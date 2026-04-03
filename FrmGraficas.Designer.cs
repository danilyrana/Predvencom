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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnGrPrediccion = new System.Windows.Forms.Button();
            this.btnGrInventario = new System.Windows.Forms.Button();
            this.btnGrVentasporMes = new System.Windows.Forms.Button();
            this.btnGrVentasProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(511, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gráficas";
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Image = global::Predven.Properties.Resources.hogar__1_22;
            this.btnPrincipal.Location = new System.Drawing.Point(43, 30);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(108, 84);
            this.btnPrincipal.TabIndex = 4;
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnGrPrediccion
            // 
            this.btnGrPrediccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrPrediccion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGrPrediccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrPrediccion.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrPrediccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrPrediccion.Image = global::Predven.Properties.Resources.prediccion22;
            this.btnGrPrediccion.Location = new System.Drawing.Point(710, 432);
            this.btnGrPrediccion.Name = "btnGrPrediccion";
            this.btnGrPrediccion.Size = new System.Drawing.Size(302, 166);
            this.btnGrPrediccion.TabIndex = 3;
            this.btnGrPrediccion.Text = "Predicción de Demanda";
            this.btnGrPrediccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrPrediccion.UseVisualStyleBackColor = false;
            this.btnGrPrediccion.Click += new System.EventHandler(this.btnGrPrediccion_Click);
            // 
            // btnGrInventario
            // 
            this.btnGrInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrInventario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGrInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrInventario.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrInventario.Image = global::Predven.Properties.Resources.inventario22;
            this.btnGrInventario.Location = new System.Drawing.Point(220, 432);
            this.btnGrInventario.Name = "btnGrInventario";
            this.btnGrInventario.Size = new System.Drawing.Size(302, 166);
            this.btnGrInventario.TabIndex = 2;
            this.btnGrInventario.Text = "Inventario Bajo";
            this.btnGrInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrInventario.UseVisualStyleBackColor = false;
            this.btnGrInventario.Click += new System.EventHandler(this.btnGrInventario_Click);
            // 
            // btnGrVentasporMes
            // 
            this.btnGrVentasporMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrVentasporMes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGrVentasporMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrVentasporMes.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrVentasporMes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrVentasporMes.Image = global::Predven.Properties.Resources.grafico_de_barras22;
            this.btnGrVentasporMes.Location = new System.Drawing.Point(710, 208);
            this.btnGrVentasporMes.Name = "btnGrVentasporMes";
            this.btnGrVentasporMes.Size = new System.Drawing.Size(302, 166);
            this.btnGrVentasporMes.TabIndex = 1;
            this.btnGrVentasporMes.Text = "Ventas por Mes";
            this.btnGrVentasporMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrVentasporMes.UseVisualStyleBackColor = false;
            this.btnGrVentasporMes.Click += new System.EventHandler(this.btnGrVentasporMes_Click);
            // 
            // btnGrVentasProducto
            // 
            this.btnGrVentasProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrVentasProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGrVentasProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrVentasProducto.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrVentasProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrVentasProducto.Image = global::Predven.Properties.Resources.pedido_en_linea22;
            this.btnGrVentasProducto.Location = new System.Drawing.Point(220, 208);
            this.btnGrVentasProducto.Name = "btnGrVentasProducto";
            this.btnGrVentasProducto.Size = new System.Drawing.Size(302, 166);
            this.btnGrVentasProducto.TabIndex = 0;
            this.btnGrVentasProducto.Text = "Productos Más Vendidos";
            this.btnGrVentasProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrVentasProducto.UseVisualStyleBackColor = false;
            this.btnGrVentasProducto.Click += new System.EventHandler(this.btnGrVentasProducto_Click);
            // 
            // FrmGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1202, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnGrPrediccion);
            this.Controls.Add(this.btnGrInventario);
            this.Controls.Add(this.btnGrVentasporMes);
            this.Controls.Add(this.btnGrVentasProducto);
            this.Name = "FrmGraficas";
            this.Text = "FrmGraficascs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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