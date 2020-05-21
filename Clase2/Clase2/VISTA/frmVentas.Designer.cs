namespace Clase2.VISTA
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDNumercion = new System.Windows.Forms.TextBox();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTipoD = new System.Windows.Forms.ComboBox();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(29, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Buscar Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowText;
            this.label6.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(183, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.WindowText;
            this.label7.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(382, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.WindowText;
            this.label8.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(605, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.WindowText;
            this.label9.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(820, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total";
            // 
            // txtIDNumercion
            // 
            this.txtIDNumercion.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDNumercion.Enabled = false;
            this.txtIDNumercion.Location = new System.Drawing.Point(198, 41);
            this.txtIDNumercion.Name = "txtIDNumercion";
            this.txtIDNumercion.Size = new System.Drawing.Size(124, 20);
            this.txtIDNumercion.TabIndex = 9;
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(198, 200);
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(161, 20);
            this.txtCodigoBusqueda.TabIndex = 10;
            this.txtCodigoBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBusqueda_KeyUp);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(35, 266);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 11;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(173, 266);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(170, 20);
            this.txtNombreProducto.TabIndex = 12;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioProd.Enabled = false;
            this.txtPrecioProd.Location = new System.Drawing.Point(375, 266);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(152, 20);
            this.txtPrecioProd.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.Location = new System.Drawing.Point(569, 266);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(155, 20);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(767, 266);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(375, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(895, 172);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 35);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(198, 85);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(124, 21);
            this.cmbCliente.TabIndex = 18;
            // 
            // cmbTipoD
            // 
            this.cmbTipoD.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTipoD.FormattingEnabled = true;
            this.cmbTipoD.Location = new System.Drawing.Point(198, 139);
            this.cmbTipoD.Name = "cmbTipoD";
            this.cmbTipoD.Size = new System.Drawing.Size(124, 21);
            this.cmbTipoD.TabIndex = 19;
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dtgProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductos.BackgroundColor = System.Drawing.SystemColors.MenuText;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.PRECIO,
            this.CANTIDAD,
            this.TOTAL});
            this.dtgProductos.GridColor = System.Drawing.SystemColors.Window;
            this.dtgProductos.Location = new System.Drawing.Point(35, 328);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            this.dtgProductos.Size = new System.Drawing.Size(967, 223);
            this.dtgProductos.TabIndex = 20;
            this.dtgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO PROD";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE PROD";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO PROD";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.WindowText;
            this.label10.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(281, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total   $ :";
            // 
            // txtTot
            // 
            this.txtTot.Enabled = false;
            this.txtTot.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(399, 577);
            this.txtTot.Multiline = true;
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(191, 53);
            this.txtTot.TabIndex = 22;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(895, 110);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(107, 34);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.WindowText;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(738, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 23);
            this.label11.TabIndex = 24;
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(864, 584);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(120, 46);
            this.btnVentas.TabIndex = 25;
            this.btnVentas.Text = "Guardar Venta";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Location = new System.Drawing.Point(442, 38);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(243, 20);
            this.dtpFecha.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1002, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 25);
            this.button2.TabIndex = 27;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 660);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.cmbTipoD);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtCodigoBusqueda);
            this.Controls.Add(this.txtIDNumercion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDNumercion;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTipoD;
        private System.Windows.Forms.DataGridView dtgProductos;
        public System.Windows.Forms.TextBox txtIdProducto;
        public System.Windows.Forms.TextBox txtNombreProducto;
        public System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button button2;
    }
}