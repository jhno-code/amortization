namespace IngEconomia
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
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.txtbPrestamo = new System.Windows.Forms.TextBox();
            this.lblTasaAnual = new System.Windows.Forms.Label();
            this.txtbTasaAnual = new System.Windows.Forms.TextBox();
            this.lblTiempoAnual = new System.Windows.Forms.Label();
            this.txtbTiempoAnual = new System.Windows.Forms.TextBox();
            this.btMostrarTabla = new System.Windows.Forms.Button();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblTipoAmortizacion = new System.Windows.Forms.Label();
            this.cbTipoAmortizacion = new System.Windows.Forms.ComboBox();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amortizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(12, 21);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(57, 13);
            this.lblPrestamo.TabIndex = 0;
            this.lblPrestamo.Text = "Prestamo: ";
            // 
            // txtbPrestamo
            // 
            this.txtbPrestamo.Location = new System.Drawing.Point(97, 18);
            this.txtbPrestamo.Name = "txtbPrestamo";
            this.txtbPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtbPrestamo.TabIndex = 1;
            // 
            // lblTasaAnual
            // 
            this.lblTasaAnual.AutoSize = true;
            this.lblTasaAnual.Location = new System.Drawing.Point(12, 58);
            this.lblTasaAnual.Name = "lblTasaAnual";
            this.lblTasaAnual.Size = new System.Drawing.Size(66, 13);
            this.lblTasaAnual.TabIndex = 2;
            this.lblTasaAnual.Text = "Tasa anual: ";
            // 
            // txtbTasaAnual
            // 
            this.txtbTasaAnual.Location = new System.Drawing.Point(97, 55);
            this.txtbTasaAnual.Name = "txtbTasaAnual";
            this.txtbTasaAnual.Size = new System.Drawing.Size(100, 20);
            this.txtbTasaAnual.TabIndex = 3;
            // 
            // lblTiempoAnual
            // 
            this.lblTiempoAnual.AutoSize = true;
            this.lblTiempoAnual.Location = new System.Drawing.Point(12, 92);
            this.lblTiempoAnual.Name = "lblTiempoAnual";
            this.lblTiempoAnual.Size = new System.Drawing.Size(74, 13);
            this.lblTiempoAnual.TabIndex = 4;
            this.lblTiempoAnual.Text = "Tiempo anual:";
            // 
            // txtbTiempoAnual
            // 
            this.txtbTiempoAnual.Location = new System.Drawing.Point(97, 89);
            this.txtbTiempoAnual.Name = "txtbTiempoAnual";
            this.txtbTiempoAnual.Size = new System.Drawing.Size(100, 20);
            this.txtbTiempoAnual.TabIndex = 5;
            // 
            // btMostrarTabla
            // 
            this.btMostrarTabla.Location = new System.Drawing.Point(62, 235);
            this.btMostrarTabla.Name = "btMostrarTabla";
            this.btMostrarTabla.Size = new System.Drawing.Size(86, 23);
            this.btMostrarTabla.TabIndex = 15;
            this.btMostrarTabla.Text = "Mostrar Tabla";
            this.btMostrarTabla.UseVisualStyleBackColor = true;
            this.btMostrarTabla.Click += new System.EventHandler(this.btMostrarTabla_Click);
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Items.AddRange(new object[] {
            "Anual",
            "Semestral",
            "Trimestral",
            "Mensual"});
            this.cbTipoPago.Location = new System.Drawing.Point(97, 146);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPago.TabIndex = 16;
            this.cbTipoPago.Text = "Anual";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(12, 149);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(74, 13);
            this.lblTipoPago.TabIndex = 17;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // lblTipoAmortizacion
            // 
            this.lblTipoAmortizacion.AutoSize = true;
            this.lblTipoAmortizacion.Location = new System.Drawing.Point(12, 183);
            this.lblTipoAmortizacion.Name = "lblTipoAmortizacion";
            this.lblTipoAmortizacion.Size = new System.Drawing.Size(73, 13);
            this.lblTipoAmortizacion.TabIndex = 18;
            this.lblTipoAmortizacion.Text = "Amortizacion: ";
            // 
            // cbTipoAmortizacion
            // 
            this.cbTipoAmortizacion.FormattingEnabled = true;
            this.cbTipoAmortizacion.Items.AddRange(new object[] {
            "Francesa",
            "Alemana",
            "Americana"});
            this.cbTipoAmortizacion.Location = new System.Drawing.Point(97, 180);
            this.cbTipoAmortizacion.Name = "cbTipoAmortizacion";
            this.cbTipoAmortizacion.Size = new System.Drawing.Size(121, 21);
            this.cbTipoAmortizacion.TabIndex = 19;
            this.cbTipoAmortizacion.Text = "Francesa";
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Periodo,
            this.Cuota,
            this.Amortizacion,
            this.Interes,
            this.Capital});
            this.dtgvTabla.Location = new System.Drawing.Point(274, 18);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.Size = new System.Drawing.Size(544, 453);
            this.dtgvTabla.TabIndex = 20;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            // 
            // Amortizacion
            // 
            this.Amortizacion.HeaderText = "Amortizacion";
            this.Amortizacion.Name = "Amortizacion";
            // 
            // Interes
            // 
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            // 
            // Capital
            // 
            this.Capital.HeaderText = "Capital Residual";
            this.Capital.Name = "Capital";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(12, 447);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(0, 13);
            this.lblDatos.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 483);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.dtgvTabla);
            this.Controls.Add(this.cbTipoAmortizacion);
            this.Controls.Add(this.lblTipoAmortizacion);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.btMostrarTabla);
            this.Controls.Add(this.txtbTiempoAnual);
            this.Controls.Add(this.lblTiempoAnual);
            this.Controls.Add(this.txtbTasaAnual);
            this.Controls.Add(this.lblTasaAnual);
            this.Controls.Add(this.txtbPrestamo);
            this.Controls.Add(this.lblPrestamo);
            this.Name = "Form1";
            this.Text = "Tablas de Amortizacion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.TextBox txtbPrestamo;
        private System.Windows.Forms.Label lblTasaAnual;
        private System.Windows.Forms.TextBox txtbTasaAnual;
        private System.Windows.Forms.Label lblTiempoAnual;
        private System.Windows.Forms.TextBox txtbTiempoAnual;
        private System.Windows.Forms.Button btMostrarTabla;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblTipoAmortizacion;
        private System.Windows.Forms.ComboBox cbTipoAmortizacion;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amortizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.Label lblDatos;
    }
}

