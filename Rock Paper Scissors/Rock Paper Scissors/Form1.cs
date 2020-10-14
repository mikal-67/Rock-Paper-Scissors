using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        int decision;
        bool DecisionMade = false;
        int comDecision;

       
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            comDecision = r.Next(1, 4);
        }

        private void button1_Click(object sender, EventArgs e)//Rock
        {
            decision = 1;
            DecisionMade = true;
            WinOrLose();
            ButtonDisable();
        }

        private void button2_Click(object sender, EventArgs e)//Paper
        {
            decision = 2;
            DecisionMade = true;
            WinOrLose();
           ButtonDisable();

        }

        private void button3_Click(object sender, EventArgs e)//Scissors
        { 
            decision = 3;
            DecisionMade = true;
            WinOrLose();
           ButtonDisable();
        }
        void ButtonDisable()
        {
            if(DecisionMade == true)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }

        }


         void WinOrLose()
         {
            if (comDecision == decision)
            {
                textBox1.Text = "You tied.";
            }
            else if (comDecision == 1 && DecisionMade == true)//com is rock
            {
                if(decision == 3)
                {
                    textBox1.Text = "You lost...";
                }
                else if(decision == 2)
                {
                    textBox1.Text = "You Won!";
                }               
            }
            else if (comDecision == 2 && DecisionMade == true)//com is paper
            {
                /*if (comDecision == 3 && decision == 1)
                {
                    textBox1.Text = "You Won!";
                }
                textBox1.Text = "You Won!";*/
                if (decision == 1)
                {
                    textBox1.Text = "You lost...";
                }
                else if (decision == 3)
                {
                    textBox1.Text = "You Won!";
                }
            }
            else if(comDecision == 3 && DecisionMade == true)//com is scis
            {
                // textBox1.Text = "You tied.";
                if (decision == 2)
                {
                    textBox1.Text = "You lost...";
                }
                else if (decision == 1)
                {
                    textBox1.Text = "You Won!";
                }
            }
            else
            {
                textBox1.Text = null;
            }
            


            if (decision == 1)
            {

                textBox3.Text = "Your decision was Rock.";

            }
            else if (decision == 2)
            {
                textBox3.Text = "Your decision was Paper.";
            }
            else if (decision == 3)
            {
                textBox3.Text = "Your decision was Scissors.";
            }

            if (comDecision == 1)
            {
                textBox2.Text = "Your opponent's decision was Rock.";
            }
            else if (comDecision == 2)
            {
                textBox2.Text = "Your opponent's decision was Paper.";
            }
            else if (comDecision == 3)
            {
                textBox2.Text = "Your opponent's decision was Scissors.";
            }
        

            button4.Enabled = true;


        }

        private void button4_Click(object sender, EventArgs e)//reset vars
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            comDecision = r.Next(1, 4);
            decision = 0;
            DecisionMade = false;
            
            button4.Enabled = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
          
        }
    }
}
