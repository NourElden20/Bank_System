namespace Bank_System
{
    partial class ClientListForm
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.MainMenu_Button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ClientTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pINCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsClientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsClientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Bank_System.Properties.Resources.image;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Bank_System.Properties.Resources.image__2_;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Bank_System.Properties.Resources.image__1_;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Rounding = 12;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // MainMenu_Button
            // 
            this.MainMenu_Button.Location = new System.Drawing.Point(96, 898);
            this.MainMenu_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainMenu_Button.Name = "MainMenu_Button";
            this.MainMenu_Button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.OverrideDefault.Back.ColorAngle = 45F;
            this.MainMenu_Button.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.OverrideDefault.Border.ColorAngle = 45F;
            this.MainMenu_Button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainMenu_Button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainMenu_Button.OverrideDefault.Border.Rounding = 20;
            this.MainMenu_Button.OverrideDefault.Border.Width = 1;
            this.MainMenu_Button.Size = new System.Drawing.Size(402, 122);
            this.MainMenu_Button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StateCommon.Back.ColorAngle = 45F;
            this.MainMenu_Button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StateCommon.Border.ColorAngle = 45F;
            this.MainMenu_Button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainMenu_Button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainMenu_Button.StateCommon.Border.Rounding = 20;
            this.MainMenu_Button.StateCommon.Border.Width = 1;
            this.MainMenu_Button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MainMenu_Button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MainMenu_Button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StatePressed.Back.ColorAngle = 135F;
            this.MainMenu_Button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StatePressed.Border.ColorAngle = 135F;
            this.MainMenu_Button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainMenu_Button.StatePressed.Border.Rounding = 20;
            this.MainMenu_Button.StatePressed.Border.Width = 1;
            this.MainMenu_Button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(49)))));
            this.MainMenu_Button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.MainMenu_Button.StateTracking.Back.ColorAngle = 45F;
            this.MainMenu_Button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(49)))));
            this.MainMenu_Button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(49)))));
            this.MainMenu_Button.StateTracking.Border.ColorAngle = 45F;
            this.MainMenu_Button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainMenu_Button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainMenu_Button.StateTracking.Border.Rounding = 20;
            this.MainMenu_Button.StateTracking.Border.Width = 1;
            this.MainMenu_Button.TabIndex = 50;
            this.MainMenu_Button.Values.Image = global::Bank_System.Properties.Resources.arrow_24_xxl3;
            this.MainMenu_Button.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MainMenu_Button.Values.Text = "Main Menu";
            this.MainMenu_Button.Click += new System.EventHandler(this.MainMenu_Button_Click);
            // 
            // ClientTable
            // 
            this.ClientTable.AutoGenerateColumns = false;
            this.ClientTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientTable.ColumnHeadersHeight = 80;
            this.ClientTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIDDataGridViewTextBoxColumn,
            this.pINCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.ClientTable.DataSource = this.clsClientBindingSource;
            this.ClientTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Custom1;
            this.ClientTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.ClientTable.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.ClientTable.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.ClientTable.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.ClientTable.HideOuterBorders = true;
            this.ClientTable.Location = new System.Drawing.Point(2, 28);
            this.ClientTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientTable.Name = "ClientTable";
            this.ClientTable.ReadOnly = true;
            this.ClientTable.RowHeadersVisible = false;
            this.ClientTable.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ClientTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClientTable.Size = new System.Drawing.Size(1894, 820);
            this.ClientTable.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.ClientTable.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.ClientTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.ClientTable.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.ClientTable.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.ClientTable.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.ClientTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.ClientTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.ClientTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientTable.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClientTable.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientTable.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientTable.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.ClientTable.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.ClientTable.TabIndex = 49;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pINCodeDataGridViewTextBoxColumn
            // 
            this.pINCodeDataGridViewTextBoxColumn.DataPropertyName = "PINCode";
            this.pINCodeDataGridViewTextBoxColumn.HeaderText = "PINCode";
            this.pINCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pINCodeDataGridViewTextBoxColumn.Name = "pINCodeDataGridViewTextBoxColumn";
            this.pINCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clsClientBindingSource
            // 
            this.clsClientBindingSource.DataSource = typeof(Bank_System.Classes.clsClient);
            // 
            // clsClientBindingSource1
            // 
            this.clsClientBindingSource1.DataSource = typeof(Bank_System.Classes.clsClient);
            // 
            // ClientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.MainMenu_Button);
            this.Controls.Add(this.ClientTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientListForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientList";
            this.Load += new System.EventHandler(this.ClientListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsClientBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public ComponentFactory.Krypton.Toolkit.KryptonButton MainMenu_Button;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ClientTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pINCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clsClientBindingSource;
        private System.Windows.Forms.BindingSource clsClientBindingSource1;
    }
}