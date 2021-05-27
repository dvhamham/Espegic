﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using e.Components;

namespace e
{
    public partial class Main : Form
    {

        //
        // Constructor
        //
        public Main()
        {
            InitializeComponent();
        }

        //
        // Properties
        //
        Helpers help = new Helpers();
        Espegic db = new Espegic();

        //
        // Load
        //
        private void Main_Load(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new Home());
            Profile.Text = db.USERS.Find(help.Connected).L_NAME.ToLower();
        }

        //
        // Navigate to home page
        //
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new Home());
        }

        //
        // Navigate to users
        //
        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new Users());
        }

        //
        // Navigate to professors
        //
        private void ProfessorsBtn_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new Professors());
        }

        //
        // Navigate to students
        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new Students());
        }

        //
        // Navigate to formations
        //
        private void FormationsBtn_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(new Formations());
        }
    }
}