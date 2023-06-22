using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIkTakToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public bool XOcheck = true;
        public int drawcount = 0;
        public void CheckWin()
        {
            if (t1.Text == "X" && t2.Text == "X" && t3.Text == "X")
            {
                t1.BackColor = Color.Green;
                t2.BackColor = Color.Green;
                t3.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
            else if (t4.Text == "X" && t5.Text == "X" && t6.Text == "X")
            {
                t4.BackColor = Color.Green;
                t5.BackColor = Color.Green;
                t6.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
            else if (t7.Text == "X" && t8.Text == "X" && t9.Text == "X")
            {
                t7.BackColor = Color.Green;
                t8.BackColor = Color.Green;
                t9.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
            else if (t1.Text == "X" && t4.Text == "X" && t7.Text == "X")
            {
                t1.BackColor = Color.Green;
                t4.BackColor = Color.Green;
                t7.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
            else if (t2.Text == "X" && t5.Text == "X" && t8.Text == "X")
            {
                t2.BackColor = Color.Green;
                t5.BackColor = Color.Green;
                t8.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
            else if (t3.Text == "X" && t6.Text == "X" && t9.Text == "X")
            {
                t3.BackColor = Color.Green;
                t6.BackColor = Color.Green;
                t9.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
            else if (t1.Text == "X" && t5.Text == "X" && t9.Text == "X")
            {
                t1.BackColor = Color.Green;
                t5.BackColor = Color.Green;
                t9.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
           else  if (t3.Text == "X" && t5.Text == "X" && t7.Text == "X")
            {
                t3.BackColor = Color.Green;
                t5.BackColor = Color.Green;
                t7.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
            else if (t1.Text == "O" && t2.Text == "O" && t3.Text == "O")
            {
                t1.BackColor = Color.Green;
                t2.BackColor = Color.Green;
                t3.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                btnNewGame.Visible = true;
            }
           else  if (t4.Text == "O" && t5.Text == "O" && t6.Text == "O")
            {
                t4.BackColor = Color.Green;
                t5.BackColor = Color.Green;
                t6.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                btnNewGame.Visible = true;
            }
          else   if (t7.Text == "O" && t8.Text == "O" && t9.Text == "O")
            {
                t7.BackColor = Color.Green;
                t8.BackColor = Color.Green;
                t9.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
           else  if (t1.Text == "O" && t4.Text == "O" && t7.Text == "O")
            {
                t1.BackColor = Color.Green;
                t4.BackColor = Color.Green;
                t7.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                btnNewGame.Visible = true;
            }
          else   if (t2.Text == "O" && t5.Text == "O" && t8.Text == "O")
            {
                t2.BackColor = Color.Green;
                t5.BackColor = Color.Green;
                t8.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                btnNewGame.Visible = true;
            }
           else  if (t3.Text == "O" && t6.Text == "O" && t9.Text == "O")
            {
                t3.BackColor = Color.Green;
                t6.BackColor = Color.Green;
                t9.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                btnNewGame.Visible = true;
            }
           else  if (t1.Text == "O" && t5.Text == "O" && t9.Text == "O")
            {
                t1.BackColor = Color.Green;
                t5.BackColor = Color.Green;
                t9.BackColor = Color.Green;
                MessageBox.Show("X wins!");
                btnNewGame.Visible = true;
            }
            else if (t3.Text == "O" && t5.Text == "O" && t7.Text == "O")
            {
                t3.BackColor = Color.Green;
                t5.BackColor = Color.Green;
                t7.BackColor = Color.Green;
                MessageBox.Show("O wins!");
                btnNewGame.Visible = true;
            }
            else if (drawcount == 9)
            {
                MessageBox.Show("Draw!");
                btnNewGame.Visible = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t2.Text = "X";
            }
            if (XOcheck == false)
            {
                t2.Text = "O";
            }
            XOcheck = !XOcheck;
            t2.Enabled = false;
            drawcount++;
            CheckWin();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t4.Text = "X";
            }
            if (XOcheck == false)
            {
                t4.Text = "O";
            }
            XOcheck = !XOcheck;
            t4.Enabled = false;
            drawcount++;
            CheckWin();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t7.Text = "X";
            }
            if (XOcheck == false)
            {
                t7.Text = "O";
            }
            XOcheck = !XOcheck;
            t7.Enabled = false;
            drawcount++;
            CheckWin();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t8.Text = "X";
            }
            if (XOcheck == false)
            {
                t8.Text = "O";
            }
            XOcheck = !XOcheck;
            t8.Enabled = false;
            drawcount++;
            CheckWin();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t5.Text = "X";
            }
            if (XOcheck == false)
            {
                t5.Text = "O";
            }
            XOcheck = !XOcheck;
            t5.Enabled = false;
            drawcount++;
            CheckWin();
        }

        private void t1_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t1.Text = "X";
            }
            if (XOcheck == false)
            {
                t1.Text = "O";
            }
            t1.Enabled = false;
            XOcheck = !XOcheck;
            drawcount++;
            CheckWin();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t3.Text = "X";
            }
            if (XOcheck == false)
            {
                t3.Text = "O";
            }
            XOcheck = !XOcheck;
            t3.Enabled = false;
            drawcount++;
            CheckWin();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t6.Text = "X";
            }
            if (XOcheck == false)
            {
                t6.Text = "O";
            }
            XOcheck = !XOcheck;
            t6.Enabled = false;
            drawcount++;
            CheckWin();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (XOcheck == true)
            {
                t9.Text = "X";
            }
            if (XOcheck == false)
            {
                t9.Text = "O";
            }
            XOcheck = !XOcheck;
            t9.Enabled = false;
            drawcount++;
            CheckWin();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t1.BackColor = Color.White;
            t2.Text = "";
            t2.BackColor = Color.White;
            t3.Text = "";
            t3.BackColor = Color.White;
            t4.Text = "";
            t4.BackColor = Color.White;
            t5.Text = "";
            t5.BackColor = Color.White;
            t6.Text = "";
            t6.BackColor = Color.White;
            t7.Text = "";
            t7.BackColor = Color.White;
            t8.Text = "";
            t8.BackColor = Color.White;
            t9.Text = "";
            t9.BackColor = Color.White;
            btnNewGame.Visible = false;
            t1.Enabled = true;
            t2.Enabled = true;
            t3.Enabled = true;
            t4.Enabled = true;
            t5.Enabled = true;
            t6.Enabled = true;
            t7.Enabled = true;
            t8.Enabled = true;
            t9.Enabled = true;
            drawcount = 0;
        }
    }
}
