
namespace Sistema_de_Mercado
{
    partial class frmeditar
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
            this.lbleditproducto = new System.Windows.Forms.Label();
            this.lbleditcodigo = new System.Windows.Forms.Label();
            this.lbleditPrecio = new System.Windows.Forms.Label();
            this.lbleditprecionuevo = new System.Windows.Forms.Label();
            this.txtcodeditar = new System.Windows.Forms.TextBox();
            this.txteditpnuevo = new System.Windows.Forms.TextBox();
            this.txteditpactual = new System.Windows.Forms.TextBox();
            this.txteditproduc = new System.Windows.Forms.TextBox();
            this.lbleditfecha = new System.Windows.Forms.Label();
            this.dateedit = new System.Windows.Forms.DateTimePicker();
            this.pnleditar = new System.Windows.Forms.Panel();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnvolverI = new System.Windows.Forms.Button();
            this.pnleditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(250, 29);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(191, 24);
            this.lblSistema.TabIndex = 0;
            this.lblSistema.Text = "Sistema de Mercado";
            this.lblSistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbleditproducto
            // 
            this.lbleditproducto.AutoSize = true;
            this.lbleditproducto.BackColor = System.Drawing.Color.Transparent;
            this.lbleditproducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditproducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbleditproducto.Location = new System.Drawing.Point(10, 160);
            this.lbleditproducto.Name = "lbleditproducto";
            this.lbleditproducto.Size = new System.Drawing.Size(149, 17);
            this.lbleditproducto.TabIndex = 1;
            this.lbleditproducto.Text = "Nombre de Producto:";
            // 
            // lbleditcodigo
            // 
            this.lbleditcodigo.AutoSize = true;
            this.lbleditcodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbleditcodigo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditcodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbleditcodigo.Location = new System.Drawing.Point(10, 112);
            this.lbleditcodigo.Name = "lbleditcodigo";
            this.lbleditcodigo.Size = new System.Drawing.Size(60, 17);
            this.lbleditcodigo.TabIndex = 2;
            this.lbleditcodigo.Text = "Codigo:";
            // 
            // lbleditPrecio
            // 
            this.lbleditPrecio.AutoSize = true;
            this.lbleditPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lbleditPrecio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbleditPrecio.Location = new System.Drawing.Point(10, 205);
            this.lbleditPrecio.Name = "lbleditPrecio";
            this.lbleditPrecio.Size = new System.Drawing.Size(100, 17);
            this.lbleditPrecio.TabIndex = 3;
            this.lbleditPrecio.Text = "Precio Actual:";
            // 
            // lbleditprecionuevo
            // 
            this.lbleditprecionuevo.AutoSize = true;
            this.lbleditprecionuevo.BackColor = System.Drawing.Color.Transparent;
            this.lbleditprecionuevo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditprecionuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbleditprecionuevo.Location = new System.Drawing.Point(10, 248);
            this.lbleditprecionuevo.Name = "lbleditprecionuevo";
            this.lbleditprecionuevo.Size = new System.Drawing.Size(102, 17);
            this.lbleditprecionuevo.TabIndex = 4;
            this.lbleditprecionuevo.Text = "Precio Nuevo:";
            // 
            // txtcodeditar
            // 
            this.txtcodeditar.Location = new System.Drawing.Point(254, 112);
            this.txtcodeditar.Name = "txtcodeditar";
            this.txtcodeditar.Size = new System.Drawing.Size(173, 20);
            this.txtcodeditar.TabIndex = 5;
            // 
            // txteditpnuevo
            // 
            this.txteditpnuevo.Location = new System.Drawing.Point(254, 248);
            this.txteditpnuevo.Name = "txteditpnuevo";
            this.txteditpnuevo.Size = new System.Drawing.Size(173, 20);
            this.txteditpnuevo.TabIndex = 6;
            // 
            // txteditpactual
            // 
            this.txteditpactual.Location = new System.Drawing.Point(254, 205);
            this.txteditpactual.Name = "txteditpactual";
            this.txteditpactual.Size = new System.Drawing.Size(173, 20);
            this.txteditpactual.TabIndex = 7;
            // 
            // txteditproduc
            // 
            this.txteditproduc.Location = new System.Drawing.Point(254, 160);
            this.txteditproduc.Name = "txteditproduc";
            this.txteditproduc.Size = new System.Drawing.Size(173, 20);
            this.txteditproduc.TabIndex = 8;
            // 
            // lbleditfecha
            // 
            this.lbleditfecha.AutoSize = true;
            this.lbleditfecha.BackColor = System.Drawing.Color.Transparent;
            this.lbleditfecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditfecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbleditfecha.Location = new System.Drawing.Point(10, 299);
            this.lbleditfecha.Name = "lbleditfecha";
            this.lbleditfecha.Size = new System.Drawing.Size(127, 17);
            this.lbleditfecha.TabIndex = 9;
            this.lbleditfecha.Text = "Fecha de Ingreso:";
            // 
            // dateedit
            // 
            this.dateedit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateedit.Location = new System.Drawing.Point(254, 299);
            this.dateedit.Name = "dateedit";
            this.dateedit.Size = new System.Drawing.Size(173, 20);
            this.dateedit.TabIndex = 10;
            this.dateedit.Value = new System.DateTime(2022, 3, 13, 0, 0, 0, 0);
            // 
            // pnleditar
            // 
            this.pnleditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.pnleditar.Controls.Add(this.lbleditcodigo);
            this.pnleditar.Controls.Add(this.dateedit);
            this.pnleditar.Controls.Add(this.lbleditproducto);
            this.pnleditar.Controls.Add(this.txteditpnuevo);
            this.pnleditar.Controls.Add(this.txteditpactual);
            this.pnleditar.Controls.Add(this.txteditproduc);
            this.pnleditar.Controls.Add(this.lbleditfecha);
            this.pnleditar.Controls.Add(this.lbleditPrecio);
            this.pnleditar.Controls.Add(this.lbleditprecionuevo);
            this.pnleditar.Controls.Add(this.txtcodeditar);
            this.pnleditar.Controls.Add(this.lblSistema);
            this.pnleditar.Location = new System.Drawing.Point(2, 1);
            this.pnleditar.Name = "pnleditar";
            this.pnleditar.Size = new System.Drawing.Size(480, 449);
            this.pnleditar.TabIndex = 11;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.LightGray;
            this.btneditar.Location = new System.Drawing.Point(564, 131);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(186, 71);
            this.btneditar.TabIndex = 13;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btnvolverI
            // 
            this.btnvolverI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnvolverI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolverI.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverI.ForeColor = System.Drawing.Color.LightGray;
            this.btnvolverI.Location = new System.Drawing.Point(564, 251);
            this.btnvolverI.Name = "btnvolverI";
            this.btnvolverI.Size = new System.Drawing.Size(186, 66);
            this.btnvolverI.TabIndex = 15;
            this.btnvolverI.Text = "Volver";
            this.btnvolverI.UseVisualStyleBackColor = false;
            // 
            // frmeditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnvolverI);
            this.Controls.Add(this.pnleditar);
            this.Name = "frmeditar";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.pnleditar.ResumeLayout(false);
            this.pnleditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lbleditproducto;
        private System.Windows.Forms.Label lbleditcodigo;
        private System.Windows.Forms.Label lbleditPrecio;
        private System.Windows.Forms.Label lbleditprecionuevo;
        private System.Windows.Forms.TextBox txtcodeditar;
        private System.Windows.Forms.TextBox txteditpnuevo;
        private System.Windows.Forms.TextBox txteditpactual;
        private System.Windows.Forms.TextBox txteditproduc;
        private System.Windows.Forms.Label lbleditfecha;
        private System.Windows.Forms.DateTimePicker dateedit;
        private System.Windows.Forms.Panel pnleditar;
        private System.Windows.Forms.Button btnvolverI;
        private System.Windows.Forms.Button btneditar;
    }
}

