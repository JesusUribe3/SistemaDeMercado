
namespace Sistema_de_Mercado
{
    partial class frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.pnllogin = new System.Windows.Forms.Panel();
            this.btnprincrear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnprineditar = new System.Windows.Forms.Button();
            this.btnprineliminar = new System.Windows.Forms.Button();
            this.btnprinsalir = new System.Windows.Forms.Button();
            this.pnllogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnllogin
            // 
            this.pnllogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.pnllogin.Controls.Add(this.btnprinsalir);
            this.pnllogin.Controls.Add(this.btnprineliminar);
            this.pnllogin.Controls.Add(this.btnprineditar);
            this.pnllogin.Controls.Add(this.btnprincrear);
            this.pnllogin.Controls.Add(this.pictureBox1);
            this.pnllogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnllogin.Location = new System.Drawing.Point(0, 0);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(266, 510);
            this.pnllogin.TabIndex = 2;
            // 
            // btnprincrear
            // 
            this.btnprincrear.FlatAppearance.BorderSize = 0;
            this.btnprincrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprincrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprincrear.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprincrear.Image = ((System.Drawing.Image)(resources.GetObject("btnprincrear.Image")));
            this.btnprincrear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnprincrear.Location = new System.Drawing.Point(-3, 148);
            this.btnprincrear.Name = "btnprincrear";
            this.btnprincrear.Size = new System.Drawing.Size(266, 74);
            this.btnprincrear.TabIndex = 3;
            this.btnprincrear.Text = "Crear";
            this.btnprincrear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnprineditar
            // 
            this.btnprineditar.FlatAppearance.BorderSize = 0;
            this.btnprineditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprineditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprineditar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprineditar.Image = ((System.Drawing.Image)(resources.GetObject("btnprineditar.Image")));
            this.btnprineditar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnprineditar.Location = new System.Drawing.Point(-3, 218);
            this.btnprineditar.Name = "btnprineditar";
            this.btnprineditar.Size = new System.Drawing.Size(266, 74);
            this.btnprineditar.TabIndex = 4;
            this.btnprineditar.Text = "Editar";
            this.btnprineditar.UseVisualStyleBackColor = true;
            // 
            // btnprineliminar
            // 
            this.btnprineliminar.FlatAppearance.BorderSize = 0;
            this.btnprineliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprineliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprineliminar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprineliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnprineliminar.Image")));
            this.btnprineliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnprineliminar.Location = new System.Drawing.Point(0, 298);
            this.btnprineliminar.Name = "btnprineliminar";
            this.btnprineliminar.Size = new System.Drawing.Size(266, 74);
            this.btnprineliminar.TabIndex = 5;
            this.btnprineliminar.Text = "Eliminar";
            this.btnprineliminar.UseVisualStyleBackColor = true;
            this.btnprineliminar.Click += new System.EventHandler(this.btnprineliminar_Click);
            // 
            // btnprinsalir
            // 
            this.btnprinsalir.FlatAppearance.BorderSize = 0;
            this.btnprinsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprinsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprinsalir.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprinsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnprinsalir.Image")));
            this.btnprinsalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnprinsalir.Location = new System.Drawing.Point(0, 424);
            this.btnprinsalir.Name = "btnprinsalir";
            this.btnprinsalir.Size = new System.Drawing.Size(266, 74);
            this.btnprinsalir.TabIndex = 6;
            this.btnprinsalir.Text = "Cerrar";
            this.btnprinsalir.UseVisualStyleBackColor = true;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 510);
            this.Controls.Add(this.pnllogin);
            this.Name = "frmprincipal";
            this.Text = "frmprincipal";
            this.pnllogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.Button btnprincrear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnprinsalir;
        private System.Windows.Forms.Button btnprineliminar;
        private System.Windows.Forms.Button btnprineditar;
    }
}