﻿namespace Hotel.UI.Hotel
{
    partial class ListadoHoteles
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
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.IdHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAdministrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btCreate = new Krypton.Toolkit.KryptonButton();
            this.btEditar = new Krypton.Toolkit.KryptonButton();
            this.lbTitle = new Krypton.Toolkit.KryptonLabel();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny3 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.txtBusqueda = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHotel,
            this.IdAdministrador,
            this.IdCategoria,
            this.Nombre,
            this.Descripcion,
            this.Domicilio,
            this.Localidad});
            this.kryptonDataGridView1.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            this.kryptonDataGridView1.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.kryptonDataGridView1.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            this.kryptonDataGridView1.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            this.kryptonDataGridView1.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            this.kryptonDataGridView1.HideOuterBorders = true;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(-5, 114);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonDataGridView1.RowTemplate.Height = 25;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1080, 458);
            this.kryptonDataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.SystemColors.HotTrack;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.SystemColors.HotTrack;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.kryptonDataGridView1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateSelected.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.TabIndex = 2;
            // 
            // IdHotel
            // 
            this.IdHotel.DataPropertyName = "IdHotel";
            this.IdHotel.FillWeight = 50F;
            this.IdHotel.HeaderText = "ID";
            this.IdHotel.Name = "IdHotel";
            // 
            // IdAdministrador
            // 
            this.IdAdministrador.DataPropertyName = "IdAdministrador";
            this.IdAdministrador.HeaderText = "IdAdministrador";
            this.IdAdministrador.Name = "IdAdministrador";
            this.IdAdministrador.Visible = false;
            // 
            // IdCategoria
            // 
            this.IdCategoria.DataPropertyName = "IdCategoria";
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Localidad.DataPropertyName = "Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
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
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.HotTrack;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.SystemColors.HotTrack;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(801, 33);
            this.btCreate.Name = "btCreate";
            this.btCreate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.OverrideDefault.Back.ColorAngle = 45F;
            this.btCreate.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.OverrideDefault.Border.Rounding = 20F;
            this.btCreate.OverrideDefault.Border.Width = 1;
            this.btCreate.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(221)))));
            this.btCreate.OverrideFocus.Back.ColorAngle = 45F;
            this.btCreate.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.btCreate.OverrideFocus.Border.ColorAngle = 45F;
            this.btCreate.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.OverrideFocus.Border.Rounding = 20F;
            this.btCreate.OverrideFocus.Border.Width = 1;
            this.btCreate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btCreate.Size = new System.Drawing.Size(118, 35);
            this.btCreate.StateCommon.Back.Color1 = System.Drawing.SystemColors.HotTrack;
            this.btCreate.StateCommon.Back.Color2 = System.Drawing.SystemColors.HotTrack;
            this.btCreate.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(250)))));
            this.btCreate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.StateCommon.Border.Rounding = 20F;
            this.btCreate.StateCommon.Border.Width = 1;
            this.btCreate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btCreate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCreate.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.StateNormal.Border.Rounding = 20F;
            this.btCreate.StateNormal.Border.Width = 1;
            this.btCreate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btCreate.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btCreate.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.btCreate.StateTracking.Border.Rounding = 20F;
            this.btCreate.StateTracking.Border.Width = 1;
            this.btCreate.TabIndex = 0;
            this.btCreate.Values.Text = "Crear Hotel";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(942, 33);
            this.btEditar.Name = "btEditar";
            this.btEditar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.OverrideDefault.Back.ColorAngle = 45F;
            this.btEditar.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEditar.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEditar.OverrideDefault.Border.Rounding = 20F;
            this.btEditar.OverrideDefault.Border.Width = 1;
            this.btEditar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(221)))));
            this.btEditar.OverrideFocus.Back.ColorAngle = 45F;
            this.btEditar.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEditar.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.btEditar.OverrideFocus.Border.ColorAngle = 45F;
            this.btEditar.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEditar.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEditar.OverrideFocus.Border.Rounding = 20F;
            this.btEditar.OverrideFocus.Border.Width = 1;
            this.btEditar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btEditar.Size = new System.Drawing.Size(118, 35);
            this.btEditar.StateCommon.Back.Color1 = System.Drawing.SystemColors.HotTrack;
            this.btEditar.StateCommon.Back.Color2 = System.Drawing.SystemColors.HotTrack;
            this.btEditar.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEditar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEditar.StateCommon.Border.Rounding = 20F;
            this.btEditar.StateCommon.Border.Width = 1;
            this.btEditar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btEditar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btEditar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEditar.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEditar.StateNormal.Border.Rounding = 20F;
            this.btEditar.StateNormal.Border.Width = 1;
            this.btEditar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btEditar.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btEditar.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btEditar.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.btEditar.StateTracking.Border.Rounding = 20F;
            this.btEditar.StateTracking.Border.Width = 1;
            this.btEditar.TabIndex = 1;
            this.btEditar.Values.Text = "Editar Hotel";
            this.btEditar.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbTitle.Location = new System.Drawing.Point(421, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.lbTitle.Size = new System.Drawing.Size(229, 37);
            this.lbTitle.StateCommon.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Normal;
            this.lbTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.StateCommon.ShortText.Image = global::Hotel.Properties.Resources._9042930_small_shop_alt_icon;
            this.lbTitle.StateNormal.ShortText.Image = global::Hotel.Properties.Resources._9042930_small_shop_alt_icon;
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.lbTitle.Values.Text = "Listado de Hoteles";
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.UniqueName = "6b7bb1ed3c19432d94d00000cbd328eb";
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.UniqueName = "9c2fe8fcbfc8474bae6d58c69451789f";
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.UniqueName = "1a750314ea064d9a8c57d396c2ef1cc1";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.kryptonPalette1;
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CueHint.CueHintText = "Buscar Hotel";
            this.txtBusqueda.CueHint.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBusqueda.Location = new System.Drawing.Point(12, 71);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Palette = this.kryptonPalette1;
            this.txtBusqueda.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtBusqueda.Size = new System.Drawing.Size(287, 35);
            this.txtBusqueda.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBusqueda.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.txtBusqueda.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.txtBusqueda.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBusqueda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBusqueda.StateCommon.Border.Rounding = 20F;
            this.txtBusqueda.StateCommon.Border.Width = 1;
            this.txtBusqueda.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBusqueda.StateCommon.Content.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBusqueda.TabIndex = 4;
            // 
            // ListadoHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1072, 584);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCreate);
            this.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoHoteles";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoteles";
            this.Load += new System.EventHandler(this.ListadoHoteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonButton btCreate;
        private Krypton.Toolkit.KryptonButton btEditar;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonLabel lbTitle;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private DataGridViewTextBoxColumn IdHotel;
        private DataGridViewTextBoxColumn IdAdministrador;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Domicilio;
        private DataGridViewTextBoxColumn Localidad;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonTextBox txtBusqueda;
    }
}