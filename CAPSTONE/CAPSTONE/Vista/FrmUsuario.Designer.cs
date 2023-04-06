namespace CAPSTONE
{
    partial class FrmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.datagridusuario = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupboxusuario = new System.Windows.Forms.GroupBox();
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
            this.btnsalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridusuario)).BeginInit();
            this.groupboxusuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridusuario
            // 
            this.datagridusuario.AllowUserToAddRows = false;
            this.datagridusuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridusuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridusuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridusuario.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridusuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridusuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridusuario.DoubleBuffered = true;
            this.datagridusuario.EnableHeadersVisualStyles = false;
            this.datagridusuario.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.datagridusuario.HeaderForeColor = System.Drawing.Color.White;
            this.datagridusuario.Location = new System.Drawing.Point(12, 328);
            this.datagridusuario.Name = "datagridusuario";
            this.datagridusuario.ReadOnly = true;
            this.datagridusuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridusuario.Size = new System.Drawing.Size(686, 304);
            this.datagridusuario.TabIndex = 6;
            // 
            // groupboxusuario
            // 
            this.groupboxusuario.BackColor = System.Drawing.Color.Transparent;
            this.groupboxusuario.Controls.Add(this.txtcorreo);
            this.groupboxusuario.Controls.Add(this.lblcorreo);
            this.groupboxusuario.Controls.Add(this.txtcelular);
            this.groupboxusuario.Controls.Add(this.lblcelular);
            this.groupboxusuario.Controls.Add(this.txtdni);
            this.groupboxusuario.Controls.Add(this.txtapellidos);
            this.groupboxusuario.Controls.Add(this.txtnombres);
            this.groupboxusuario.Controls.Add(this.lblnombres);
            this.groupboxusuario.Controls.Add(this.lblapellidos);
            this.groupboxusuario.Controls.Add(this.lbldni);
            this.groupboxusuario.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxusuario.ForeColor = System.Drawing.Color.White;
            this.groupboxusuario.Location = new System.Drawing.Point(12, 12);
            this.groupboxusuario.Name = "groupboxusuario";
            this.groupboxusuario.Size = new System.Drawing.Size(686, 173);
            this.groupboxusuario.TabIndex = 7;
            this.groupboxusuario.TabStop = false;
            this.groupboxusuario.Text = "DATOS DEL USUARIO";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(47, 121);
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
            this.lblcorreo.Location = new System.Drawing.Point(44, 99);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(48, 15);
            this.lblcorreo.TabIndex = 8;
            this.lblcorreo.Text = "Correo";
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(288, 121);
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
            this.lblcelular.Location = new System.Drawing.Point(284, 99);
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
            this.btnsalir.Location = new System.Drawing.Point(581, 216);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsalir.selected = true;
            this.btnsalir.Size = new System.Drawing.Size(105, 33);
            this.btnsalir.TabIndex = 18;
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
            this.btnguardar.Location = new System.Drawing.Point(133, 216);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = true;
            this.btnguardar.Size = new System.Drawing.Size(105, 33);
            this.btnguardar.TabIndex = 17;
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
            this.btneditar.Location = new System.Drawing.Point(357, 216);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneditar.Name = "btneditar";
            this.btneditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneditar.selected = true;
            this.btneditar.Size = new System.Drawing.Size(105, 33);
            this.btneditar.TabIndex = 15;
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
            this.btncancelar.Location = new System.Drawing.Point(245, 216);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancelar.selected = true;
            this.btncancelar.Size = new System.Drawing.Size(105, 33);
            this.btncancelar.TabIndex = 14;
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
            this.btneliminar.Location = new System.Drawing.Point(469, 216);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = true;
            this.btneliminar.Size = new System.Drawing.Size(105, 33);
            this.btneliminar.TabIndex = 16;
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
            this.btnnuevo.Location = new System.Drawing.Point(21, 216);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnuevo.selected = true;
            this.btnnuevo.Size = new System.Drawing.Size(105, 33);
            this.btnnuevo.TabIndex = 13;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnuevo.Textcolor = System.Drawing.Color.White;
            this.btnnuevo.TextFont = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(275, 282);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(220, 25);
            this.txtbuscar.TabIndex = 20;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblbuscar.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.ForeColor = System.Drawing.Color.White;
            this.lblbuscar.Location = new System.Drawing.Point(223, 285);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(46, 15);
            this.lblbuscar.TabIndex = 19;
            this.lblbuscar.Text = "Buscar";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.Controls.Add(this.groupboxusuario);
            this.Controls.Add(this.datagridusuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.datagridusuario)).EndInit();
            this.groupboxusuario.ResumeLayout(false);
            this.groupboxusuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridusuario;
        private System.Windows.Forms.GroupBox groupboxusuario;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lblcorreo;
        private Bunifu.Framework.UI.BunifuFlatButton btnsalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private Bunifu.Framework.UI.BunifuFlatButton btneditar;
        private Bunifu.Framework.UI.BunifuFlatButton btncancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnnuevo;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
    }
}