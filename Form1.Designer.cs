
namespace Sistema_de_Mercado
{
    partial class frmPrincipal
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
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblprecionuevo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtpnuevo = new System.Windows.Forms.TextBox();
            this.txtpactual = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dateingreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(271, 45);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(191, 24);
            this.lblSistema.TabIndex = 0;
            this.lblSistema.Text = "Sistema de Mercado";
            this.lblSistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblproducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblproducto.Location = new System.Drawing.Point(62, 150);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(149, 17);
            this.lblproducto.TabIndex = 1;
            this.lblproducto.Text = "Nombre de Producto:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblcodigo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcodigo.Location = new System.Drawing.Point(62, 113);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(60, 17);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecio.Location = new System.Drawing.Point(62, 184);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 17);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio Actual:";
            // 
            // lblprecionuevo
            // 
            this.lblprecionuevo.AutoSize = true;
            this.lblprecionuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblprecionuevo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecionuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblprecionuevo.Location = new System.Drawing.Point(62, 219);
            this.lblprecionuevo.Name = "lblprecionuevo";
            this.lblprecionuevo.Size = new System.Drawing.Size(102, 17);
            this.lblprecionuevo.TabIndex = 4;
            this.lblprecionuevo.Text = "Precio Nuevo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(246, 110);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(173, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtpnuevo
            // 
            this.txtpnuevo.Location = new System.Drawing.Point(246, 216);
            this.txtpnuevo.Name = "txtpnuevo";
            this.txtpnuevo.Size = new System.Drawing.Size(173, 20);
            this.txtpnuevo.TabIndex = 6;
            // 
            // txtpactual
            // 
            this.txtpactual.Location = new System.Drawing.Point(246, 181);
            this.txtpactual.Name = "txtpactual";
            this.txtpactual.Size = new System.Drawing.Size(173, 20);
            this.txtpactual.TabIndex = 7;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(246, 147);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(173, 20);
            this.txtproducto.TabIndex = 8;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblfecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblfecha.Location = new System.Drawing.Point(62, 249);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(127, 17);
            this.lblfecha.TabIndex = 9;
            this.lblfecha.Text = "Fecha de Ingreso:";
            // 
            // dateingreso
            // 
            this.dateingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateingreso.Location = new System.Drawing.Point(246, 249);
            this.dateingreso.Name = "dateingreso";
            this.dateingreso.Size = new System.Drawing.Size(173, 20);
            this.dateingreso.TabIndex = 10;
            this.dateingreso.Value = new System.DateTime(2022, 3, 13, 0, 0, 0, 0);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateingreso);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.txtpactual);
            this.Controls.Add(this.txtpnuevo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblprecionuevo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.lblSistema);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Mercado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblprecionuevo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtpnuevo;
        private System.Windows.Forms.TextBox txtpactual;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dateingreso;
    }
}

