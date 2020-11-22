namespace Mantenimiento
{
    partial class Form_Geografia
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
            this.cbx_TipoGeografia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGv1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_TipoGeografia
            // 
            this.cbx_TipoGeografia.FormattingEnabled = true;
            this.cbx_TipoGeografia.Location = new System.Drawing.Point(12, 12);
            this.cbx_TipoGeografia.Name = "cbx_TipoGeografia";
            this.cbx_TipoGeografia.Size = new System.Drawing.Size(121, 21);
            this.cbx_TipoGeografia.TabIndex = 0;
            this.cbx_TipoGeografia.SelectedIndexChanged += new System.EventHandler(this.cbxTipGeograf_Ind_Chang);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGv1
            // 
            this.dataGv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGv1.Location = new System.Drawing.Point(12, 81);
            this.dataGv1.Name = "dataGv1";
            this.dataGv1.Size = new System.Drawing.Size(776, 307);
            this.dataGv1.TabIndex = 2;
            // 
            // Form_Geografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGv1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_TipoGeografia);
            this.Name = "Form_Geografia";
            this.Text = "Mantenimiento_Geografia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_TipoGeografia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGv1;
    }
}