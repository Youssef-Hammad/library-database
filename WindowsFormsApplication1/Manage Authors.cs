﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Manage_Authors : Form
    {
        public Manage_Authors()
        {
            InitializeComponent();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void ListofAuthors_Click(object sender, EventArgs e)
        {
            Show_Authors_List list = new Show_Authors_List();
            list.Show();

        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            Add_Author a1 = new Add_Author();
            a1.Show();
        }

        private void DeleteAuthor_Click(object sender, EventArgs e)
        {
            Delete_Author a1 = new Delete_Author();
            a1.Show();
        }
    }
}
