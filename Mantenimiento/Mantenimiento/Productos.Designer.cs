namespace Mantenimiento
{
    partial class Form_Productos
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
            this.dataGv2 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnActualiza = new System.Windows.Forms.Button();
            this.btnIngreProd = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnSalida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGv2
            // 
            this.dataGv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGv2.Location = new System.Drawing.Point(31, 195);
            this.dataGv2.Name = "dataGv2";
            this.dataGv2.Size = new System.Drawing.Size(608, 329);
            this.dataGv2.TabIndex = 1;
            this.dataGv2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGv2_RowHeaderMouseClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(123, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(123, 101);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(352, 61);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(352, 105);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(123, 144);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(100, 20);
            this.txtPre.TabIndex = 8;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(352, 144);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 9;
            // 
            // btnActualiza
            // 
            this.btnActualiza.Location = new System.Drawing.Point(491, 138);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(75, 23);
            this.btnActualiza.TabIndex = 10;
            this.btnActualiza.Text = "Actualizar";
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // btnIngreProd
            // 
            this.btnIngreProd.Location = new System.Drawing.Point(491, 56);
            this.btnIngreProd.Name = "btnIngreProd";
            this.btnIngreProd.Size = new System.Drawing.Size(75, 23);
            this.btnIngreProd.TabIndex = 11;
            this.btnIngreProd.Text = "Ingresar";
            this.btnIngreProd.UseVisualStyleBackColor = true;
            this.btnIngreProd.Click += new System.EventHandler(this.btnIngreProd_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(491, 98);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 12;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(84, 68);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 13;
            this.lbID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(52, 105);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(65, 144);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(284, 66);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(284, 109);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(259, 148);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(74, 13);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo Producto";
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(664, 536);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 23);
            this.btnSalida.TabIndex = 19;
            this.btnSalida.Text = "Salir";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // Form_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 581);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnIngreProd);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGv2);
            this.Name = "Form_Productos";
            this.Text = "Admin View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGv2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnActualiza;
        private System.Windows.Forms.Button btnIngreProd;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnSalida;
    }
}