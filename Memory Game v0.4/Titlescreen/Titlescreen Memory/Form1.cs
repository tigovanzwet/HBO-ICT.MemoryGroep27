﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titlescreen_Memory
{
    public partial class Titlescreen : Form
    {
        public Titlescreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.BackColor = Color.White;
        }

        private void btn_highscores_MouseHover(object sender, EventArgs e)
        {
            btn_highscores.BackColor = Color.White;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.White;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.BackColor = Color.Transparent;
        }

        private void btn_highscores_MouseLeave(object sender, EventArgs e)
        {
            btn_highscores.BackColor = Color.Transparent;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.Transparent;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            menu.Hide();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
