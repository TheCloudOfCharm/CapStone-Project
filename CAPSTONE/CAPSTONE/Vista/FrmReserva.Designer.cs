namespace CAPSTONE.Vista
{
    partial class FrmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserva));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupboxreserva = new System.Windows.Forms.GroupBox();
            this.btnsearchcliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.datefechareserva = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtdiagnostico = new System.Windows.Forms.TextBox();
            this.txtapellidoscliente = new System.Windows.Forms.TextBox();
            this.lblfechareserva = new System.Windows.Forms.Label();
            this.txtnombrescliente = new System.Windows.Forms.TextBox();
            this.txtservicio = new System.Windows.Forms.TextBox();
            this.lblnombrescliente = new System.Windows.Forms.Label();
            this.lbldiagnostico = new System.Windows.Forms.Label();
            this.lblservicio = new System.Windows.Forms.Label();
            this.btnsearchservicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblapellidoscliente = new System.Windows.Forms.Label();
            this.lblasistencia = new System.Windows.Forms.Label();
            this.comboboxasistencia = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnsalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.datagridreserva = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupboxreserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridreserva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxreserva
            // 
            this.groupboxreserva.BackColor = System.Drawing.Color.Transparent;
            this.groupboxreserva.Controls.Add(this.lblasistencia);
            this.groupboxreserva.Controls.Add(this.comboboxasistencia);
            this.groupboxreserva.Controls.Add(this.lblapellidoscliente);
            this.groupboxreserva.Controls.Add(this.btnsearchservicio);
            this.groupboxreserva.Controls.Add(this.datefechareserva);
            this.groupboxreserva.Controls.Add(this.lblfechareserva);
            this.groupboxreserva.Controls.Add(this.btnsearchcliente);
            this.groupboxreserva.Controls.Add(this.txtapellidoscliente);
            this.groupboxreserva.Controls.Add(this.txtnombrescliente);
            this.groupboxreserva.Controls.Add(this.txtservicio);
            this.groupboxreserva.Controls.Add(this.lbldiagnostico);
            this.groupboxreserva.Controls.Add(this.lblnombrescliente);
            this.groupboxreserva.Controls.Add(this.lblservicio);
            this.groupboxreserva.Controls.Add(this.txtdiagnostico);
            this.groupboxreserva.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxreserva.ForeColor = System.Drawing.Color.White;
            this.groupboxreserva.Location = new System.Drawing.Point(12, 12);
            this.groupboxreserva.Name = "groupboxreserva";
            this.groupboxreserva.Size = new System.Drawing.Size(686, 260);
            this.groupboxreserva.TabIndex = 1;
            this.groupboxreserva.TabStop = false;
            this.groupboxreserva.Text = "DATOS DE LA RESERVA";
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
            this.btnsearchcliente.Location = new System.Drawing.Point(480, 55);
            this.btnsearchcliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsearchcliente.Name = "btnsearchcliente";
            this.btnsearchcliente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnsearchcliente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnsearchcliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsearchcliente.selected = true;
            this.btnsearchcliente.Size = new System.Drawing.Size(26, 26);
            this.btnsearchcliente.TabIndex = 5;
            this.btnsearchcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearchcliente.Textcolor = System.Drawing.Color.White;
            this.btnsearchcliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchcliente.Click += new System.EventHandler(this.btnsearchcliente_Click);
            // 
            // datefechareserva
            // 
            this.datefechareserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.datefechareserva.BorderRadius = 0;
            this.datefechareserva.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefechareserva.ForeColor = System.Drawing.Color.White;
            this.datefechareserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefechareserva.FormatCustom = null;
            this.datefechareserva.Location = new System.Drawing.Point(496, 122);
            this.datefechareserva.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.datefechareserva.Name = "datefechareserva";
            this.datefechareserva.Size = new System.Drawing.Size(160, 26);
            this.datefechareserva.TabIndex = 14;
            this.datefechareserva.Value = new System.DateTime(2021, 10, 23, 1, 40, 14, 377);
            // 
            // txtdiagnostico
            // 
            this.txtdiagnostico.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagnostico.Location = new System.Drawing.Point(36, 122);
            this.txtdiagnostico.Multiline = true;
            this.txtdiagnostico.Name = "txtdiagnostico";
            this.txtdiagnostico.ReadOnly = true;
            this.txtdiagnostico.Size = new System.Drawing.Size(437, 25);
            this.txtdiagnostico.TabIndex = 11;
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
            // lblfechareserva
            // 
            this.lblfechareserva.AutoSize = true;
            this.lblfechareserva.BackColor = System.Drawing.Color.Transparent;
            this.lblfechareserva.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechareserva.ForeColor = System.Drawing.Color.White;
            this.lblfechareserva.Location = new System.Drawing.Point(494, 99);
            this.lblfechareserva.Name = "lblfechareserva";
            this.lblfechareserva.Size = new System.Drawing.Size(107, 15);
            this.lblfechareserva.TabIndex = 13;
            this.lblfechareserva.Text = "Fecha de Reserva";
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
            this.txtservicio.Location = new System.Drawing.Point(36, 188);
            this.txtservicio.MaxLength = 8;
            this.txtservicio.Multiline = true;
            this.txtservicio.Name = "txtservicio";
            this.txtservicio.ReadOnly = true;
            this.txtservicio.Size = new System.Drawing.Size(403, 25);
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
            // lbldiagnostico
            // 
            this.lbldiagnostico.AutoSize = true;
            this.lbldiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.lbldiagnostico.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiagnostico.ForeColor = System.Drawing.Color.White;
            this.lbldiagnostico.Location = new System.Drawing.Point(33, 100);
            this.lbldiagnostico.Name = "lbldiagnostico";
            this.lbldiagnostico.Size = new System.Drawing.Size(77, 15);
            this.lbldiagnostico.TabIndex = 10;
            this.lbldiagnostico.Text = "Diagnóstico";
            // 
            // lblservicio
            // 
            this.lblservicio.AutoSize = true;
            this.lblservicio.BackColor = System.Drawing.Color.Transparent;
            this.lblservicio.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicio.ForeColor = System.Drawing.Color.White;
            this.lblservicio.Location = new System.Drawing.Point(32, 166);
            this.lblservicio.Name = "lblservicio";
            this.lblservicio.Size = new System.Drawing.Size(51, 15);
            this.lblservicio.TabIndex = 6;
            this.lblservicio.Text = "Servicio";
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
            this.btnsearchservicio.Location = new System.Drawing.Point(447, 188);
            this.btnsearchservicio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnsearchservicio.Name = "btnsearchservicio";
            this.btnsearchservicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnsearchservicio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnsearchservicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsearchservicio.selected = true;
            this.btnsearchservicio.Size = new System.Drawing.Size(26, 26);
            this.btnsearchservicio.TabIndex = 12;
            this.btnsearchservicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearchservicio.Textcolor = System.Drawing.Color.White;
            this.btnsearchservicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lblasistencia
            // 
            this.lblasistencia.AutoSize = true;
            this.lblasistencia.BackColor = System.Drawing.Color.Transparent;
            this.lblasistencia.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasistencia.ForeColor = System.Drawing.Color.White;
            this.lblasistencia.Location = new System.Drawing.Point(487, 171);
            this.lblasistencia.Name = "lblasistencia";
            this.lblasistencia.Size = new System.Drawing.Size(64, 15);
            this.lblasistencia.TabIndex = 16;
            this.lblasistencia.Text = "Asistencia";
            // 
            // comboboxasistencia
            // 
            this.comboboxasistencia.FormattingEnabled = true;
            this.comboboxasistencia.Items.AddRange(new object[] {
            "Pendiente",
            "Asistió",
            "No Asistió"});
            this.comboboxasistencia.Location = new System.Drawing.Point(491, 191);
            this.comboboxasistencia.Name = "comboboxasistencia";
            this.comboboxasistencia.Size = new System.Drawing.Size(165, 23);
            this.comboboxasistencia.TabIndex = 17;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(275, 362);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(220, 25);
            this.txtbuscar.TabIndex = 39;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblbuscar.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.ForeColor = System.Drawing.Color.White;
            this.lblbuscar.Location = new System.Drawing.Point(223, 365);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(46, 15);
            this.lblbuscar.TabIndex = 38;
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
            this.btnsalir.Location = new System.Drawing.Point(581, 296);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsalir.selected = true;
            this.btnsalir.Size = new System.Drawing.Size(105, 33);
            this.btnsalir.TabIndex = 37;
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
            this.btnguardar.Location = new System.Drawing.Point(133, 296);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = true;
            this.btnguardar.Size = new System.Drawing.Size(105, 33);
            this.btnguardar.TabIndex = 36;
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
            this.btneditar.Location = new System.Drawing.Point(357, 296);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneditar.Name = "btneditar";
            this.btneditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneditar.selected = true;
            this.btneditar.Size = new System.Drawing.Size(105, 33);
            this.btneditar.TabIndex = 34;
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
            this.btncancelar.Location = new System.Drawing.Point(245, 296);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancelar.selected = true;
            this.btncancelar.Size = new System.Drawing.Size(105, 33);
            this.btncancelar.TabIndex = 33;
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
            this.btneliminar.Location = new System.Drawing.Point(469, 296);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = true;
            this.btneliminar.Size = new System.Drawing.Size(105, 33);
            this.btneliminar.TabIndex = 35;
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
            this.btnnuevo.Location = new System.Drawing.Point(21, 296);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnuevo.selected = true;
            this.btnnuevo.Size = new System.Drawing.Size(105, 33);
            this.btnnuevo.TabIndex = 32;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnuevo.Textcolor = System.Drawing.Color.White;
            this.btnnuevo.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // datagridreserva
            // 
            this.datagridreserva.AllowUserToAddRows = false;
            this.datagridreserva.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridreserva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridreserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridreserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridreserva.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridreserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridreserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridreserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridreserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridreserva.DoubleBuffered = true;
            this.datagridreserva.EnableHeadersVisualStyles = false;
            this.datagridreserva.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.datagridreserva.HeaderForeColor = System.Drawing.Color.White;
            this.datagridreserva.Location = new System.Drawing.Point(12, 409);
            this.datagridreserva.Name = "datagridreserva";
            this.datagridreserva.ReadOnly = true;
            this.datagridreserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridreserva.Size = new System.Drawing.Size(686, 223);
            this.datagridreserva.TabIndex = 31;
            // 
            // FrmReserva
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
            this.Controls.Add(this.datagridreserva);
            this.Controls.Add(this.groupboxreserva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReserva";
            this.Text = "FrmReserva";
            this.groupboxreserva.ResumeLayout(false);
            this.groupboxreserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridreserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxreserva;
        private Bunifu.Framework.UI.BunifuFlatButton btnsearchcliente;
        private Bunifu.Framework.UI.BunifuDatepicker datefechareserva;
        private System.Windows.Forms.TextBox txtdiagnostico;
        private System.Windows.Forms.TextBox txtapellidoscliente;
        private System.Windows.Forms.Label lblfechareserva;
        private System.Windows.Forms.TextBox txtnombrescliente;
        private System.Windows.Forms.TextBox txtservicio;
        private System.Windows.Forms.Label lblnombrescliente;
        private System.Windows.Forms.Label lbldiagnostico;
        private System.Windows.Forms.Label lblservicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnsearchservicio;
        private System.Windows.Forms.Label lblapellidoscliente;
        private System.Windows.Forms.Label lblasistencia;
        private System.Windows.Forms.ComboBox comboboxasistencia;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private Bunifu.Framework.UI.BunifuFlatButton btneditar;
        private Bunifu.Framework.UI.BunifuFlatButton btncancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnnuevo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridreserva;
    }
}