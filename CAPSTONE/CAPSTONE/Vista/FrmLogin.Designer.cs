namespace CAPSTONE.Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.btniniciarsesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panellogin = new System.Windows.Forms.Panel();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(407, 40);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(60, 15);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "USUARIO";
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblcontrasena.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrasena.ForeColor = System.Drawing.Color.White;
            this.lblcontrasena.Location = new System.Drawing.Point(393, 107);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(90, 15);
            this.lblcontrasena.TabIndex = 3;
            this.lblcontrasena.Text = "CONTRASEÑA";
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btniniciarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btniniciarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btniniciarsesion.BorderRadius = 7;
            this.btniniciarsesion.ButtonText = "INICIAR SESIÓN";
            this.btniniciarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciarsesion.DisabledColor = System.Drawing.Color.Gray;
            this.btniniciarsesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btniniciarsesion.Iconimage = null;
            this.btniniciarsesion.Iconimage_right = null;
            this.btniniciarsesion.Iconimage_right_Selected = null;
            this.btniniciarsesion.Iconimage_Selected = null;
            this.btniniciarsesion.IconMarginLeft = 0;
            this.btniniciarsesion.IconMarginRight = 0;
            this.btniniciarsesion.IconRightVisible = true;
            this.btniniciarsesion.IconRightZoom = 0D;
            this.btniniciarsesion.IconVisible = true;
            this.btniniciarsesion.IconZoom = 50D;
            this.btniniciarsesion.IsTab = false;
            this.btniniciarsesion.Location = new System.Drawing.Point(322, 182);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btniniciarsesion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btniniciarsesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btniniciarsesion.selected = true;
            this.btniniciarsesion.Size = new System.Drawing.Size(234, 35);
            this.btniniciarsesion.TabIndex = 6;
            this.btniniciarsesion.Text = "INICIAR SESIÓN";
            this.btniniciarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btniniciarsesion.Textcolor = System.Drawing.Color.White;
            this.btniniciarsesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panellogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panellogin.BackgroundImage")));
            this.panellogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panellogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellogin.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panellogin.Location = new System.Drawing.Point(0, 0);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(258, 263);
            this.panellogin.TabIndex = 0;
            this.panellogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panellogin_MouseDown);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(322, 58);
            this.txtcorreo.MaxLength = 9;
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(234, 25);
            this.txtcorreo.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(322, 125);
            this.textBox1.MaxLength = 9;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 25);
            this.textBox1.TabIndex = 11;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 263);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.btniniciarsesion);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcontrasena);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAYRA GARCIA - Estética Integral";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.Label lblusuario;
        private Bunifu.Framework.UI.BunifuFlatButton btniniciarsesion;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox textBox1;
    }
}