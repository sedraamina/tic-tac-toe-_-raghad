﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int xo = 0;
        int player1 = 0;
        int player2 = 0;
        bool win = false;

        void getthewinner()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                wineffect(btn1, btn2, btn3);
                win = true;
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn1.Text == btn6.Text)
            {
                wineffect(btn4, btn5, btn6);
                win = true;
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                wineffect(btn7, btn8, btn9);
                win = true;
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                wineffect(btn1, btn4, btn7);
                win = true;
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn1.Text == btn8.Text)
            {
                wineffect(btn2, btn5, btn8);
                win = true;
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                wineffect(btn3, btn6, btn9);
                win = true;
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                wineffect(btn1, btn5, btn7);
                win = true;
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                wineffect(btn3, btn5, btn9);
                win = true;
            }
        }
        void loadbuttons()
        {
            buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };


        }
        void Wineffect(Button b1, Button b2, Button b3)
        {
            b1.ForeColor = Color.Red;
            b2.ForeColor = Color.Red;
            b3.ForeColor = Color.Red;
            if (b1.Text == "X")
            {
                plaer1++;
                label3.Text = plaer1.ToString();
            }
            else
            {
                player2++;
                label4.Text = player2.ToString();
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                if (xo % 2 == 0)
                {

                    btn.Text = "X";
                    btn.ForeColor = Color.Gold;
                    getthewinner();
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Red;
                    getthewinner();
                }

                xo++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xo = 0; win = false;
            foreach (Control c in panelofButtons.Controls) 
            {
                if (c is Button)
                {
                    c.Text = "";
                }
            }
        }
    }
}
    

