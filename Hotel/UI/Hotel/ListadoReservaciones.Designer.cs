namespace Hotel.UI.Hotel
{
    partial class ListadoReservaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btCreate = new Krypton.Toolkit.KryptonButton();
            this.txtBusqueda = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.dgvReservaciones = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonHeader1 = new Krypton.Toolkit.KryptonHeader();
            this.IdReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Huesped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTomador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).BeginInit();
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
            this.btCreate.Location = new System.Drawing.Point(708, 21);
            this.btCreate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btCreate.Name = "btCreate";
            this.btCreate.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.btCreate.OverrideDefault.Back.Color2 = System.Drawing.Color.Green;
            this.btCreate.OverrideDefault.Back.ColorAngle = 45F;
            this.btCreate.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.btCreate.OverrideDefault.Border.Color2 = System.Drawing.Color.Green;
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
            this.btCreate.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btCreate.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.OverrideFocus.Border.Rounding = 20F;
            this.btCreate.OverrideFocus.Border.Width = 1;
            this.btCreate.Palette = this.kryptonPalette1;
            this.btCreate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btCreate.Size = new System.Drawing.Size(196, 46);
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
            this.btCreate.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.StateNormal.Border.Rounding = 20F;
            this.btCreate.StateNormal.Border.Width = 1;
            this.btCreate.StateTracking.Back.Color1 = System.Drawing.Color.DarkGreen;
            this.btCreate.StateTracking.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.btCreate.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btCreate.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.StateTracking.Border.Color1 = System.Drawing.Color.DarkGreen;
            this.btCreate.StateTracking.Border.Color2 = System.Drawing.Color.DarkGreen;
            this.btCreate.StateTracking.Border.ColorAngle = 40F;
            this.btCreate.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btCreate.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCreate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btCreate.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btCreate.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.btCreate.StateTracking.Border.Rounding = 20F;
            this.btCreate.StateTracking.Border.Width = 1;
            this.btCreate.TabIndex = 2;
            this.btCreate.Values.Image = global::Hotel.Properties.Resources.add_black;
            this.btCreate.Values.Text = "Crear Reservacion";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CueHint.CueHintText = "Buscar";
            this.txtBusqueda.CueHint.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBusqueda.Location = new System.Drawing.Point(13, 38);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Palette = this.kryptonPalette1;
            this.txtBusqueda.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtBusqueda.Size = new System.Drawing.Size(344, 29);
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.dgvReservaciones);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 83);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(927, 485);
            this.kryptonPanel1.TabIndex = 6;
            // 
            // dgvReservaciones
            // 
            this.dgvReservaciones.ColumnHeadersHeight = 40;
            this.dgvReservaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReserva,
            this.NombreHotel,
            this.NombreHabitacion,
            this.Huesped,
            this.FechaInicio,
            this.FechaFin,
            this.Precio,
            this.Ocupacion,
            this.NombreTomador,
            this.ClientId,
            this.Cantidad,
            this.IdHabitacion,
            this.IdHotel});
            this.dgvReservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvReservaciones.Name = "dgvReservaciones";
            this.dgvReservaciones.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dgvReservaciones.RowTemplate.Height = 25;
            this.dgvReservaciones.Size = new System.Drawing.Size(927, 485);
            this.dgvReservaciones.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvReservaciones.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReservaciones.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReservaciones.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvReservaciones.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgvReservaciones.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvReservaciones.TabIndex = 3;
            this.dgvReservaciones.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReservaciones_DataBindingComplete);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Location = new System.Drawing.Point(12, 573);
            this.kryptonHeader1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(212, 31);
            this.kryptonHeader1.TabIndex = 7;
            this.kryptonHeader1.Values.Description = "10";
            this.kryptonHeader1.Values.Heading = "Total de registros";
            this.kryptonHeader1.Values.Image = global::Hotel.Properties.Resources._8687730_ic_fluent_poll_regular_icon;
            // 
            // IdReserva
            // 
            this.IdReserva.DataPropertyName = "IdReserva";
            this.IdReserva.FillWeight = 50F;
            this.IdReserva.HeaderText = "#";
            this.IdReserva.Name = "IdReserva";
            this.IdReserva.ReadOnly = true;
            this.IdReserva.Width = 50;
            // 
            // NombreHotel
            // 
            this.NombreHotel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreHotel.DataPropertyName = "NombreHotel";
            this.NombreHotel.HeaderText = "Hotel";
            this.NombreHotel.Name = "NombreHotel";
            this.NombreHotel.ReadOnly = true;
            // 
            // NombreHabitacion
            // 
            this.NombreHabitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreHabitacion.DataPropertyName = "NombreHabitacion";
            this.NombreHabitacion.HeaderText = "Habitacion";
            this.NombreHabitacion.Name = "NombreHabitacion";
            this.NombreHabitacion.ReadOnly = true;
            // 
            // Huesped
            // 
            this.Huesped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Huesped.DataPropertyName = "Huesped";
            this.Huesped.HeaderText = "Huesped";
            this.Huesped.Name = "Huesped";
            this.Huesped.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaInicio.HeaderText = "Fecha entrada";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaFin.DataPropertyName = "FechaFin";
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaFin.HeaderText = "Fecha Salida";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Precio.Width = 80;
            // 
            // Ocupacion
            // 
            this.Ocupacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocupacion.DataPropertyName = "Ocupacion";
            this.Ocupacion.HeaderText = "Ocupacion";
            this.Ocupacion.Name = "Ocupacion";
            this.Ocupacion.ReadOnly = true;
            this.Ocupacion.Visible = false;
            // 
            // NombreTomador
            // 
            this.NombreTomador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreTomador.DataPropertyName = "NombreTomador";
            this.NombreTomador.HeaderText = "Tomador";
            this.NombreTomador.Name = "NombreTomador";
            this.NombreTomador.ReadOnly = true;
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Visible = false;
            // 
            // IdHabitacion
            // 
            this.IdHabitacion.DataPropertyName = "IdHabitacion";
            this.IdHabitacion.HeaderText = "IdHabitacion";
            this.IdHabitacion.Name = "IdHabitacion";
            this.IdHabitacion.Visible = false;
            // 
            // IdHotel
            // 
            this.IdHotel.DataPropertyName = "IdHotel";
            this.IdHotel.HeaderText = "IdHotel";
            this.IdHotel.Name = "IdHotel";
            this.IdHotel.Visible = false;
            // 
            // ListadoReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(955, 621);
            this.Controls.Add(this.kryptonHeader1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Calendar;
            this.Name = "ListadoReservaciones";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Listado de Reservaciones";
            this.Load += new System.EventHandler(this.ListadoReservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonButton btCreate;
        private Krypton.Toolkit.KryptonTextBox txtBusqueda;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private Krypton.Toolkit.KryptonDataGridView dgvReservaciones;
        private DataGridViewTextBoxColumn IdReserva;
        private DataGridViewTextBoxColumn NombreHotel;
        private DataGridViewTextBoxColumn NombreHabitacion;
        private DataGridViewTextBoxColumn Huesped;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Ocupacion;
        private DataGridViewTextBoxColumn NombreTomador;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn IdHabitacion;
        private DataGridViewTextBoxColumn IdHotel;
    }
}