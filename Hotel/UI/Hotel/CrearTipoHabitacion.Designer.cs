namespace Hotel.UI.Hotel
{
    partial class CrearTipoHabitacion
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
            this.txtDescripcion = new Krypton.Toolkit.KryptonTextBox();
            this.CbHoteles = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.btCreate = new Krypton.Toolkit.KryptonButton();
            this.CbHabitaciones = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.txtPrecio = new Krypton.Toolkit.KryptonTextBox();
            this.txtNumeroHabitaciones = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CbHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.CueHint.Color1 = System.Drawing.Color.Black;
            this.txtDescripcion.CueHint.CueHintText = "Descripcion";
            this.txtDescripcion.CueHint.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtDescripcion.Location = new System.Drawing.Point(2, 150);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.MultilineStringEditor = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(612, 103);
            this.txtDescripcion.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescripcion.StateActive.Border.Rounding = 20F;
            this.txtDescripcion.StateActive.Border.Width = 1;
            this.txtDescripcion.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDescripcion.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescripcion.StateCommon.Border.Rounding = 20F;
            this.txtDescripcion.StateCommon.Border.Width = 1;
            this.txtDescripcion.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescripcion.StateNormal.Border.Rounding = 20F;
            this.txtDescripcion.StateNormal.Border.Width = 1;
            this.txtDescripcion.TabIndex = 1;
            // 
            // CbHoteles
            // 
            this.CbHoteles.CueHint.Color1 = System.Drawing.Color.Black;
            this.CbHoteles.CueHint.CueHintText = "Hoteles";
            this.CbHoteles.CueHint.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.CbHoteles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbHoteles.DropDownWidth = 270;
            this.CbHoteles.IntegralHeight = false;
            this.CbHoteles.Location = new System.Drawing.Point(2, 99);
            this.CbHoteles.Name = "CbHoteles";
            this.CbHoteles.Size = new System.Drawing.Size(291, 34);
            this.CbHoteles.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CbHoteles.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.CbHoteles.StateCommon.ComboBox.Border.Rounding = 20F;
            this.CbHoteles.StateCommon.ComboBox.Border.Width = 1;
            this.CbHoteles.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CbHoteles.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CbHoteles.TabIndex = 6;
            this.CbHoteles.SelectedIndexChanged += new System.EventHandler(this.CbHoteles_SelectedIndexChanged);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(489, 266);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.Rounding = 20F;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.OverrideFocus.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.OverrideFocus.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.OverrideFocus.Border.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonButton1.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideFocus.Border.Rounding = 20F;
            this.kryptonButton1.OverrideFocus.Border.Width = 1;
            this.kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(118, 35);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 20F;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateNormal.Border.Rounding = 20F;
            this.kryptonButton1.StateNormal.Border.Width = 1;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton1.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.kryptonButton1.StateTracking.Border.Rounding = 20F;
            this.kryptonButton1.StateTracking.Border.Width = 1;
            this.kryptonButton1.TabIndex = 14;
            this.kryptonButton1.Values.Text = "Cancelar";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(365, 266);
            this.btCreate.Name = "btCreate";
            this.btCreate.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.btCreate.OverrideDefault.Back.Color2 = System.Drawing.Color.Green;
            this.btCreate.OverrideDefault.Back.ColorAngle = 45F;
            this.btCreate.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.OverrideDefault.Border.Rounding = 20F;
            this.btCreate.OverrideDefault.Border.Width = 1;
            this.btCreate.OverrideFocus.Back.Color1 = System.Drawing.Color.Green;
            this.btCreate.OverrideFocus.Back.Color2 = System.Drawing.Color.Green;
            this.btCreate.OverrideFocus.Back.ColorAngle = 45F;
            this.btCreate.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.OverrideFocus.Border.Color1 = System.Drawing.Color.Green;
            this.btCreate.OverrideFocus.Border.Color2 = System.Drawing.Color.Green;
            this.btCreate.OverrideFocus.Border.ColorAngle = 45F;
            this.btCreate.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.OverrideFocus.Border.Rounding = 20F;
            this.btCreate.OverrideFocus.Border.Width = 1;
            this.btCreate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btCreate.Size = new System.Drawing.Size(118, 35);
            this.btCreate.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.btCreate.StateCommon.Back.Color2 = System.Drawing.Color.Green;
            this.btCreate.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.btCreate.StateCommon.Border.Color2 = System.Drawing.Color.Green;
            this.btCreate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.StateCommon.Border.Rounding = 20F;
            this.btCreate.StateCommon.Border.Width = 1;
            this.btCreate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btCreate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCreate.StateNormal.Border.Color1 = System.Drawing.Color.Green;
            this.btCreate.StateNormal.Border.Color2 = System.Drawing.Color.Green;
            this.btCreate.StateNormal.Border.ColorAngle = 40F;
            this.btCreate.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
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
            this.btCreate.TabIndex = 13;
            this.btCreate.Values.Text = "Guardar";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // CbHabitaciones
            // 
            this.CbHabitaciones.CueHint.Color1 = System.Drawing.Color.Black;
            this.CbHabitaciones.CueHint.CueHintText = "Habitaciones";
            this.CbHabitaciones.CueHint.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.CbHabitaciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbHabitaciones.DropDownWidth = 270;
            this.CbHabitaciones.IntegralHeight = false;
            this.CbHabitaciones.Location = new System.Drawing.Point(319, 99);
            this.CbHabitaciones.Name = "CbHabitaciones";
            this.CbHabitaciones.Size = new System.Drawing.Size(295, 34);
            this.CbHabitaciones.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CbHabitaciones.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.CbHabitaciones.StateCommon.ComboBox.Border.Rounding = 20F;
            this.CbHabitaciones.StateCommon.ComboBox.Border.Width = 1;
            this.CbHabitaciones.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CbHabitaciones.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CbHabitaciones.TabIndex = 15;
            this.CbHabitaciones.SelectedIndexChanged += new System.EventHandler(this.CbHabitaciones_SelectedIndexChanged);
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
            // txtPrecio
            // 
            this.txtPrecio.CueHint.CueHintText = "Precio de habitacion";
            this.txtPrecio.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtPrecio.Location = new System.Drawing.Point(2, 32);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(295, 35);
            this.txtPrecio.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrecio.StateCommon.Border.Rounding = 20F;
            this.txtPrecio.StateCommon.Border.Width = 1;
            this.txtPrecio.TabIndex = 22;
            // 
            // txtNumeroHabitaciones
            // 
            this.txtNumeroHabitaciones.CueHint.CueHintText = "Numero habitaciones";
            this.txtNumeroHabitaciones.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtNumeroHabitaciones.Location = new System.Drawing.Point(319, 32);
            this.txtNumeroHabitaciones.Name = "txtNumeroHabitaciones";
            this.txtNumeroHabitaciones.Size = new System.Drawing.Size(295, 35);
            this.txtNumeroHabitaciones.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNumeroHabitaciones.StateCommon.Border.Rounding = 20F;
            this.txtNumeroHabitaciones.StateCommon.Border.Width = 1;
            this.txtNumeroHabitaciones.TabIndex = 23;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 7);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(47, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 24;
            this.kryptonLabel1.Values.Text = "Precio";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(61, 7);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(16, 21);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 25;
            this.kryptonLabel2.Values.Text = "*";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(472, 5);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(16, 21);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 27;
            this.kryptonLabel3.Values.Text = "*";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(319, 5);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(156, 21);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 26;
            this.kryptonLabel4.Values.Text = "Numero de habitaciones";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(392, 71);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(16, 21);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 31;
            this.kryptonLabel5.Values.Text = "*";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(319, 73);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(74, 21);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 30;
            this.kryptonLabel6.Values.Text = "Habitacion";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(51, 71);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(16, 21);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel7.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel7.TabIndex = 29;
            this.kryptonLabel7.Values.Text = "*";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(11, 73);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(43, 21);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel8.TabIndex = 28;
            this.kryptonLabel8.Values.Text = "Hotel";
            // 
            // CrearTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 302);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtNumeroHabitaciones);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.CbHoteles);
            this.Controls.Add(this.CbHabitaciones);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.btCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Calendar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearTipoHabitacion";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "Crear Tipos de habitacion";
            this.Load += new System.EventHandler(this.CrearTipoHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CbHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtDescripcion;
        private Krypton.Toolkit.KryptonComboBox CbHoteles;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton btCreate;
        private Krypton.Toolkit.KryptonComboBox CbHabitaciones;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonTextBox txtPrecio;
        private Krypton.Toolkit.KryptonTextBox txtNumeroHabitaciones;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
    }
}