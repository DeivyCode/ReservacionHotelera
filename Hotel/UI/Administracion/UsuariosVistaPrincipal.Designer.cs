namespace Hotel.UI.Administracion
{
    partial class ListadoUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.dgvUsuarios = new Krypton.Toolkit.KryptonDataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.IsAdmin = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.kryptonHeader1 = new Krypton.Toolkit.KryptonHeader();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.txtBusqueda = new Krypton.Toolkit.KryptonTextBox();
            this.btEdit = new Krypton.Toolkit.KryptonButton();
            this.btCreate_Click = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Rounding = 12F;
            this.kryptonPalette1.FormStyles.FormMain.StateInactive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateInactive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateInactive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateInactive.Border.Rounding = 12F;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.dgvUsuarios);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 70);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Palette = this.kryptonPalette1;
            this.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(938, 490);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeight = 40;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.Usuario,
            this.Nombre,
            this.Apellidos,
            this.Correo,
            this.Clave,
            this.IsActive,
            this.IsAdmin});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(938, 490);
            this.dgvUsuarios.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvUsuarios.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuarios.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuarios.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvUsuarios.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvUsuarios.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgvUsuarios.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUsuarios_DataBindingComplete_1);
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.FillWeight = 50F;
            this.IdUsuario.HeaderText = "Id";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Codigo Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombres";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.IsActive.DefaultCellStyle = dataGridViewCellStyle1;
            this.IsActive.FalseValue = null;
            this.IsActive.HeaderText = "Estado";
            this.IsActive.IndeterminateValue = null;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.TrueValue = null;
            // 
            // IsAdmin
            // 
            this.IsAdmin.DataPropertyName = "IsAdmin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.IsAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.IsAdmin.FalseValue = null;
            this.IsAdmin.HeaderText = "Administrador";
            this.IsAdmin.IndeterminateValue = null;
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.ReadOnly = true;
            this.IsAdmin.TrueValue = null;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 566);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(212, 31);
            this.kryptonHeader1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "10";
            this.kryptonHeader1.Values.Heading = "Total de registros";
            this.kryptonHeader1.Values.Image = global::Hotel.Properties.Resources._8687730_ic_fluent_poll_regular_icon;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txtBusqueda);
            this.kryptonPanel2.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel2.Controls.Add(this.btEdit);
            this.kryptonPanel2.Controls.Add(this.btCreate_Click);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(938, 604);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 18;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CueHint.CueHintText = "Buscar";
            this.txtBusqueda.CueHint.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBusqueda.Location = new System.Drawing.Point(0, 35);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Palette = this.kryptonPalette1;
            this.txtBusqueda.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtBusqueda.Size = new System.Drawing.Size(287, 29);
            this.txtBusqueda.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBusqueda.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.txtBusqueda.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.txtBusqueda.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBusqueda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBusqueda.StateCommon.Border.Rounding = 8F;
            this.txtBusqueda.StateCommon.Border.Width = 1;
            this.txtBusqueda.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBusqueda.StateCommon.Content.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBusqueda.TabIndex = 5;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(792, 19);
            this.btEdit.Name = "btEdit";
            this.btEdit.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btEdit.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btEdit.OverrideDefault.Back.ColorAngle = 45F;
            this.btEdit.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEdit.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEdit.OverrideDefault.Border.Rounding = 20F;
            this.btEdit.OverrideDefault.Border.Width = 1;
            this.btEdit.OverrideFocus.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btEdit.OverrideFocus.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btEdit.OverrideFocus.Back.ColorAngle = 45F;
            this.btEdit.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEdit.OverrideFocus.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btEdit.OverrideFocus.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btEdit.OverrideFocus.Border.ColorAngle = 45F;
            this.btEdit.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEdit.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEdit.OverrideFocus.Border.Rounding = 20F;
            this.btEdit.OverrideFocus.Border.Width = 1;
            this.btEdit.Palette = this.kryptonPalette1;
            this.btEdit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btEdit.Size = new System.Drawing.Size(144, 45);
            this.btEdit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btEdit.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btEdit.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEdit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEdit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEdit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEdit.StateCommon.Border.Rounding = 20F;
            this.btEdit.StateCommon.Border.Width = 1;
            this.btEdit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btEdit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEdit.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEdit.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEdit.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEdit.StateNormal.Border.Rounding = 20F;
            this.btEdit.StateNormal.Border.Width = 1;
            this.btEdit.StateTracking.Back.Color1 = System.Drawing.SystemColors.HotTrack;
            this.btEdit.StateTracking.Back.Color2 = System.Drawing.SystemColors.HotTrack;
            this.btEdit.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btEdit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEdit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEdit.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btEdit.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEdit.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btEdit.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.btEdit.StateTracking.Border.Rounding = 20F;
            this.btEdit.StateTracking.Border.Width = 1;
            this.btEdit.TabIndex = 3;
            this.btEdit.Values.Image = global::Hotel.Properties.Resources.edit_black;
            this.btEdit.Values.Text = "Editar Usuario";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btCreate_Click
            // 
            this.btCreate_Click.Location = new System.Drawing.Point(647, 19);
            this.btCreate_Click.Name = "btCreate_Click";
            this.btCreate_Click.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.btCreate_Click.OverrideDefault.Back.Color2 = System.Drawing.Color.Green;
            this.btCreate_Click.OverrideDefault.Back.ColorAngle = 45F;
            this.btCreate_Click.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btCreate_Click.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate_Click.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate_Click.OverrideDefault.Border.Rounding = 20F;
            this.btCreate_Click.OverrideDefault.Border.Width = 1;
            this.btCreate_Click.OverrideFocus.Back.Color1 = System.Drawing.Color.Green;
            this.btCreate_Click.OverrideFocus.Back.Color2 = System.Drawing.Color.Green;
            this.btCreate_Click.OverrideFocus.Back.ColorAngle = 45F;
            this.btCreate_Click.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate_Click.OverrideFocus.Border.Color1 = System.Drawing.Color.Green;
            this.btCreate_Click.OverrideFocus.Border.Color2 = System.Drawing.Color.Green;
            this.btCreate_Click.OverrideFocus.Border.ColorAngle = 45F;
            this.btCreate_Click.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btCreate_Click.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate_Click.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate_Click.OverrideFocus.Border.Rounding = 20F;
            this.btCreate_Click.OverrideFocus.Border.Width = 1;
            this.btCreate_Click.Palette = this.kryptonPalette1;
            this.btCreate_Click.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btCreate_Click.Size = new System.Drawing.Size(139, 45);
            this.btCreate_Click.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.btCreate_Click.StateCommon.Back.Color2 = System.Drawing.Color.Green;
            this.btCreate_Click.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate_Click.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.btCreate_Click.StateCommon.Border.Color2 = System.Drawing.Color.Green;
            this.btCreate_Click.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate_Click.StateCommon.Border.Rounding = 20F;
            this.btCreate_Click.StateCommon.Border.Width = 1;
            this.btCreate_Click.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btCreate_Click.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btCreate_Click.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCreate_Click.StateNormal.Border.Color1 = System.Drawing.Color.Green;
            this.btCreate_Click.StateNormal.Border.Color2 = System.Drawing.Color.Green;
            this.btCreate_Click.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate_Click.StateNormal.Border.Rounding = 20F;
            this.btCreate_Click.StateNormal.Border.Width = 1;
            this.btCreate_Click.StateTracking.Back.Color1 = System.Drawing.Color.DarkGreen;
            this.btCreate_Click.StateTracking.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.btCreate_Click.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btCreate_Click.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate_Click.StateTracking.Border.Color1 = System.Drawing.Color.DarkGreen;
            this.btCreate_Click.StateTracking.Border.Color2 = System.Drawing.Color.DarkGreen;
            this.btCreate_Click.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btCreate_Click.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate_Click.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate_Click.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btCreate_Click.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.btCreate_Click.StateTracking.Border.Rounding = 20F;
            this.btCreate_Click.StateTracking.Border.Width = 1;
            this.btCreate_Click.TabIndex = 2;
            this.btCreate_Click.Values.Image = global::Hotel.Properties.Resources.add_black;
            this.btCreate_Click.Values.Text = "Crear Usuario";
            this.btCreate_Click.Click += new System.EventHandler(this.btCreate_Click_Click);
            // 
            // ListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 604);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Calendar;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "ListadoUsuarios";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Listado de Usuarios";
            this.Load += new System.EventHandler(this.ListadoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn IsActive;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn IsAdmin;
        private Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton btEdit;
        private Krypton.Toolkit.KryptonButton btCreate_Click;
        private Krypton.Toolkit.KryptonTextBox txtBusqueda;
    }
}