namespace Bank_System
{
    partial class BalanceListForm
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
            this.TransactionsMenu_Button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BalanceTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TotalBalance_Label = new System.Windows.Forms.Label();
            this.NOClient_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsClientBindingSource)).BeginInit();
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
            // TransactionsMenu_Button
            // 
            this.TransactionsMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransactionsMenu_Button.Location = new System.Drawing.Point(32, 579);
            this.TransactionsMenu_Button.Name = "TransactionsMenu_Button";
            this.TransactionsMenu_Button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.OverrideDefault.Back.ColorAngle = 45F;
            this.TransactionsMenu_Button.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.OverrideDefault.Border.ColorAngle = 45F;
            this.TransactionsMenu_Button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TransactionsMenu_Button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TransactionsMenu_Button.OverrideDefault.Border.Rounding = 20;
            this.TransactionsMenu_Button.OverrideDefault.Border.Width = 1;
            this.TransactionsMenu_Button.Size = new System.Drawing.Size(298, 79);
            this.TransactionsMenu_Button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StateCommon.Back.ColorAngle = 45F;
            this.TransactionsMenu_Button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StateCommon.Border.ColorAngle = 45F;
            this.TransactionsMenu_Button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TransactionsMenu_Button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TransactionsMenu_Button.StateCommon.Border.Rounding = 20;
            this.TransactionsMenu_Button.StateCommon.Border.Width = 1;
            this.TransactionsMenu_Button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.TransactionsMenu_Button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.TransactionsMenu_Button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsMenu_Button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StatePressed.Back.ColorAngle = 135F;
            this.TransactionsMenu_Button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StatePressed.Border.ColorAngle = 135F;
            this.TransactionsMenu_Button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TransactionsMenu_Button.StatePressed.Border.Rounding = 20;
            this.TransactionsMenu_Button.StatePressed.Border.Width = 1;
            this.TransactionsMenu_Button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(49)))));
            this.TransactionsMenu_Button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.TransactionsMenu_Button.StateTracking.Back.ColorAngle = 45F;
            this.TransactionsMenu_Button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(49)))));
            this.TransactionsMenu_Button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(49)))));
            this.TransactionsMenu_Button.StateTracking.Border.ColorAngle = 45F;
            this.TransactionsMenu_Button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TransactionsMenu_Button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TransactionsMenu_Button.StateTracking.Border.Rounding = 20;
            this.TransactionsMenu_Button.StateTracking.Border.Width = 1;
            this.TransactionsMenu_Button.TabIndex = 42;
            this.TransactionsMenu_Button.Values.Image = global::Bank_System.Properties.Resources.arrow_24_xxl3;
            this.TransactionsMenu_Button.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TransactionsMenu_Button.Values.Text = "Transations Menu";
            this.TransactionsMenu_Button.Click += new System.EventHandler(this.TransactionsMenu_Button_Click);
            // 
            // BalanceTable
            // 
            this.BalanceTable.AutoGenerateColumns = false;
            this.BalanceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BalanceTable.ColumnHeadersHeight = 80;
            this.BalanceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.BalanceTable.DataSource = this.clsClientBindingSource;
            this.BalanceTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Custom1;
            this.BalanceTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.BalanceTable.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.BalanceTable.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.BalanceTable.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.BalanceTable.HideOuterBorders = true;
            this.BalanceTable.Location = new System.Drawing.Point(1, 1);
            this.BalanceTable.Name = "BalanceTable";
            this.BalanceTable.ReadOnly = true;
            this.BalanceTable.RowHeadersVisible = false;
            this.BalanceTable.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.BalanceTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BalanceTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BalanceTable.Size = new System.Drawing.Size(1263, 533);
            this.BalanceTable.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.BalanceTable.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.BalanceTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.BalanceTable.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.BalanceTable.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.BalanceTable.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.BalanceTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.BalanceTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.BalanceTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BalanceTable.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BalanceTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BalanceTable.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BalanceTable.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTable.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.BalanceTable.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.BalanceTable.TabIndex = 45;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // TotalBalance_Label
            // 
            this.TotalBalance_Label.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.TotalBalance_Label.AutoSize = true;
            this.TotalBalance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBalance_Label.Location = new System.Drawing.Point(750, 599);
            this.TotalBalance_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalBalance_Label.Name = "TotalBalance_Label";
            this.TotalBalance_Label.Size = new System.Drawing.Size(218, 31);
            this.TotalBalance_Label.TabIndex = 46;
            this.TotalBalance_Label.Text = "Total Balance : ";
            // 
            // NOClient_Label
            // 
            this.NOClient_Label.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.NOClient_Label.AutoSize = true;
            this.NOClient_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOClient_Label.ForeColor = System.Drawing.Color.Gray;
            this.NOClient_Label.Location = new System.Drawing.Point(421, 605);
            this.NOClient_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NOClient_Label.Name = "NOClient_Label";
            this.NOClient_Label.Size = new System.Drawing.Size(123, 25);
            this.NOClient_Label.TabIndex = 47;
            this.NOClient_Label.Text = "NO.clients :";
            // 
            // BalanceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.NOClient_Label);
            this.Controls.Add(this.TotalBalance_Label);
            this.Controls.Add(this.BalanceTable);
            this.Controls.Add(this.TransactionsMenu_Button);
            this.Name = "BalanceListForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POM Bank - Balance List";
            this.Load += new System.EventHandler(this.BalanceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public ComponentFactory.Krypton.Toolkit.KryptonButton TransactionsMenu_Button;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView BalanceTable;
        private System.Windows.Forms.Label TotalBalance_Label;
        private System.Windows.Forms.Label NOClient_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clsClientBindingSource;
    }
}