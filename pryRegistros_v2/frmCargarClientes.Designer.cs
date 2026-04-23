namespace pryRegistros_v2
{
    partial class frmCargarClientes
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
            this.gprCargaClientes = new System.Windows.Forms.GroupBox();
            this.btnCagar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gprCargaClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gprCargaClientes
            // 
            this.gprCargaClientes.Controls.Add(this.btnCagar);
            this.gprCargaClientes.Controls.Add(this.textBox4);
            this.gprCargaClientes.Controls.Add(this.textBox3);
            this.gprCargaClientes.Controls.Add(this.textBox2);
            this.gprCargaClientes.Controls.Add(this.textBox1);
            this.gprCargaClientes.Controls.Add(this.lblLimiteCredito);
            this.gprCargaClientes.Controls.Add(this.lblDeuda);
            this.gprCargaClientes.Controls.Add(this.lblNombreApellido);
            this.gprCargaClientes.Controls.Add(this.lblCodigo);
            this.gprCargaClientes.Location = new System.Drawing.Point(24, 22);
            this.gprCargaClientes.Name = "gprCargaClientes";
            this.gprCargaClientes.Size = new System.Drawing.Size(560, 201);
            this.gprCargaClientes.TabIndex = 0;
            this.gprCargaClientes.TabStop = false;
            this.gprCargaClientes.Text = "Carca de datos";
            // 
            // btnCagar
            // 
            this.btnCagar.Location = new System.Drawing.Point(441, 156);
            this.btnCagar.Name = "btnCagar";
            this.btnCagar.Size = new System.Drawing.Size(86, 23);
            this.btnCagar.TabIndex = 8;
            this.btnCagar.Text = "Cargar";
            this.btnCagar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(282, 113);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(86, 13);
            this.lblLimiteCredito.TabIndex = 3;
            this.lblLimiteCredito.Text = "Límite de crédito";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(57, 113);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(39, 13);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda";
            this.lblDeuda.Click += new System.EventHandler(this.lblDeuda_Click);
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Location = new System.Drawing.Point(282, 48);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(92, 13);
            this.lblNombreApellido.TabIndex = 1;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(57, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // frmCargarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 240);
            this.Controls.Add(this.gprCargaClientes);
            this.MaximizeBox = false;
            this.Name = "frmCargarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargarClientes";
            this.gprCargaClientes.ResumeLayout(false);
            this.gprCargaClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gprCargaClientes;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCagar;
    }
}