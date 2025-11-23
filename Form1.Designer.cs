namespace CalcularDescuentosPOO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreProducto = new System.Windows.Forms.TextBox();
            this.PrecioProducto = new System.Windows.Forms.TextBox();
            this.TipoProductoLabel = new System.Windows.Forms.Label();
            this.TipoProducto = new System.Windows.Forms.ComboBox();
            this.Resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre del producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el precio del producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NombreProducto
            // 
            this.NombreProducto.Location = new System.Drawing.Point(312, 93);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(144, 20);
            this.NombreProducto.TabIndex = 2;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.Location = new System.Drawing.Point(311, 153);
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Size = new System.Drawing.Size(145, 20);
            this.PrecioProducto.TabIndex = 3;
            this.PrecioProducto.TextChanged += new System.EventHandler(this.PrecioProducto_TextChanged);
            // 
            // TipoProductoLabel
            // 
            this.TipoProductoLabel.AutoSize = true;
            this.TipoProductoLabel.Location = new System.Drawing.Point(309, 186);
            this.TipoProductoLabel.Name = "TipoProductoLabel";
            this.TipoProductoLabel.Size = new System.Drawing.Size(147, 13);
            this.TipoProductoLabel.TabIndex = 4;
            this.TipoProductoLabel.Text = "Ingrese el precio del producto";
            // 
            // TipoProducto
            // 
            this.TipoProducto.FormattingEnabled = true;
            this.TipoProducto.Items.AddRange(new object[] {
            "Tecnologia",
            "Alimento",
            "General"});
            this.TipoProducto.Location = new System.Drawing.Point(311, 214);
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.Size = new System.Drawing.Size(145, 21);
            this.TipoProducto.TabIndex = 5;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(350, 262);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(75, 23);
            this.Resultado.TabIndex = 6;
            this.Resultado.Text = "Resultado";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.TipoProducto);
            this.Controls.Add(this.TipoProductoLabel);
            this.Controls.Add(this.PrecioProducto);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreProducto;
        private System.Windows.Forms.TextBox PrecioProducto;
        private System.Windows.Forms.Label TipoProductoLabel;
        private System.Windows.Forms.ComboBox TipoProducto;
        private System.Windows.Forms.Button Resultado;
    }
}

