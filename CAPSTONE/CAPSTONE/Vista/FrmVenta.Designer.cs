namespace CAPSTONE.Vista
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupboxventa = new System.Windows.Forms.GroupBox();
            this.btneliminarservicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnagregarservicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.lblmontototal = new System.Windows.Forms.Label();
            this.lblapellidoscliente = new System.Windows.Forms.Label();
            this.btnsearchservicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsearchcliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtapellidoscliente = new System.Windows.Forms.TextBox();
            this.txtnombrescliente = new System.Windows.Forms.TextBox();
            this.txtservicio = new System.Windows.Forms.TextBox();
            this.lblnombrescliente = new System.Windows.Forms.Label();
            this.lblservicio = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnsalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.datagridservicio = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupboxventa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridservicio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxventa
            // 
            this.groupboxventa.BackColor = System.Drawing.Color.Transparent;
            this.groupboxventa.Controls.Add(this.btneliminarservicio);
            this.groupboxventa.Controls.Add(this.btnagregarservicio);
            this.groupboxventa.Controls.Add(this.txtmontototal);
            this.groupboxventa.Controls.Add(this.lblmontototal);
            this.groupboxventa.Controls.Add(this.lblapellidoscliente);
            this.groupboxventa.Controls.Add(this.btnsearchservicio);
            this.groupboxventa.Controls.Add(this.btnsearchcliente);
            this.groupboxventa.Controls.Add(this.txtapellidoscliente);
            this.groupboxventa.Controls.Add(this.txtnombrescliente);
            this.groupboxventa.Controls.Add(this.txtservicio);
            this.groupboxventa.Controls.Add(this.lblnombrescliente);
            this.groupboxventa.Controls.Add(this.lblservicio);
            this.groupboxventa.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxventa.ForeColor = System.Drawing.Color.White;
            this.groupboxventa.Location = new System.Drawing.Point(12, 12);
            this.groupboxventa.Name = "groupboxventa";
            this.groupboxventa.Size = new System.Drawing.Size(686, 223);
            this.groupboxventa.TabIndex = 2;
            this.groupboxventa.TabStop = false;
            this.groupboxventa.Text = "DATOS DE LA VENTA";
            // 
            // btneliminarservicio
            // 
            this.btneliminarservicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminarservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminarservicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminarservicio.BorderRadius = 7;
            this.btneliminarservicio.ButtonText = "Eliminar Servicio";
            this.btneliminarservicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarservicio.DisabledColor = System.Drawing.Color.Gray;
            this.btneliminarservicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btneliminarservicio.Iconimage = null;
            this.btneliminarservicio.Iconimage_right = null;
            this.btneliminarservicio.Iconimage_right_Selected = null;
            this.btneliminarservicio.Iconimage_Selected = null;
            this.btneliminarservicio.IconMarginLeft = 0;
            this.btneliminarservicio.IconMarginRight = 0;
            this.btneliminarservicio.IconRightVisible = true;
            this.btneliminarservicio.IconRightZoom = 0D;
            this.btneliminarservicio.IconVisible = true;
            this.btneliminarservicio.IconZoom = 50D;
            this.btneliminarservicio.IsTab = false;
            this.btneliminarservicio.Location = new System.Drawing.Point(344, 170);
            this.btneliminarservicio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btneliminarservicio.Name = "btneliminarservicio";
            this.btneliminarservicio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminarservicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminarservicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminarservicio.selected = true;
            this.btneliminarservicio.Size = new System.Drawing.Size(129, 33);
            this.btneliminarservicio.TabIndex = 50;
            this.btneliminarservicio.Text = "Eliminar Servicio";
            this.btneliminarservicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneliminarservicio.Textcolor = System.Drawing.Color.White;
            this.btneliminarservicio.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnagregarservicio
            // 
            this.btnagregarservicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnagregarservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnagregarservicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarservicio.BorderRadius = 7;
            this.btnagregarservicio.ButtonText = "Agregar Servicio";
            this.btnagregarservicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarservicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnagregarservicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnagregarservicio.Iconimage = null;
            this.btnagregarservicio.Iconimage_right = null;
            this.btnagregarservicio.Iconimage_right_Selected = null;
            this.btnagregarservicio.Iconimage_Selected = null;
            this.btnagregarservicio.IconMarginLeft = 0;
            this.btnagregarservicio.IconMarginRight = 0;
            this.btnagregarservicio.IconRightVisible = true;
            this.btnagregarservicio.IconRightZoom = 0D;
            this.btnagregarservicio.IconVisible = true;
            this.btnagregarservicio.IconZoom = 50D;
            this.btnagregarservicio.IsTab = false;
            this.btnagregarservicio.Location = new System.Drawing.Point(188, 170);
            this.btnagregarservicio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnagregarservicio.Name = "btnagregarservicio";
            this.btnagregarservicio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnagregarservicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnagregarservicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnagregarservicio.selected = true;
            this.btnagregarservicio.Size = new System.Drawing.Size(134, 33);
            this.btnagregarservicio.TabIndex = 49;
            this.btnagregarservicio.Text = "Agregar Servicio";
            this.btnagregarservicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnagregarservicio.Textcolor = System.Drawing.Color.White;
            this.btnagregarservicio.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtmontototal
            // 
            this.txtmontototal.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontototal.Location = new System.Drawing.Point(533, 121);
            this.txtmontototal.MaxLength = 8;
            this.txtmontototal.Multiline = true;
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.Size = new System.Drawing.Size(114, 25);
            this.txtmontototal.TabIndex = 18;
            // 
            // lblmontototal
            // 
            this.lblmontototal.AutoSize = true;
            this.lblmontototal.BackColor = System.Drawing.Color.Transparent;
            this.lblmontototal.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontototal.ForeColor = System.Drawing.Color.White;
            this.lblmontototal.Location = new System.Drawing.Point(529, 99);
            this.lblmontototal.Name = "lblmontototal";
            this.lblmontototal.Size = new System.Drawing.Size(118, 15);
            this.lblmontototal.TabIndex = 17;
            this.lblmontototal.Text = "Monto Total (Soles)";
            // 
            // lblapellidoscliente
            // 
            this.lblapellidoscliente.AutoSize = true;
            this.lblapellidoscliente.BackColor = System.Drawing.Color.Transparent;
            this.lblapellidoscliente.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidoscliente.ForeColor = System.Drawing.Color.White;
            this.lblapellidoscliente.Location = new System.Drawing.Point(263, 33);
            this.lblapellidoscliente.Name = "lblapellidoscliente";
            this.lblapellidoscliente.Size = new System.Drawing.Size(125, 15);
            this.lblapellidoscliente.TabIndex = 15;
            this.lblapellidoscliente.Text = "Apellidos del Cliente";
            // 
            // btnsearchservicio
            // 
            this.btnsearchservicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnsearchservicio.BackColor = System.Drawing.Color.Transparent;
            this.btnsearchservicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearchservicio.BackgroundImage")));
            this.btnsearchservicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsearchservicio.BorderRadius = 7;
            this.btnsearchservicio.ButtonText = "";
            this.btnsearchservicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearchservicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnsearchservicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsearchservicio.Iconimage = null;
            this.btnsearchservicio.Iconimage_right = null;
            this.btnsearchservicio.Iconimage_right_Selected = null;
            this.btnsearchservicio.Iconimage_Selected = null;
            this.btnsearchservicio.IconMarginLeft = 0;
            this.btnsearchservicio.IconMarginRight = 0;
            this.btnsearchservicio.IconRightVisible = true;
            this.btnsearchservicio.IconRightZoom = 0D;
            this.btnsearchservicio.IconVisible = true;
            this.btnsearchservicio.IconZoom = 50D;
            this.btnsearchservicio.IsTab = false;
            this.btnsearchservicio.Location = new System.Drawing.Point(482, 121);
            this.btnsearchservicio.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnsearchservicio.Name = "btnsearchservicio";
            this.btnsearchservicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnsearchservicio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnsearchservicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsearchservicio.selected = true;
            this.btnsearchservicio.Size = new System.Drawing.Size(26, 27);
            this.btnsearchservicio.TabIndex = 12;
            this.btnsearchservicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearchservicio.Textcolor = System.Drawing.Color.White;
            this.btnsearchservicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnsearchcliente
            // 
            this.btnsearchcliente.Activecolor = System.Drawing.Color.Transparent;
            this.btnsearchcliente.BackColor = System.Drawing.Color.Transparent;
            this.btnsearchcliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearchcliente.BackgroundImage")));
            this.btnsearchcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsearchcliente.BorderRadius = 7;
            this.btnsearchcliente.ButtonText = "";
            this.btnsearchcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearchcliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnsearchcliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsearchcliente.Iconimage = null;
            this.btnsearchcliente.Iconimage_right = null;
            this.btnsearchcliente.Iconimage_right_Selected = null;
            this.btnsearchcliente.Iconimage_Selected = null;
            this.btnsearchcliente.IconMarginLeft = 0;
            this.btnsearchcliente.IconMarginRight = 0;
            this.btnsearchcliente.IconRightVisible = true;
            this.btnsearchcliente.IconRightZoom = 0D;
            this.btnsearchcliente.IconVisible = true;
            this.btnsearchcliente.IconZoom = 50D;
            this.btnsearchcliente.IsTab = false;
            this.btnsearchcliente.Location = new System.Drawing.Point(482, 55);
            this.btnsearchcliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnsearchcliente.Name = "btnsearchcliente";
            this.btnsearchcliente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnsearchcliente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnsearchcliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsearchcliente.selected = true;
            this.btnsearchcliente.Size = new System.Drawing.Size(26, 27);
            this.btnsearchcliente.TabIndex = 5;
            this.btnsearchcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearchcliente.Textcolor = System.Drawing.Color.White;
            this.btnsearchcliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtapellidoscliente
            // 
            this.txtapellidoscliente.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidoscliente.Location = new System.Drawing.Point(266, 55);
            this.txtapellidoscliente.MaxLength = 8;
            this.txtapellidoscliente.Multiline = true;
            this.txtapellidoscliente.Name = "txtapellidoscliente";
            this.txtapellidoscliente.ReadOnly = true;
            this.txtapellidoscliente.Size = new System.Drawing.Size(207, 25);
            this.txtapellidoscliente.TabIndex = 4;
            // 
            // txtnombrescliente
            // 
            this.txtnombrescliente.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrescliente.Location = new System.Drawing.Point(36, 55);
            this.txtnombrescliente.MaxLength = 8;
            this.txtnombrescliente.Multiline = true;
            this.txtnombrescliente.Name = "txtnombrescliente";
            this.txtnombrescliente.ReadOnly = true;
            this.txtnombrescliente.Size = new System.Drawing.Size(207, 25);
            this.txtnombrescliente.TabIndex = 3;
            // 
            // txtservicio
            // 
            this.txtservicio.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservicio.Location = new System.Drawing.Point(36, 121);
            this.txtservicio.MaxLength = 8;
            this.txtservicio.Multiline = true;
            this.txtservicio.Name = "txtservicio";
            this.txtservicio.ReadOnly = true;
            this.txtservicio.Size = new System.Drawing.Size(437, 25);
            this.txtservicio.TabIndex = 7;
            // 
            // lblnombrescliente
            // 
            this.lblnombrescliente.AutoSize = true;
            this.lblnombrescliente.BackColor = System.Drawing.Color.Transparent;
            this.lblnombrescliente.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrescliente.ForeColor = System.Drawing.Color.White;
            this.lblnombrescliente.Location = new System.Drawing.Point(32, 33);
            this.lblnombrescliente.Name = "lblnombrescliente";
            this.lblnombrescliente.Size = new System.Drawing.Size(125, 15);
            this.lblnombrescliente.TabIndex = 2;
            this.lblnombrescliente.Text = "Nombres del Cliente";
            // 
            // lblservicio
            // 
            this.lblservicio.AutoSize = true;
            this.lblservicio.BackColor = System.Drawing.Color.Transparent;
            this.lblservicio.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicio.ForeColor = System.Drawing.Color.White;
            this.lblservicio.Location = new System.Drawing.Point(32, 99);
            this.lblservicio.Name = "lblservicio";
            this.lblservicio.Size = new System.Drawing.Size(51, 15);
            this.lblservicio.TabIndex = 6;
            this.lblservicio.Text = "Servicio";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(275, 328);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(220, 25);
            this.txtbuscar.TabIndex = 48;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblbuscar.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.ForeColor = System.Drawing.Color.White;
            this.lblbuscar.Location = new System.Drawing.Point(223, 331);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(46, 15);
            this.lblbuscar.TabIndex = 47;
            this.lblbuscar.Text = "Buscar";
            // 
            // btnsalir
            // 
            this.btnsalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.BorderRadius = 7;
            this.btnsalir.ButtonText = "Salir";
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnsalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsalir.Iconimage = null;
            this.btnsalir.Iconimage_right = null;
            this.btnsalir.Iconimage_right_Selected = null;
            this.btnsalir.Iconimage_Selected = null;
            this.btnsalir.IconMarginLeft = 0;
            this.btnsalir.IconMarginRight = 0;
            this.btnsalir.IconRightVisible = true;
            this.btnsalir.IconRightZoom = 0D;
            this.btnsalir.IconVisible = true;
            this.btnsalir.IconZoom = 50D;
            this.btnsalir.IsTab = false;
            this.btnsalir.Location = new System.Drawing.Point(581, 262);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsalir.selected = true;
            this.btnsalir.Size = new System.Drawing.Size(105, 33);
            this.btnsalir.TabIndex = 46;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsalir.Textcolor = System.Drawing.Color.White;
            this.btnsalir.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnguardar
            // 
            this.btnguardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.BorderRadius = 7;
            this.btnguardar.ButtonText = "Guardar";
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnguardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguardar.Iconimage = null;
            this.btnguardar.Iconimage_right = null;
            this.btnguardar.Iconimage_right_Selected = null;
            this.btnguardar.Iconimage_Selected = null;
            this.btnguardar.IconMarginLeft = 0;
            this.btnguardar.IconMarginRight = 0;
            this.btnguardar.IconRightVisible = true;
            this.btnguardar.IconRightZoom = 0D;
            this.btnguardar.IconVisible = true;
            this.btnguardar.IconZoom = 50D;
            this.btnguardar.IsTab = false;
            this.btnguardar.Location = new System.Drawing.Point(133, 262);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = true;
            this.btnguardar.Size = new System.Drawing.Size(105, 33);
            this.btnguardar.TabIndex = 45;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnguardar.Textcolor = System.Drawing.Color.White;
            this.btnguardar.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btneditar
            // 
            this.btneditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditar.BorderRadius = 7;
            this.btneditar.ButtonText = "Editar";
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.DisabledColor = System.Drawing.Color.Gray;
            this.btneditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneditar.Iconimage = null;
            this.btneditar.Iconimage_right = null;
            this.btneditar.Iconimage_right_Selected = null;
            this.btneditar.Iconimage_Selected = null;
            this.btneditar.IconMarginLeft = 0;
            this.btneditar.IconMarginRight = 0;
            this.btneditar.IconRightVisible = true;
            this.btneditar.IconRightZoom = 0D;
            this.btneditar.IconVisible = true;
            this.btneditar.IconZoom = 50D;
            this.btneditar.IsTab = false;
            this.btneditar.Location = new System.Drawing.Point(357, 262);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneditar.Name = "btneditar";
            this.btneditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneditar.selected = true;
            this.btneditar.Size = new System.Drawing.Size(105, 33);
            this.btneditar.TabIndex = 43;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneditar.Textcolor = System.Drawing.Color.White;
            this.btneditar.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btncancelar
            // 
            this.btncancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.BorderRadius = 7;
            this.btncancelar.ButtonText = "Cancelar";
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btncancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btncancelar.Iconimage = null;
            this.btncancelar.Iconimage_right = null;
            this.btncancelar.Iconimage_right_Selected = null;
            this.btncancelar.Iconimage_Selected = null;
            this.btncancelar.IconMarginLeft = 0;
            this.btncancelar.IconMarginRight = 0;
            this.btncancelar.IconRightVisible = true;
            this.btncancelar.IconRightZoom = 0D;
            this.btncancelar.IconVisible = true;
            this.btncancelar.IconZoom = 50D;
            this.btncancelar.IsTab = false;
            this.btncancelar.Location = new System.Drawing.Point(245, 262);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancelar.selected = true;
            this.btncancelar.Size = new System.Drawing.Size(105, 33);
            this.btncancelar.TabIndex = 42;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancelar.Textcolor = System.Drawing.Color.White;
            this.btncancelar.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btneliminar
            // 
            this.btneliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.BorderRadius = 7;
            this.btneliminar.ButtonText = "Eliminar";
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btneliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneliminar.Iconimage = null;
            this.btneliminar.Iconimage_right = null;
            this.btneliminar.Iconimage_right_Selected = null;
            this.btneliminar.Iconimage_Selected = null;
            this.btneliminar.IconMarginLeft = 0;
            this.btneliminar.IconMarginRight = 0;
            this.btneliminar.IconRightVisible = true;
            this.btneliminar.IconRightZoom = 0D;
            this.btneliminar.IconVisible = true;
            this.btneliminar.IconZoom = 50D;
            this.btneliminar.IsTab = false;
            this.btneliminar.Location = new System.Drawing.Point(469, 262);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = true;
            this.btneliminar.Size = new System.Drawing.Size(105, 33);
            this.btneliminar.TabIndex = 44;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneliminar.Textcolor = System.Drawing.Color.White;
            this.btneliminar.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnnuevo
            // 
            this.btnnuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.BorderRadius = 7;
            this.btnnuevo.ButtonText = "Nuevo";
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnnuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnuevo.Iconimage = null;
            this.btnnuevo.Iconimage_right = null;
            this.btnnuevo.Iconimage_right_Selected = null;
            this.btnnuevo.Iconimage_Selected = null;
            this.btnnuevo.IconMarginLeft = 0;
            this.btnnuevo.IconMarginRight = 0;
            this.btnnuevo.IconRightVisible = true;
            this.btnnuevo.IconRightZoom = 0D;
            this.btnnuevo.IconVisible = true;
            this.btnnuevo.IconZoom = 50D;
            this.btnnuevo.IsTab = false;
            this.btnnuevo.Location = new System.Drawing.Point(21, 262);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnuevo.selected = true;
            this.btnnuevo.Size = new System.Drawing.Size(105, 33);
            this.btnnuevo.TabIndex = 41;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnuevo.Textcolor = System.Drawing.Color.White;
            this.btnnuevo.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // datagridservicio
            // 
            this.datagridservicio.AllowUserToAddRows = false;
            this.datagridservicio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridservicio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridservicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridservicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridservicio.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridservicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridservicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridservicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridservicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridservicio.DoubleBuffered = true;
            this.datagridservicio.EnableHeadersVisualStyles = false;
            this.datagridservicio.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.datagridservicio.HeaderForeColor = System.Drawing.Color.White;
            this.datagridservicio.Location = new System.Drawing.Point(12, 373);
            this.datagridservicio.Name = "datagridservicio";
            this.datagridservicio.ReadOnly = true;
            this.datagridservicio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridservicio.Size = new System.Drawing.Size(686, 259);
            this.datagridservicio.TabIndex = 40;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 644);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.datagridservicio);
            this.Controls.Add(this.groupboxventa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.groupboxventa.ResumeLayout(false);
            this.groupboxventa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridservicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxventa;
        private System.Windows.Forms.Label lblapellidoscliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnsearchservicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnsearchcliente;
        private System.Windows.Forms.TextBox txtapellidoscliente;
        private System.Windows.Forms.TextBox txtnombrescliente;
        private System.Windows.Forms.TextBox txtservicio;
        private System.Windows.Forms.Label lblnombrescliente;
        private System.Windows.Forms.Label lblservicio;
        private System.Windows.Forms.TextBox txtmontototal;
        private System.Windows.Forms.Label lblmontototal;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private Bunifu.Framework.UI.BunifuFlatButton btneditar;
        private Bunifu.Framework.UI.BunifuFlatButton btncancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnnuevo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridservicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnagregarservicio;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminarservicio;
    }
}