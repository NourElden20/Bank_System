namespace Bank_System
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.ListUsersButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.FindUserButton = new System.Windows.Forms.Button();
            this.AddNewUsersButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackUButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListUsersButton
            // 
            this.ListUsersButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ListUsersButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUsersButton.ForeColor = System.Drawing.Color.White;
            this.ListUsersButton.Location = new System.Drawing.Point(101, 201);
            this.ListUsersButton.Name = "ListUsersButton";
            this.ListUsersButton.Size = new System.Drawing.Size(254, 40);
            this.ListUsersButton.TabIndex = 4;
            this.ListUsersButton.Text = "List Users";
            this.ListUsersButton.UseVisualStyleBackColor = false;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.DarkOrange;
            this.DeleteUserButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserButton.ForeColor = System.Drawing.Color.White;
            this.DeleteUserButton.Location = new System.Drawing.Point(101, 293);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(254, 40);
            this.DeleteUserButton.TabIndex = 5;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            // 
            // FindUserButton
            // 
            this.FindUserButton.BackColor = System.Drawing.Color.DarkOrange;
            this.FindUserButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindUserButton.ForeColor = System.Drawing.Color.White;
            this.FindUserButton.Location = new System.Drawing.Point(101, 339);
            this.FindUserButton.Name = "FindUserButton";
            this.FindUserButton.Size = new System.Drawing.Size(254, 40);
            this.FindUserButton.TabIndex = 12;
            this.FindUserButton.Text = "Find User";
            this.FindUserButton.UseVisualStyleBackColor = false;
            // 
            // AddNewUsersButton
            // 
            this.AddNewUsersButton.BackColor = System.Drawing.Color.DarkOrange;
            this.AddNewUsersButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewUsersButton.ForeColor = System.Drawing.Color.White;
            this.AddNewUsersButton.Location = new System.Drawing.Point(101, 247);
            this.AddNewUsersButton.Name = "AddNewUsersButton";
            this.AddNewUsersButton.Size = new System.Drawing.Size(254, 40);
            this.AddNewUsersButton.TabIndex = 13;
            this.AddNewUsersButton.Text = "Add New User";
            this.AddNewUsersButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BackUButton
            // 
            this.BackUButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackUButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackUButton.ForeColor = System.Drawing.Color.White;
            this.BackUButton.Location = new System.Drawing.Point(170, 430);
            this.BackUButton.Name = "BackUButton";
            this.BackUButton.Size = new System.Drawing.Size(112, 54);
            this.BackUButton.TabIndex = 15;
            this.BackUButton.Text = "Back";
            this.BackUButton.UseVisualStyleBackColor = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 551);
            this.Controls.Add(this.BackUButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddNewUsersButton);
            this.Controls.Add(this.FindUserButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.ListUsersButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.Text = "POM Bank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListUsersButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button FindUserButton;
        private System.Windows.Forms.Button AddNewUsersButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackUButton;
    }
}