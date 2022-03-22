
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.pnllogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnllogin
            // 
            this.pnllogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.pnllogin.Controls.Add(this.btncrear);
            this.pnllogin.Controls.Add(this.pictureBox1);
            this.pnllogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnllogin.Location = new System.Drawing.Point(0, 0);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(266, 510);
            this.pnllogin.TabIndex = 2;
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
            // btncrear
            // 
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btncrear.Location = new System.Drawing.Point(26, 180);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(220, 133);
            this.btncrear.TabIndex = 3;
            this.btncrear.Text = "button1";
            this.btncrear.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}