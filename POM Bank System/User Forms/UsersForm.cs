﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_System.Classes;
using ComponentFactory.Krypton.Toolkit;

namespace Bank_System
{
    public partial class UsersForm : KryptonForm
    {
        public UsersForm()
        {
            InitializeComponent();
            UserOperations.UsersList.Clear();
            UserOperations.LoadUsersFromFile();
            User.id = int.Parse(UserOperations.UsersList.Last().ID);
            User.id++;
        }

        private int permission;
        public UsersForm(int per)
        {
            InitializeComponent();
            permission = per;
        }
        private void AddNewUser_Button_Click(object sender, EventArgs e)
        {
            NewUserForm form = new NewUserForm();
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(permission);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ListUsers_Button_Click(object sender, EventArgs e)
        {
            UsersListForm form = new UsersListForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void DeleteUser_Button_Click(object sender, EventArgs e)
        {
            DeleteUserForm form = new DeleteUserForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        
    }
}

