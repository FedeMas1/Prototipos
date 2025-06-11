namespace Prototipos
{
    partial class FormRemito
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
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtbCInforme = new System.Windows.Forms.TextBox();
            this.txtbReceptor = new System.Windows.Forms.TextBox();
            this.txtbObservaciones = new System.Windows.Forms.TextBox();
            this.lblCInforme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_OC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_pedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_buen_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_mal_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(1, 3);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(75, 23);
            this.bttnBack.TabIndex = 4;
            this.bttnBack.Text = "back";
            this.bttnBack.UseVisualStyleBackColor = true;
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(94, 330);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttnEliminar.TabIndex = 0;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Location = new System.Drawing.Point(713, 330);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttnGuardar.TabIndex = 1;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(94, 377);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttnBuscar.TabIndex = 2;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            // 
            // bttnModificar
            // 
            this.bttnModificar.Location = new System.Drawing.Point(713, 377);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(75, 23);
            this.bttnModificar.TabIndex = 3;
            this.bttnModificar.Text = "Modificar";
            this.bttnModificar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(607, 40);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 50;
            // 
            // txtbCInforme
            // 
            this.txtbCInforme.Location = new System.Drawing.Point(96, 40);
            this.txtbCInforme.Name = "txtbCInforme";
            this.txtbCInforme.Size = new System.Drawing.Size(100, 20);
            this.txtbCInforme.TabIndex = 10;
            // 
            // txtbReceptor
            // 
            this.txtbReceptor.Location = new System.Drawing.Point(96, 82);
            this.txtbReceptor.Name = "txtbReceptor";
            this.txtbReceptor.Size = new System.Drawing.Size(100, 20);
            this.txtbReceptor.TabIndex = 11;
            // 
            // txtbObservaciones
            // 
            this.txtbObservaciones.Location = new System.Drawing.Point(96, 304);
            this.txtbObservaciones.Name = "txtbObservaciones";
            this.txtbObservaciones.Size = new System.Drawing.Size(694, 20);
            this.txtbObservaciones.TabIndex = 12;
            // 
            // lblCInforme
            // 
            this.lblCInforme.AutoSize = true;
            this.lblCInforme.Location = new System.Drawing.Point(3, 43);
            this.lblCInforme.Name = "lblCInforme";
            this.lblCInforme.Size = new System.Drawing.Size(92, 13);
            this.lblCInforme.TabIndex = 100;
            this.lblCInforme.Text = "Codigo de informe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Codigo de receptor";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(91, 288);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 102;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUIT,
            this.cod_OC,
            this.descripcion,
            this.Rubro,
            this.Marca,
            this.Proveedor,
            this.cantidad_pedida,
            this.cantidad_real,
            this.U_buen_estado,
            this.U_mal_estado});
            this.dataGridView1.Location = new System.Drawing.Point(94, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 165);
            this.dataGridView1.TabIndex = 51;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            // 
            // cod_OC
            // 
            this.cod_OC.HeaderText = "Codigo OC";
            this.cod_OC.Name = "cod_OC";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion ";
            this.descripcion.Name = "descripcion";
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // cantidad_pedida
            // 
            this.cantidad_pedida.HeaderText = "Cantidad Pedida";
            this.cantidad_pedida.Name = "cantidad_pedida";
            // 
            // cantidad_real
            // 
            this.cantidad_real.HeaderText = "Cantidad real";
            this.cantidad_real.Name = "cantidad_real";
            // 
            // U_buen_estado
            // 
            this.U_buen_estado.HeaderText = "U. buen estado";
            this.U_buen_estado.Name = "U_buen_estado";
            // 
            // U_mal_estado
            // 
            this.U_mal_estado.HeaderText = "U. mal estado";
            this.U_mal_estado.Name = "U_mal_estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(185, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 31);
            this.label1.TabIndex = 103;
            this.label1.Text = "Informe de recepcion de mercaderia";
            // 
            // FormRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCInforme);
            this.Controls.Add(this.txtbObservaciones);
            this.Controls.Add(this.txtbReceptor);
            this.Controls.Add(this.txtbCInforme);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.bttnModificar);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnBack);
            this.Name = "FormRemito";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtbCInforme;
        private System.Windows.Forms.TextBox txtbReceptor;
        private System.Windows.Forms.TextBox txtbObservaciones;
        private System.Windows.Forms.Label lblCInforme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_OC;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_pedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_real;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_buen_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_mal_estado;
        private System.Windows.Forms.Label label1;
    }
}