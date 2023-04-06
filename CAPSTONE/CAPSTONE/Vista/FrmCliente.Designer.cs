namespace CAPSTONE.Vista
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnsalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupboxcliente = new System.Windows.Forms.GroupBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.datagridcliente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblsexo = new System.Windows.Forms.Label();
            this.comboboxsexo = new System.Windows.Forms.ComboBox();
            this.datefechanacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblfechanacimiento = new System.Windows.Forms.Label();
            this.lbltipocliente = new System.Windows.Forms.Label();
            this.combotipocliente = new System.Windows.Forms.ComboBox();
            this.groupboxcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(275, 362);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(220, 25);
            this.txtbuscar.TabIndex = 30;
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
            this.lblbuscar.TabIndex = 29;
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
            this.btnsalir.TabIndex = 28;
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
            this.btnguardar.TabIndex = 27;
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
            this.btneditar.TabIndex = 25;
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
            this.btncancelar.TabIndex = 24;
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
            this.btneliminar.TabIndex = 26;
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
            this.btnnuevo.TabIndex = 23;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnuevo.Textcolor = System.Drawing.Color.White;
            this.btnnuevo.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupboxcliente
            // 
            this.groupboxcliente.BackColor = System.Drawing.Color.Transparent;
            this.groupboxcliente.Controls.Add(this.lbltipocliente);
            this.groupboxcliente.Controls.Add(this.txtcorreo);
            this.groupboxcliente.Controls.Add(this.lblcorreo);
            this.groupboxcliente.Controls.Add(this.combotipocliente);
            this.groupboxcliente.Controls.Add(this.lblsexo);
            this.groupboxcliente.Controls.Add(this.comboboxsexo);
            this.groupboxcliente.Controls.Add(this.txtcelular);
            this.groupboxcliente.Controls.Add(this.lblcelular);
            this.groupboxcliente.Controls.Add(this.datefechanacimiento);
            this.groupboxcliente.Controls.Add(this.lblfechanacimiento);
            this.groupboxcliente.Controls.Add(this.txtdni);
            this.groupboxcliente.Controls.Add(this.txtapellidos);
            this.groupboxcliente.Controls.Add(this.txtnombres);
            this.groupboxcliente.Controls.Add(this.lblnombres);
            this.groupboxcliente.Controls.Add(this.lblapellidos);
            this.groupboxcliente.Controls.Add(this.lbldni);
            this.groupboxcliente.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxcliente.ForeColor = System.Drawing.Color.White;
            this.groupboxcliente.Location = new System.Drawing.Point(12, 12);
            this.groupboxcliente.Name = "groupboxcliente";
            this.groupboxcliente.Size = new System.Drawing.Size(686, 247);
            this.groupboxcliente.TabIndex = 22;
            this.groupboxcliente.TabStop = false;
            this.groupboxcliente.Text = "DATOS DEL CLIENTE";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(48, 126);
            this.txtcorreo.MaxLength = 9;
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(220, 25);
            this.txtcorreo.TabIndex = 9;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblcorreo.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.Color.White;
            this.lblcorreo.Location = new System.Drawing.Point(45, 104);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(48, 15);
            this.lblcorreo.TabIndex = 8;
            this.lblcorreo.Text = "Correo";
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(288, 125);
            this.txtcelular.MaxLength = 9;
            this.txtcelular.Multiline = true;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(115, 25);
            this.txtcelular.TabIndex = 7;
            this.txtcelular.TextChanged += new System.EventHandler(this.txtcelular_TextChanged);
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.BackColor = System.Drawing.Color.Transparent;
            this.lblcelular.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelular.ForeColor = System.Drawing.Color.White;
            this.lblcelular.Location = new System.Drawing.Point(285, 103);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(48, 15);
            this.lblcelular.TabIndex = 6;
            this.lblcelular.Text = "Celular";
            this.lblcelular.Click += new System.EventHandler(this.lblcelular_Click);
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(48, 57);
            this.txtdni.MaxLength = 8;
            this.txtdni.Multiline = true;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(115, 25);
            this.txtdni.TabIndex = 1;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.Location = new System.Drawing.Point(425, 57);
            this.txtapellidos.Multiline = true;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(220, 25);
            this.txtapellidos.TabIndex = 5;
            // 
            // txtnombres
            // 
            this.txtnombres.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.Location = new System.Drawing.Point(183, 57);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(220, 25);
            this.txtnombres.TabIndex = 3;
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.BackColor = System.Drawing.Color.Transparent;
            this.lblnombres.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.ForeColor = System.Drawing.Color.White;
            this.lblnombres.Location = new System.Drawing.Point(179, 35);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(61, 15);
            this.lblnombres.TabIndex = 2;
            this.lblnombres.Text = "Nombres";
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblapellidos.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidos.ForeColor = System.Drawing.Color.White;
            this.lblapellidos.Location = new System.Drawing.Point(422, 35);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(61, 15);
            this.lblapellidos.TabIndex = 4;
            this.lblapellidos.Text = "Apellidos";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.BackColor = System.Drawing.Color.Transparent;
            this.lbldni.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.ForeColor = System.Drawing.Color.White;
            this.lbldni.Location = new System.Drawing.Point(44, 35);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(28, 15);
            this.lbldni.TabIndex = 0;
            this.lbldni.Text = "Dni";
            // 
            // datagridcliente
            // 
            this.datagridcliente.AllowUserToAddRows = false;
            this.datagridcliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridcliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridcliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridcliente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridcliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridcliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridcliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcliente.DoubleBuffered = true;
            this.datagridcliente.EnableHeadersVisualStyles = false;
            this.datagridcliente.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.datagridcliente.HeaderForeColor = System.Drawing.Color.White;
            this.datagridcliente.Location = new System.Drawing.Point(12, 409);
            this.datagridcliente.Name = "datagridcliente";
            this.datagridcliente.ReadOnly = true;
            this.datagridcliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridcliente.Size = new System.Drawing.Size(686, 223);
            this.datagridcliente.TabIndex = 21;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.BackColor = System.Drawing.Color.Transparent;
            this.lblsexo.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.ForeColor = System.Drawing.Color.White;
            this.lblsexo.Location = new System.Drawing.Point(43, 174);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(34, 15);
            this.lblsexo.TabIndex = 10;
            this.lblsexo.Text = "Sexo";
            this.lblsexo.Click += new System.EventHandler(this.lblsexo_Click);
            // 
            // comboboxsexo
            // 
            this.comboboxsexo.FormattingEnabled = true;
            this.comboboxsexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboboxsexo.Location = new System.Drawing.Point(47, 194);
            this.comboboxsexo.Name = "comboboxsexo";
            this.comboboxsexo.Size = new System.Drawing.Size(165, 22);
            this.comboboxsexo.TabIndex = 11;
            this.comboboxsexo.SelectedIndexChanged += new System.EventHandler(this.comboboxsexo_SelectedIndexChanged);
            // 
            // datefechanacimiento
            // 
            this.datefechanacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.datefechanacimiento.BorderRadius = 0;
            this.datefechanacimiento.ForeColor = System.Drawing.Color.White;
            this.datefechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefechanacimiento.FormatCustom = null;
            this.datefechanacimiento.Location = new System.Drawing.Point(425, 125);
            this.datefechanacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datefechanacimiento.Name = "datefechanacimiento";
            this.datefechanacimiento.Size = new System.Drawing.Size(220, 25);
            this.datefechanacimiento.TabIndex = 15;
            this.datefechanacimiento.Value = new System.DateTime(2021, 10, 23, 1, 40, 14, 377);
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblfechanacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechanacimiento.ForeColor = System.Drawing.Color.White;
            this.lblfechanacimiento.Location = new System.Drawing.Point(422, 102);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(124, 15);
            this.lblfechanacimiento.TabIndex = 14;
            this.lblfechanacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbltipocliente
            // 
            this.lbltipocliente.AutoSize = true;
            this.lbltipocliente.BackColor = System.Drawing.Color.Transparent;
            this.lbltipocliente.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipocliente.ForeColor = System.Drawing.Color.White;
            this.lbltipocliente.Location = new System.Drawing.Point(234, 174);
            this.lbltipocliente.Name = "lbltipocliente";
            this.lbltipocliente.Size = new System.Drawing.Size(94, 15);
            this.lbltipocliente.TabIndex = 16;
            this.lbltipocliente.Text = "Tipo de Cliente";
            // 
            // combotipocliente
            // 
            this.combotipocliente.FormattingEnabled = true;
            this.combotipocliente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.combotipocliente.Location = new System.Drawing.Point(238, 194);
            this.combotipocliente.Name = "combotipocliente";
            this.combotipocliente.Size = new System.Drawing.Size(165, 22);
            this.combotipocliente.TabIndex = 17;
            // 
            // FrmCliente
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
            this.Controls.Add(this.groupboxcliente);
            this.Controls.Add(this.datagridcliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.groupboxcliente.ResumeLayout(false);
            this.groupboxcliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private Bunifu.Framework.UI.BunifuFlatButton btneditar;
        private Bunifu.Framework.UI.BunifuFlatButton btncancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnnuevo;
        private System.Windows.Forms.GroupBox groupboxcliente;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.Label lbldni;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridcliente;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.ComboBox comboboxsexo;
        private Bunifu.Framework.UI.BunifuDatepicker datefechanacimiento;
        private System.Windows.Forms.Label lblfechanacimiento;
        private System.Windows.Forms.Label lbltipocliente;
        private System.Windows.Forms.ComboBox combotipocliente;
    }
}