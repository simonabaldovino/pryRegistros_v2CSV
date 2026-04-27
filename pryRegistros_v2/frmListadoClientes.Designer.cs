namespace pryRegistros_v2
{
    partial class frmListadoClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblTotDeuda = new System.Windows.Forms.Label();
            this.lblCantiodadClientes = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.dgvConsultaDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCantClientes);
            this.groupBox1.Controls.Add(this.lblPromDeuda);
            this.groupBox1.Controls.Add(this.lblTotDeuda);
            this.groupBox1.Controls.Add(this.lblCantiodadClientes);
            this.groupBox1.Controls.Add(this.lblPromedioDeuda);
            this.groupBox1.Controls.Add(this.lblTotalDeuda);
            this.groupBox1.Controls.Add(this.dgvConsultaDatos);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos";
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClientes.Location = new System.Drawing.Point(370, 303);
            this.lblCantClientes.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(50, 20);
            this.lblCantClientes.TabIndex = 6;
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeuda.Location = new System.Drawing.Point(370, 337);
            this.lblPromDeuda.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(50, 20);
            this.lblPromDeuda.TabIndex = 5;
            // 
            // lblTotDeuda
            // 
            this.lblTotDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotDeuda.Location = new System.Drawing.Point(370, 268);
            this.lblTotDeuda.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblTotDeuda.Name = "lblTotDeuda";
            this.lblTotDeuda.Size = new System.Drawing.Size(50, 20);
            this.lblTotDeuda.TabIndex = 4;
            // 
            // lblCantiodadClientes
            // 
            this.lblCantiodadClientes.AutoSize = true;
            this.lblCantiodadClientes.Location = new System.Drawing.Point(241, 303);
            this.lblCantiodadClientes.Name = "lblCantiodadClientes";
            this.lblCantiodadClientes.Size = new System.Drawing.Size(106, 13);
            this.lblCantiodadClientes.TabIndex = 3;
            this.lblCantiodadClientes.Text = "Cantidad de clientes:";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(241, 338);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(102, 13);
            this.lblPromedioDeuda.TabIndex = 2;
            this.lblPromedioDeuda.Text = "Promedio de deuda:";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(241, 269);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(67, 13);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "Total deuda:";
            // 
            // dgvConsultaDatos
            // 
            this.dgvConsultaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvConsultaDatos.Location = new System.Drawing.Point(16, 29);
            this.dgvConsultaDatos.Name = "dgvConsultaDatos";
            this.dgvConsultaDatos.RowHeadersWidth = 4;
            this.dgvConsultaDatos.Size = new System.Drawing.Size(406, 208);
            this.dgvConsultaDatos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Límite de crédito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 428);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListadoClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvConsultaDatos;
        private System.Windows.Forms.Label lblTotDeuda;
        private System.Windows.Forms.Label lblCantiodadClientes;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label lblPromDeuda;
    }
}