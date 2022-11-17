namespace PrySP4Bar_Cantallops
{
    partial class frmBar
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
            this.dgvMozos = new System.Windows.Forms.DataGridView();
            this.Comidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comidas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebidas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebidas2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnMozo = new System.Windows.Forms.Button();
            this.txtNombreMozo = new System.Windows.Forms.TextBox();
            this.btnTotales = new System.Windows.Forms.Button();
            this.lblNombreMozo = new System.Windows.Forms.Label();
            this.lblImporteMozo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImporteMozo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtBebidasin = new System.Windows.Forms.TextBox();
            this.txtBebidacon = new System.Windows.Forms.TextBox();
            this.txtPostre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMozos
            // 
            this.dgvMozos.AllowUserToAddRows = false;
            this.dgvMozos.AllowUserToDeleteRows = false;
            this.dgvMozos.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvMozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMozos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comidas,
            this.comidas1,
            this.Bebidas1,
            this.Bebidas2,
            this.Postres});
            this.dgvMozos.Location = new System.Drawing.Point(12, 12);
            this.dgvMozos.Name = "dgvMozos";
            this.dgvMozos.Size = new System.Drawing.Size(552, 188);
            this.dgvMozos.TabIndex = 0;
            // 
            // Comidas
            // 
            this.Comidas.HeaderText = "Nombre";
            this.Comidas.Name = "Comidas";
            // 
            // comidas1
            // 
            this.comidas1.HeaderText = "Comidas";
            this.comidas1.Name = "comidas1";
            // 
            // Bebidas1
            // 
            this.Bebidas1.HeaderText = "Bebidas sin Alcohol";
            this.Bebidas1.Name = "Bebidas1";
            // 
            // Bebidas2
            // 
            this.Bebidas2.HeaderText = "Bebidas con Alcohol";
            this.Bebidas2.Name = "Bebidas2";
            // 
            // Postres
            // 
            this.Postres.HeaderText = "Postres";
            this.Postres.Name = "Postres";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(595, 58);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(127, 94);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnMozo
            // 
            this.btnMozo.Enabled = false;
            this.btnMozo.Location = new System.Drawing.Point(117, 206);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(91, 31);
            this.btnMozo.TabIndex = 3;
            this.btnMozo.Text = "Mozo del Día";
            this.btnMozo.UseVisualStyleBackColor = true;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // txtNombreMozo
            // 
            this.txtNombreMozo.Location = new System.Drawing.Point(145, 261);
            this.txtNombreMozo.Name = "txtNombreMozo";
            this.txtNombreMozo.ReadOnly = true;
            this.txtNombreMozo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMozo.TabIndex = 4;
            // 
            // btnTotales
            // 
            this.btnTotales.Enabled = false;
            this.btnTotales.Location = new System.Drawing.Point(460, 206);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(91, 31);
            this.btnTotales.TabIndex = 5;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // lblNombreMozo
            // 
            this.lblNombreMozo.AutoSize = true;
            this.lblNombreMozo.Location = new System.Drawing.Point(78, 261);
            this.lblNombreMozo.Name = "lblNombreMozo";
            this.lblNombreMozo.Size = new System.Drawing.Size(44, 13);
            this.lblNombreMozo.TabIndex = 6;
            this.lblNombreMozo.Text = "Nombre";
            // 
            // lblImporteMozo
            // 
            this.lblImporteMozo.AutoSize = true;
            this.lblImporteMozo.Location = new System.Drawing.Point(78, 291);
            this.lblImporteMozo.Name = "lblImporteMozo";
            this.lblImporteMozo.Size = new System.Drawing.Size(42, 13);
            this.lblImporteMozo.TabIndex = 7;
            this.lblImporteMozo.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Importe Bebidas sin alcohol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Importe Postres";
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(352, 299);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(85, 13);
            this.lblComida.TabIndex = 10;
            this.lblComida.Text = "Importe Comidas";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(352, 261);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Importe Total de Ventas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Importe Bebidas con alcohol";
            // 
            // txtImporteMozo
            // 
            this.txtImporteMozo.Location = new System.Drawing.Point(145, 288);
            this.txtImporteMozo.Name = "txtImporteMozo";
            this.txtImporteMozo.ReadOnly = true;
            this.txtImporteMozo.Size = new System.Drawing.Size(100, 20);
            this.txtImporteMozo.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(530, 261);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(530, 299);
            this.txtComida.Name = "txtComida";
            this.txtComida.ReadOnly = true;
            this.txtComida.Size = new System.Drawing.Size(100, 20);
            this.txtComida.TabIndex = 15;
            // 
            // txtBebidasin
            // 
            this.txtBebidasin.Location = new System.Drawing.Point(530, 334);
            this.txtBebidasin.Name = "txtBebidasin";
            this.txtBebidasin.ReadOnly = true;
            this.txtBebidasin.Size = new System.Drawing.Size(100, 20);
            this.txtBebidasin.TabIndex = 16;
            // 
            // txtBebidacon
            // 
            this.txtBebidacon.Location = new System.Drawing.Point(530, 371);
            this.txtBebidacon.Name = "txtBebidacon";
            this.txtBebidacon.ReadOnly = true;
            this.txtBebidacon.Size = new System.Drawing.Size(100, 20);
            this.txtBebidacon.TabIndex = 17;
            // 
            // txtPostre
            // 
            this.txtPostre.Location = new System.Drawing.Point(530, 403);
            this.txtPostre.Name = "txtPostre";
            this.txtPostre.ReadOnly = true;
            this.txtPostre.Size = new System.Drawing.Size(100, 20);
            this.txtPostre.TabIndex = 18;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(658, 462);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 36);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(790, 523);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtPostre);
            this.Controls.Add(this.txtBebidacon);
            this.Controls.Add(this.txtBebidasin);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtImporteMozo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblImporteMozo);
            this.Controls.Add(this.lblNombreMozo);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.txtNombreMozo);
            this.Controls.Add(this.btnMozo);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dgvMozos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmBar";
            this.Text = "Bar La Milanga";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMozos;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnMozo;
        private System.Windows.Forms.TextBox txtNombreMozo;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Label lblNombreMozo;
        private System.Windows.Forms.Label lblImporteMozo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImporteMozo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtBebidasin;
        private System.Windows.Forms.TextBox txtBebidacon;
        private System.Windows.Forms.TextBox txtPostre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn comidas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebidas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebidas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postres;
        private System.Windows.Forms.Button btnSalir;
    }
}

