namespace Prototipos
{
    partial class FormIRM
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
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtbNRemito = new System.Windows.Forms.TextBox();
            this.txtbProveedor = new System.Windows.Forms.TextBox();
            this.dgvRemito = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_de_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNRemito = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.bttnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(13, 13);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(75, 23);
            this.bttnBack.TabIndex = 4;
            this.bttnBack.Text = "Back";
            this.bttnBack.UseVisualStyleBackColor = true;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(90, 352);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 0;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(90, 277);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttnEliminar.TabIndex = 1;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(317, 352);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttnBuscar.TabIndex = 2;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            // 
            // bttnModificar
            // 
            this.bttnModificar.Location = new System.Drawing.Point(558, 352);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(75, 23);
            this.bttnModificar.TabIndex = 3;
            this.bttnModificar.Text = "Modificar";
            this.bttnModificar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(498, 21);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 51;
            // 
            // txtbNRemito
            // 
            this.txtbNRemito.Location = new System.Drawing.Point(90, 62);
            this.txtbNRemito.Name = "txtbNRemito";
            this.txtbNRemito.Size = new System.Drawing.Size(100, 20);
            this.txtbNRemito.TabIndex = 10;
            // 
            // txtbProveedor
            // 
            this.txtbProveedor.Location = new System.Drawing.Point(90, 98);
            this.txtbProveedor.Name = "txtbProveedor";
            this.txtbProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtbProveedor.TabIndex = 11;
            // 
            // dgvRemito
            // 
            this.dgvRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Rubro,
            this.Marca,
            this.Cantidad,
            this.U_de_medida});
            this.dgvRemito.Location = new System.Drawing.Point(90, 133);
            this.dgvRemito.Name = "dgvRemito";
            this.dgvRemito.Size = new System.Drawing.Size(543, 117);
            this.dgvRemito.TabIndex = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // U_de_medida
            // 
            this.U_de_medida.HeaderText = "U. de medida";
            this.U_de_medida.Name = "U_de_medida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(282, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 100;
            this.label1.Text = "Remito";
            // 
            // lblNRemito
            // 
            this.lblNRemito.AutoSize = true;
            this.lblNRemito.Location = new System.Drawing.Point(-2, 65);
            this.lblNRemito.Name = "lblNRemito";
            this.lblNRemito.Size = new System.Drawing.Size(90, 13);
            this.lblNRemito.TabIndex = 101;
            this.lblNRemito.Text = "Numero de remito";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(15, 98);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 102;
            this.lblProveedor.Text = "Proveedor";
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Location = new System.Drawing.Point(558, 277);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttnGuardar.TabIndex = 5;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormIRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 396);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblNRemito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRemito);
            this.Controls.Add(this.txtbProveedor);
            this.Controls.Add(this.txtbNRemito);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.bttnModificar);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.bttnBack);
            this.Name = "FormIRM";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtbNRemito;
        private System.Windows.Forms.TextBox txtbProveedor;
        private System.Windows.Forms.DataGridView dgvRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_de_medida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNRemito;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button bttnGuardar;
    }
}