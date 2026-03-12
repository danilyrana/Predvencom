namespace Predven
{
    partial class FrmCobrar
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
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.pnlEfectivo = new System.Windows.Forms.Panel();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.lblRecibido = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.lblPropina = new System.Windows.Forms.Label();
            this.txtPropina = new System.Windows.Forms.TextBox();
            this.lblCambioTitulo = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtReferenciaTarjeta = new System.Windows.Forms.TextBox();
            this.cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.pnlEfectivo.SuspendLayout();
            this.pnlTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Location = new System.Drawing.Point(108, 125);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(199, 107);
            this.btnEfectivo.TabIndex = 0;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Location = new System.Drawing.Point(457, 125);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(187, 106);
            this.btnTarjeta.TabIndex = 1;
            this.btnTarjeta.Text = "Tarjeta";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // pnlEfectivo
            // 
            this.pnlEfectivo.Controls.Add(this.lblCambio);
            this.pnlEfectivo.Controls.Add(this.lblCambioTitulo);
            this.pnlEfectivo.Controls.Add(this.txtPropina);
            this.pnlEfectivo.Controls.Add(this.lblPropina);
            this.pnlEfectivo.Controls.Add(this.txtRecibido);
            this.pnlEfectivo.Controls.Add(this.lblRecibido);
            this.pnlEfectivo.Location = new System.Drawing.Point(37, 100);
            this.pnlEfectivo.Name = "pnlEfectivo";
            this.pnlEfectivo.Size = new System.Drawing.Size(393, 250);
            this.pnlEfectivo.TabIndex = 4;
            this.pnlEfectivo.Visible = false;
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.Controls.Add(this.lblTipoTarjeta);
            this.pnlTarjeta.Controls.Add(this.cmbTipoTarjeta);
            this.pnlTarjeta.Controls.Add(this.txtReferenciaTarjeta);
            this.pnlTarjeta.Controls.Add(this.lblReferencia);
            this.pnlTarjeta.Location = new System.Drawing.Point(436, 100);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(352, 250);
            this.pnlTarjeta.TabIndex = 5;
            // 
            // lblRecibido
            // 
            this.lblRecibido.AutoSize = true;
            this.lblRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibido.Location = new System.Drawing.Point(37, 14);
            this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Size = new System.Drawing.Size(85, 22);
            this.lblRecibido.TabIndex = 0;
            this.lblRecibido.Text = "Recibido:";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(32, 19);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(107, 22);
            this.lblReferencia.TabIndex = 6;
            this.lblReferencia.Text = "Referencia: ";
            // 
            // txtRecibido
            // 
            this.txtRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibido.Location = new System.Drawing.Point(41, 39);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(145, 28);
            this.txtRecibido.TabIndex = 1;
            this.txtRecibido.TextChanged += new System.EventHandler(this.txtRecibido_TextChanged);
            // 
            // lblPropina
            // 
            this.lblPropina.AutoSize = true;
            this.lblPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropina.Location = new System.Drawing.Point(37, 76);
            this.lblPropina.Name = "lblPropina";
            this.lblPropina.Size = new System.Drawing.Size(77, 22);
            this.lblPropina.TabIndex = 2;
            this.lblPropina.Text = "Propina:";
            // 
            // txtPropina
            // 
            this.txtPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropina.Location = new System.Drawing.Point(41, 104);
            this.txtPropina.Name = "txtPropina";
            this.txtPropina.Size = new System.Drawing.Size(145, 28);
            this.txtPropina.TabIndex = 3;
            this.txtPropina.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCambioTitulo
            // 
            this.lblCambioTitulo.AutoSize = true;
            this.lblCambioTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioTitulo.Location = new System.Drawing.Point(37, 145);
            this.lblCambioTitulo.Name = "lblCambioTitulo";
            this.lblCambioTitulo.Size = new System.Drawing.Size(76, 22);
            this.lblCambioTitulo.TabIndex = 7;
            this.lblCambioTitulo.Text = "Cambio:";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(147, 178);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(62, 29);
            this.lblCambio.TabIndex = 8;
            this.lblCambio.Text = "0.00";
            // 
            // txtReferenciaTarjeta
            // 
            this.txtReferenciaTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenciaTarjeta.Location = new System.Drawing.Point(36, 53);
            this.txtReferenciaTarjeta.Name = "txtReferenciaTarjeta";
            this.txtReferenciaTarjeta.Size = new System.Drawing.Size(145, 28);
            this.txtReferenciaTarjeta.TabIndex = 7;
            this.txtReferenciaTarjeta.Text = "Tipo de Tarjeta";
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(32, 143);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(145, 24);
            this.cmbTipoTarjeta.TabIndex = 6;
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTarjeta.Location = new System.Drawing.Point(32, 107);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(131, 22);
            this.lblTipoTarjeta.TabIndex = 8;
            this.lblTipoTarjeta.Text = "Tipo de tarjeta:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(457, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 55);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(636, 363);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 55);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(130, 27);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(163, 29);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Total a Pagar:";
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.Location = new System.Drawing.Point(335, 19);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(107, 39);
            this.lblTotalVenta.TabIndex = 8;
            this.lblTotalVenta.Text = "$0.00";
            // 
            // FrmCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 471);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.lblTotalVenta);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlTarjeta);
            this.Controls.Add(this.pnlEfectivo);
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.btnEfectivo);
            this.Name = "FrmCobrar";
            this.Text = "$0.00";
            this.Load += new System.EventHandler(this.FrmCobrar_Load);
            this.pnlEfectivo.ResumeLayout(false);
            this.pnlEfectivo.PerformLayout();
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Panel pnlEfectivo;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.Label lblRecibido;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblCambioTitulo;
        private System.Windows.Forms.TextBox txtPropina;
        private System.Windows.Forms.Label lblPropina;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private System.Windows.Forms.TextBox txtReferenciaTarjeta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblTotalVenta;
    }
}