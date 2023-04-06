namespace CAPSTONE.Presentacion
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelcontenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.separadortitulo = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnmenuprincipal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnusuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnclientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnservicios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnreservas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncerrarsesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timerhorafecha = new System.Windows.Forms.Timer(this.components);
            this.panelcentral = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            this.paneltitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.panelmenu.Controls.Add(this.panelcontenedor);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(300, 683);
            this.panelmenu.TabIndex = 0;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelcontenedor.Controls.Add(this.paneltitulo);
            this.panelcontenedor.Controls.Add(this.btnmenuprincipal);
            this.panelcontenedor.Controls.Add(this.btnusuarios);
            this.panelcontenedor.Controls.Add(this.btnclientes);
            this.panelcontenedor.Controls.Add(this.btnservicios);
            this.panelcontenedor.Controls.Add(this.btnventas);
            this.panelcontenedor.Controls.Add(this.btnreservas);
            this.panelcontenedor.Controls.Add(this.btncerrarsesion);
            this.panelcontenedor.Location = new System.Drawing.Point(12, 12);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(275, 659);
            this.panelcontenedor.TabIndex = 0;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneltitulo.BackgroundImage")));
            this.paneltitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneltitulo.Controls.Add(this.separadortitulo);
            this.paneltitulo.Controls.Add(this.lbltitulo);
            this.paneltitulo.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneltitulo.Location = new System.Drawing.Point(3, 3);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(272, 198);
            this.paneltitulo.TabIndex = 0;
            // 
            // separadortitulo
            // 
            this.separadortitulo.BackColor = System.Drawing.Color.Transparent;
            this.separadortitulo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.separadortitulo.LineThickness = 1;
            this.separadortitulo.Location = new System.Drawing.Point(60, 45);
            this.separadortitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separadortitulo.Name = "separadortitulo";
            this.separadortitulo.Size = new System.Drawing.Size(135, 1);
            this.separadortitulo.TabIndex = 1;
            this.separadortitulo.Transparency = 255;
            this.separadortitulo.Vertical = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(59, 17);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(144, 20);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "MENÚ PRINCIPAL";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnmenuprincipal
            // 
            this.btnmenuprincipal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnmenuprincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnmenuprincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmenuprincipal.BorderRadius = 7;
            this.btnmenuprincipal.ButtonText = "          MENÚ PRINCIPAL";
            this.btnmenuprincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenuprincipal.DisabledColor = System.Drawing.Color.Gray;
            this.btnmenuprincipal.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuprincipal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnmenuprincipal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnmenuprincipal.Iconimage")));
            this.btnmenuprincipal.Iconimage_right = null;
            this.btnmenuprincipal.Iconimage_right_Selected = null;
            this.btnmenuprincipal.Iconimage_Selected = null;
            this.btnmenuprincipal.IconMarginLeft = 0;
            this.btnmenuprincipal.IconMarginRight = 0;
            this.btnmenuprincipal.IconRightVisible = true;
            this.btnmenuprincipal.IconRightZoom = 0D;
            this.btnmenuprincipal.IconVisible = true;
            this.btnmenuprincipal.IconZoom = 50D;
            this.btnmenuprincipal.IsTab = false;
            this.btnmenuprincipal.Location = new System.Drawing.Point(4, 207);
            this.btnmenuprincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnmenuprincipal.Name = "btnmenuprincipal";
            this.btnmenuprincipal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnmenuprincipal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnmenuprincipal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmenuprincipal.selected = true;
            this.btnmenuprincipal.Size = new System.Drawing.Size(275, 55);
            this.btnmenuprincipal.TabIndex = 0;
            this.btnmenuprincipal.Text = "          MENÚ PRINCIPAL";
            this.btnmenuprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuprincipal.Textcolor = System.Drawing.Color.White;
            this.btnmenuprincipal.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnusuarios
            // 
            this.btnusuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnusuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuarios.BorderRadius = 7;
            this.btnusuarios.ButtonText = "          USUARIOS";
            this.btnusuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnusuarios.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnusuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnusuarios.Iconimage")));
            this.btnusuarios.Iconimage_right = null;
            this.btnusuarios.Iconimage_right_Selected = null;
            this.btnusuarios.Iconimage_Selected = null;
            this.btnusuarios.IconMarginLeft = 0;
            this.btnusuarios.IconMarginRight = 0;
            this.btnusuarios.IconRightVisible = true;
            this.btnusuarios.IconRightZoom = 0D;
            this.btnusuarios.IconVisible = true;
            this.btnusuarios.IconZoom = 50D;
            this.btnusuarios.IsTab = false;
            this.btnusuarios.Location = new System.Drawing.Point(4, 268);
            this.btnusuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnusuarios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnusuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnusuarios.selected = true;
            this.btnusuarios.Size = new System.Drawing.Size(275, 55);
            this.btnusuarios.TabIndex = 1;
            this.btnusuarios.Text = "          USUARIOS";
            this.btnusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuarios.Textcolor = System.Drawing.Color.White;
            this.btnusuarios.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnclientes
            // 
            this.btnclientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnclientes.BackColor = System.Drawing.Color.Transparent;
            this.btnclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclientes.BorderRadius = 7;
            this.btnclientes.ButtonText = "          CLIENTES";
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnclientes.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnclientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnclientes.Iconimage")));
            this.btnclientes.Iconimage_right = null;
            this.btnclientes.Iconimage_right_Selected = null;
            this.btnclientes.Iconimage_Selected = null;
            this.btnclientes.IconMarginLeft = 0;
            this.btnclientes.IconMarginRight = 0;
            this.btnclientes.IconRightVisible = true;
            this.btnclientes.IconRightZoom = 0D;
            this.btnclientes.IconVisible = true;
            this.btnclientes.IconZoom = 50D;
            this.btnclientes.IsTab = false;
            this.btnclientes.Location = new System.Drawing.Point(4, 329);
            this.btnclientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnclientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnclientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnclientes.selected = true;
            this.btnclientes.Size = new System.Drawing.Size(275, 55);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "          CLIENTES";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Textcolor = System.Drawing.Color.White;
            this.btnclientes.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnservicios
            // 
            this.btnservicios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnservicios.BackColor = System.Drawing.Color.Transparent;
            this.btnservicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnservicios.BorderRadius = 7;
            this.btnservicios.ButtonText = "          SERVICIOS";
            this.btnservicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnservicios.DisabledColor = System.Drawing.Color.Gray;
            this.btnservicios.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservicios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnservicios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnservicios.Iconimage")));
            this.btnservicios.Iconimage_right = null;
            this.btnservicios.Iconimage_right_Selected = null;
            this.btnservicios.Iconimage_Selected = null;
            this.btnservicios.IconMarginLeft = 0;
            this.btnservicios.IconMarginRight = 0;
            this.btnservicios.IconRightVisible = true;
            this.btnservicios.IconRightZoom = 0D;
            this.btnservicios.IconVisible = true;
            this.btnservicios.IconZoom = 50D;
            this.btnservicios.IsTab = false;
            this.btnservicios.Location = new System.Drawing.Point(4, 390);
            this.btnservicios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnservicios.Name = "btnservicios";
            this.btnservicios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnservicios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnservicios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnservicios.selected = true;
            this.btnservicios.Size = new System.Drawing.Size(275, 55);
            this.btnservicios.TabIndex = 3;
            this.btnservicios.Text = "          SERVICIOS";
            this.btnservicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnservicios.Textcolor = System.Drawing.Color.White;
            this.btnservicios.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnventas
            // 
            this.btnventas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnventas.BackColor = System.Drawing.Color.Transparent;
            this.btnventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnventas.BorderRadius = 7;
            this.btnventas.ButtonText = "          VENTAS";
            this.btnventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnventas.DisabledColor = System.Drawing.Color.Gray;
            this.btnventas.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnventas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnventas.Iconimage")));
            this.btnventas.Iconimage_right = null;
            this.btnventas.Iconimage_right_Selected = null;
            this.btnventas.Iconimage_Selected = null;
            this.btnventas.IconMarginLeft = 0;
            this.btnventas.IconMarginRight = 0;
            this.btnventas.IconRightVisible = true;
            this.btnventas.IconRightZoom = 0D;
            this.btnventas.IconVisible = true;
            this.btnventas.IconZoom = 50D;
            this.btnventas.IsTab = false;
            this.btnventas.Location = new System.Drawing.Point(4, 451);
            this.btnventas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnventas.Name = "btnventas";
            this.btnventas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnventas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnventas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnventas.selected = true;
            this.btnventas.Size = new System.Drawing.Size(275, 55);
            this.btnventas.TabIndex = 4;
            this.btnventas.Text = "          VENTAS";
            this.btnventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Textcolor = System.Drawing.Color.White;
            this.btnventas.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnreservas
            // 
            this.btnreservas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnreservas.BackColor = System.Drawing.Color.Transparent;
            this.btnreservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreservas.BorderRadius = 7;
            this.btnreservas.ButtonText = "          RESERVAS";
            this.btnreservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreservas.DisabledColor = System.Drawing.Color.Gray;
            this.btnreservas.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnreservas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnreservas.Iconimage")));
            this.btnreservas.Iconimage_right = null;
            this.btnreservas.Iconimage_right_Selected = null;
            this.btnreservas.Iconimage_Selected = null;
            this.btnreservas.IconMarginLeft = 0;
            this.btnreservas.IconMarginRight = 0;
            this.btnreservas.IconRightVisible = true;
            this.btnreservas.IconRightZoom = 0D;
            this.btnreservas.IconVisible = true;
            this.btnreservas.IconZoom = 50D;
            this.btnreservas.IsTab = false;
            this.btnreservas.Location = new System.Drawing.Point(4, 512);
            this.btnreservas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnreservas.Name = "btnreservas";
            this.btnreservas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnreservas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnreservas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnreservas.selected = true;
            this.btnreservas.Size = new System.Drawing.Size(275, 55);
            this.btnreservas.TabIndex = 5;
            this.btnreservas.Text = "          RESERVAS";
            this.btnreservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreservas.Textcolor = System.Drawing.Color.White;
            this.btnreservas.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncerrarsesion.BackColor = System.Drawing.Color.Transparent;
            this.btncerrarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrarsesion.BorderRadius = 7;
            this.btncerrarsesion.ButtonText = "          CERRAR SESIÓN";
            this.btncerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrarsesion.DisabledColor = System.Drawing.Color.Gray;
            this.btncerrarsesion.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarsesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btncerrarsesion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncerrarsesion.Iconimage")));
            this.btncerrarsesion.Iconimage_right = null;
            this.btncerrarsesion.Iconimage_right_Selected = null;
            this.btncerrarsesion.Iconimage_Selected = null;
            this.btncerrarsesion.IconMarginLeft = 0;
            this.btncerrarsesion.IconMarginRight = 0;
            this.btncerrarsesion.IconRightVisible = true;
            this.btncerrarsesion.IconRightZoom = 0D;
            this.btncerrarsesion.IconVisible = true;
            this.btncerrarsesion.IconZoom = 50D;
            this.btncerrarsesion.IsTab = false;
            this.btncerrarsesion.Location = new System.Drawing.Point(4, 573);
            this.btncerrarsesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Normalcolor = System.Drawing.Color.Transparent;
            this.btncerrarsesion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncerrarsesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btncerrarsesion.selected = true;
            this.btncerrarsesion.Size = new System.Drawing.Size(275, 55);
            this.btncerrarsesion.TabIndex = 6;
            this.btncerrarsesion.Text = "          CERRAR SESIÓN";
            this.btncerrarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrarsesion.Textcolor = System.Drawing.Color.White;
            this.btncerrarsesion.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timerhorafecha
            // 
            this.timerhorafecha.Enabled = true;
            // 
            // panelcentral
            // 
            this.panelcentral.BackColor = System.Drawing.Color.Transparent;
            this.panelcentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcentral.BackgroundImage")));
            this.panelcentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(300, 0);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(726, 683);
            this.panelcentral.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1026, 683);
            this.Controls.Add(this.panelcentral);
            this.Controls.Add(this.panelmenu);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAYRA GARCIA - Estética Integral";
            this.panelmenu.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.FlowLayoutPanel panelcontenedor;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label lbltitulo;
        private Bunifu.Framework.UI.BunifuSeparator separadortitulo;
        private Bunifu.Framework.UI.BunifuFlatButton btnmenuprincipal;
        private System.Windows.Forms.Panel panelcentral;
        private System.Windows.Forms.Timer timerhorafecha;
        private Bunifu.Framework.UI.BunifuFlatButton btnusuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btnclientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnservicios;
        private Bunifu.Framework.UI.BunifuFlatButton btnventas;
        private Bunifu.Framework.UI.BunifuFlatButton btnreservas;
        private Bunifu.Framework.UI.BunifuFlatButton btncerrarsesion;
    }
}