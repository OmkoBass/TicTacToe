using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class form : Form
    {
        int potez = 0;
        bool[] igrano = new bool[9];
        int[,] xox = new int[3,3];
        public form()
        {
            InitializeComponent();
        }

        private int Win()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (xox[0, 0] == 1 && xox[0, 1] == 1 && xox[0, 2] == 1) { return 1; }
                    if (xox[1, 0] == 1 && xox[1, 1] == 1 && xox[1, 2] == 1) { return 1; }
                    if (xox[2, 0] == 1 && xox[2, 1] == 1 && xox[2, 2] == 1) { return 1; }

                    if (xox[0, 0] == 1 && xox[1, 0] == 1 && xox[2, 0] == 1) { return 1; }
                    if (xox[0, 1] == 1 && xox[1, 1] == 1 && xox[2, 1] == 1) { return 1; }
                    if (xox[0, 2] == 1 && xox[1, 2] == 1 && xox[2, 2] == 1) { return 1; }

                    if (xox[0, 0] == 1 && xox[1, 1] == 1 && xox[2, 2] == 1) { return 1; }
                    if (xox[0, 2] == 1 && xox[1, 1] == 1 && xox[2, 0] == 1) { return 1; }

                    if (xox[0, 0] == 2 && xox[0, 1] == 2 && xox[0, 2] == 2) { return 0; }
                    if (xox[1, 0] == 2 && xox[1, 1] == 2 && xox[1, 2] == 2) { return 0; }
                    if (xox[2, 0] == 2 && xox[2, 1] == 2 && xox[2, 2] == 2) { return 0; }

                    if (xox[0, 0] == 2 && xox[1, 0] == 2 && xox[2, 0] == 2) { return 0; }
                    if (xox[0, 1] == 2 && xox[1, 1] == 2 && xox[2, 1] == 2) { return 0; }
                    if (xox[0, 2] == 2 && xox[1, 2] == 2 && xox[2, 2] == 2) { return 0; }

                    if (xox[0, 0] == 2 && xox[1, 1] == 2 && xox[2, 2] == 2) { return 0; }
                    if (xox[0, 2] == 2 && xox[1, 1] == 2 && xox[2, 0] == 2) { return 0; }
                }
            }
            return 2;
        }

        private void Pc0_Click(object sender, EventArgs e)
        {
            if(potez % 2 == 0 && igrano[0] == false)
            {
                pc0.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[0] = true;
                xox[0, 0] = 1;
            }
            else if(potez % 2 == 1 && igrano[0] == false)
            {
                pc0.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[0] = true;
                xox[0, 0] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if(Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }

        private void Pc1_Click(object sender, EventArgs e)
        {
            if (potez % 2 == 0 && igrano[1] == false)
            {
                pc1.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[1] = true;
                xox[0, 1] = 1;
            }
            else if (potez % 2 == 1 && igrano[1] == false)
            {
                pc1.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[1] = true;
                xox[0, 1] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if (Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }

        private void Pc2_Click(object sender, EventArgs e)
        {
            if (potez % 2 == 0 && igrano[2] == false)
            {
                pc2.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[2] = true;
                xox[0, 2] = 1;
            }
            else if (potez % 2 == 1 && igrano[2] == false)
            {
                pc2.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[2] = true;
                xox[0, 2] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if (Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }

        private void Pc3_Click(object sender, EventArgs e)
        {
            if (potez % 2 == 0 && igrano[3] == false)
            {
                pc3.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[3] = true;
                xox[1, 0] = 1;
            }
            else if (potez % 2 == 1 && igrano[3] == false)
            {
                pc3.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[3] = true;
                xox[1, 0] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if (Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }

        private void Pc4_Click(object sender, EventArgs e)
        {
            if (potez % 2 == 0 && igrano[4] == false)
            {
                pc4.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[4] = true;
                xox[1, 1] = 1;
            }
            else if (potez % 2 == 1 && igrano[4] == false)
            {
                pc4.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[4] = true;
                xox[1, 1] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if (Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }

        private void Pc5_Click(object sender, EventArgs e)
        {
            if (potez % 2 == 0 && igrano[5] == false)
            {
                pc5.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[5] = true;
                xox[1, 2] = 1;
            }
            else if (potez % 2 == 1 && igrano[5] == false)
            {
                pc5.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[5] = true;
                xox[1, 2] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if (Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }

        private void Pc6_Click(object sender, EventArgs e)
        {
            if (potez % 2 == 0 && igrano[6] == false)
            {
                pc6.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[6] = true;
                xox[2, 0] = 1;
            }
            else if (potez % 2 == 1 && igrano[6] == false)
            {
                pc6.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[6] = true;
                xox[2, 0] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if (Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }

        private void Pc7_Click(object sender, EventArgs e)
        {
            if (potez % 2 == 0 && igrano[7] == false)
            {
                pc7.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[7] = true;
                xox[2, 1] = 1;
            }
            else if (potez % 2 == 1 && igrano[7] == false)
            {
                pc7.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[7] = true;
                xox[2, 1] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if (Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }

        private void Pc8_Click(object sender, EventArgs e)
        {
            if (potez % 2 == 0 && igrano[8] == false)
            {
                pc8.Image = Image.FromFile("multiply_64px.png");
                potez++; igrano[8] = true;
                xox[2, 2] = 1;
            }
            else if (potez % 2 == 1 && igrano[8] == false)
            {
                pc8.Image = Image.FromFile("circle_64px.png");
                potez++; igrano[8] = true;
                xox[2, 2] = 2;
            }
            if (Win() == 1) { MessageBox.Show("X je pobedio!"); }
            else if (Win() == 0) { MessageBox.Show("OX je pobedio!"); }
        }
    }
}
