namespace Bank_System
{
    partial class UsersListForm
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
            this.ManageUsersMenu_Button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.UsersTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            // ManageUsersMenu_Button
            // 
            this.ManageUsersMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageUsersMenu_Button.Location = new System.Drawing.Point(12, 382);
            this.ManageUsersMenu_Button.Name = "ManageUsersMenu_Button";
            this.ManageUsersMenu_Button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.OverrideDefault.Back.ColorAngle = 45F;
            this.ManageUsersMenu_Button.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.OverrideDefault.Border.ColorAngle = 45F;
            this.ManageUsersMenu_Button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ManageUsersMenu_Button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ManageUsersMenu_Button.OverrideDefault.Border.Rounding = 20;
            this.ManageUsersMenu_Button.OverrideDefault.Border.Width = 1;
            this.ManageUsersMenu_Button.Size = new System.Drawing.Size(321, 79);
            this.ManageUsersMenu_Button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateCommon.Back.ColorAngle = 45F;
            this.ManageUsersMenu_Button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateCommon.Border.ColorAngle = 45F;
            this.ManageUsersMenu_Button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ManageUsersMenu_Button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ManageUsersMenu_Button.StateCommon.Border.Rounding = 20;
            this.ManageUsersMenu_Button.StateCommon.Border.Width = 1;
            this.ManageUsersMenu_Button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ManageUsersMenu_Button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ManageUsersMenu_Button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsersMenu_Button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StatePressed.Back.ColorAngle = 135F;
            this.ManageUsersMenu_Button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StatePressed.Border.ColorAngle = 135F;
            this.ManageUsersMenu_Button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ManageUsersMenu_Button.StatePressed.Border.Rounding = 20;
            this.ManageUsersMenu_Button.StatePressed.Border.Width = 1;
            this.ManageUsersMenu_Button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(49)))));
            this.ManageUsersMenu_Button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateTracking.Back.ColorAngle = 45F;
            this.ManageUsersMenu_Button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(49)))));
            this.ManageUsersMenu_Button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(49)))));
            this.ManageUsersMenu_Button.StateTracking.Border.ColorAngle = 45F;
            this.ManageUsersMenu_Button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ManageUsersMenu_Button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ManageUsersMenu_Button.StateTracking.Border.Rounding = 20;
            this.ManageUsersMenu_Button.StateTracking.Border.Width = 1;
            this.ManageUsersMenu_Button.TabIndex = 47;
            this.ManageUsersMenu_Button.Values.Image = global::Bank_System.Properties.Resources.arrow_24_xxl3;
            this.ManageUsersMenu_Button.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ManageUsersMenu_Button.Values.Text = "Manage Users Menu";
            this.ManageUsersMenu_Button.Click += new System.EventHandler(this.ManageUsersMenu_Button_Click);
            // 
            // UsersTable
            // 
            this.UsersTable.AutoGenerateColumns = false;
            this.UsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersTable.ColumnHeadersHeight = 80;
            this.UsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.permissionDataGridViewTextBoxColumn});
            this.UsersTable.DataSource = this.userBindingSource;
            this.UsersTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Custom1;
            this.UsersTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.UsersTable.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.UsersTable.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.UsersTable.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.UsersTable.HideOuterBorders = true;
            this.UsersTable.Location = new System.Drawing.Point(12, 12);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.ReadOnly = true;
            this.UsersTable.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.UsersTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersTable.Size = new System.Drawing.Size(763, 364);
            this.UsersTable.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.UsersTable.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.UsersTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.UsersTable.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.UsersTable.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.UsersTable.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.UsersTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.UsersTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.UsersTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UsersTable.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UsersTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UsersTable.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsersTable.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersTable.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.UsersTable.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.UsersTable.TabIndex = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 40.60914F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissionDataGridViewTextBoxColumn
            // 
            this.permissionDataGridViewTextBoxColumn.DataPropertyName = "Permission";
            this.permissionDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.permissionDataGridViewTextBoxColumn.HeaderText = "Permission";
            this.permissionDataGridViewTextBoxColumn.Name = "permissionDataGridViewTextBoxColumn";
            this.permissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Bank_System.User);
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.UsersTable);
            this.Controls.Add(this.ManageUsersMenu_Button);
            this.Name = "UsersListForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POM Bank - Users List";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public ComponentFactory.Krypton.Toolkit.KryptonButton ManageUsersMenu_Button;
        private System.Windows.Forms.BindingSource userBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView UsersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
    }
}