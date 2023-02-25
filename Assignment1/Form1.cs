using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnQF12.Enabled = false;
            btnQF34.Enabled = false;
            btnQF56.Enabled = false;
            btnQF78.Enabled = false;
            btnSF12.Enabled = false;
            btnSF34.Enabled = false;
            btnF.Enabled    = false;

            string[] teams = { "India", "Australia", "South Africa", "England", "Pakistan", "Sri Lanka", "Bangladesh", "WestIndies" };




        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDrawTeams_Click(object sender, EventArgs e)

        {
            btnQF12.Enabled = true;
            btnDrawTeams.Enabled = false;
            // Random random = new Random();
            Random win = new Random();
          //  int items = 0;
            //int temp = 0;

            string[] teams = { "India", "Australia", "South Africa", "England", "Pakistan", "Sri Lanka", "Bangladesh", "WestIndies" };


            for(int i = 0; i<=7; i++)
            {
                int items = 0;
                items = win.Next(0, 8);
                string tempTeam = teams[i];      //declaring tempTemp as string variable and equaling it into teams of array i.
                teams[i] = teams[items]; //making the teams of array i and equaling it to teams of array items 
                teams[items] = tempTeam;  // now giving the value of teams of array items to tempTeam.
            }

            for(int i =0; i<=7; i++)
            {
                if(i==0)
                {
                    lblQf1.Text = teams[i];
                }
                else if(i == 1)
                {
                    lblQF2.Text = teams[i];
                }
                else if (i == 2)
                {
                    lblQF3.Text = teams[i];
                }
                else if (i == 3)
                {
                    lblQF4.Text = teams[i];
                }
                else if (i == 4)
                {
                    lblQF5.Text = teams[i];
                }
                else if (i == 5)
                {
                    lblQF6.Text = teams[i];
                }
                else if (i == 6)
                {
                    lblQF7.Text = teams[i];
                }
                else if (i == 7)
                {
                    lblQF8.Text = teams[i];
                }
            }

            
            // int items = win.Next(0,8);
            
            //do
            //{
            //     items = win.Next(0, 8);
            //    lblQf1.Text = teams[items];
            //    lblQF2.Text = teams[items];
            //    lblQF3.Text = teams[items];
            //    lblQF4.Text = teams[items];
            //    lblQF5.Text = teams[items];
            //    lblQF6.Text = teams[items];
            //    lblQF7.Text = teams[items];
            //    lblQF8.Text = teams[items];
            //} while (teams[items]!= teams[items]);
         
            //lstbox.Items.AddRange(teams);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnDrawTeams.Enabled = true;
            lblQf1.ForeColor = Color.Black;
            lblQf1.ResetText();
            lblQF2.ForeColor = Color.Black;
            lblQF2.ResetText();
            lblQF3.ForeColor = Color.Black; 
            lblQF3.ResetText();
            lblQF4.ForeColor = Color.Black;
            lblQF4.ResetText();
            lblQF5.ForeColor = Color.Black;
            lblQF5.ResetText();
            lblQF6.ForeColor = Color.Black;
            lblQF6.ResetText();
            lblQF7.ForeColor = Color.Black;
            lblQF7.ResetText();
            lblQF8.ForeColor = Color.Black;
            lblQF8.ResetText();
            lblSF1.ForeColor = Color.Black;
            lblSF1.ResetText();
            lblSF2.ForeColor = Color.Black;
            lblSF2.ResetText();
            lblSF3.ForeColor = Color.Black;
            lblSF3.ResetText();
            lblSF4.ForeColor = Color.Black;
            lblSF4.ResetText();
            lblF1.ForeColor = Color.Black;
            lblF1.ResetText();
            lblF2.ForeColor = Color.Black;
            lblF2.ResetText();
            btnQF12.Enabled = false;
            btnQF34.Enabled = false;
            btnQF56.Enabled = false;
            btnQF78.Enabled = false;
            btnSF12.Enabled = false;
            btnSF34.Enabled = false;
            btnF.Enabled = false;
            lblScoreF1.ResetText();
            lblScoreF2.ResetText();
            lblScoreQF1.ResetText();
            lblScoreQF2.ResetText();
            lblScoreQF3.ResetText();
            lblScoreQF4.ResetText();
            lblScoreQF5.ResetText();
            lblScoreQF6.ResetText();
            lblScoreQF7.ResetText();
            lblScoreQF8.ResetText();
            lblScoreSF1.ResetText();
            lblScoreSF2.ResetText();
            lblScoreSF3.ResetText();
            lblScoreSF4.ResetText();
        }

        private void grpQF1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            btnQF12.Enabled = false;
            btnQF34.Enabled = true;
            int number1;
            int number2;
            do
            {
                number1 = random.Next(70, 300);
                number2 = random.Next(70, 300);

            } while (number1 == number2);
            lblScoreQF1.Text = number1.ToString();
            lblScoreQF2.Text = number2.ToString();
                if(number1 > number2){

                    lblQf1.ForeColor = Color.Green;
                lblQF2.ForeColor = Color.Red;
                lblSF1.Text = lblQf1.Text;
                }
                else
                {
                lblQf1.ForeColor = Color.Red;
                lblQF2.ForeColor = Color.Green;
                    lblSF1.Text = lblQF2.Text;

                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            btnQF78.Enabled = false;
            btnSF12.Enabled = true;
            int number1;
            int number2;
            do
            {
                number1 = random.Next(70, 300);
                number2 = random.Next(70, 300);

            } while (number1 == number2);
            lblScoreQF7.Text = number1.ToString();
            lblScoreQF8.Text = number2.ToString();
                if (number1 > number2)
                {
                    lblQF7.ForeColor = Color.Green;
                    lblQF8.ForeColor = Color.Red;
                    lblSF4.Text = lblQF7.Text;
                }
                else
                {
                lblQF7.ForeColor = Color.Red;
                lblQF8.ForeColor = Color.Green;
                    lblSF4.Text = lblQF8.Text;
                }
                
           
        }

        private void btnQF34_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            btnQF34.Enabled = false;
            btnQF56.Enabled = true;
            int number1;
            int number2;
            do
            {
                number1 = random.Next(70, 300);
                number2 = random.Next(70, 300);
            } while (number1 == number2);

                    lblScoreQF3.Text = number1.ToString();
                   lblScoreQF4.Text = number2.ToString();
                if (number1 > number2)
                {
                    lblQF3.ForeColor= Color.Green;
                    lblQF4.ForeColor = Color.Red;
                    lblSF2.Text = lblQF3.Text;
                    
                }
                else
                {
                    lblQF3.ForeColor = Color.Red;
                    lblQF4.ForeColor = Color.Green;
                    lblSF2.Text = lblQF4.Text;
                }
        }

        private void btnSF12_Click(object sender, EventArgs e)
        {
            btnSF12.Enabled = false;
            btnSF34.Enabled = true;
            Random random = new Random();
            int number1;
            int number2;
            do
            {
                number1 = random.Next(70, 300);
                number2 = random.Next(70, 300);

            } while (number1 == number2);

            lblScoreSF1.Text = number1.ToString();
            lblScoreSF2.Text = number2.ToString();
            if(number1 > number2)
            {
                lblSF1.ForeColor = Color.Green;
                lblSF2.ForeColor = Color.Red;
                lblF1.Text = lblSF1.Text;
            }
            else
            {
                lblSF2.ForeColor = Color.Green;
                lblSF1.ForeColor = Color.Red;
                lblF1.Text = lblSF2.Text;
            }   
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Enabled = false;
            Random random = new Random();
            int number1;
            int number2;
            
            do
            {
                number1 = random.Next(70, 300);
                number2 = random.Next(70, 300);

            } while (number1 == number2);
            lblScoreF1.Text = number1.ToString();
            lblScoreF2.Text = number2.ToString();
            if (number1 > number2)
                {
                    lblF1.ForeColor = Color.Green;
                    lblF2.ForeColor = Color.Red;

            }
                else
                {
                
                    lblF2.ForeColor = Color.Green;
                    lblF1.ForeColor = Color.Red;
            }
        }

        private void btnSF34_Click(object sender, EventArgs e)
        {
            btnSF34.Enabled = false;
            btnF.Enabled = true;
            Random random = new Random();
            int number1;
            int number2;
            do
            {
                number1 = random.Next(70, 300);
                number2 = random.Next(70, 300);

            } while (number1 == number2);

            lblScoreSF3.Text = number1.ToString();
            lblScoreSF4.Text = number2.ToString();
                if (number1 > number2)
                {
                    lblSF3.ForeColor = Color.Green;
                lblSF4.ForeColor = Color.Red;
                lblF2.Text = lblSF3.Text;
                }
                else
                {
                    lblSF4.ForeColor = Color.Green;
                lblSF3.ForeColor = Color.Red;
                lblF2.Text = lblSF4.Text;
                }
            
        }

        private void btnQF56_Click(object sender, EventArgs e)
        {
            btnQF56.Enabled = false;
            btnQF78.Enabled = true;
            Random random = new Random();
            int number1 = random.Next(70, 300);
            int number2 = random.Next(70, 300);
            do
            {
                number1 = random.Next(70, 300);
                number2 = random.Next(70, 300);

            } while (number1 == number2);
            lblScoreQF5.Text = number1.ToString();
            lblScoreQF6.Text = number2.ToString();

                if (number1 > number2)
                {
                    lblQF5.ForeColor = Color.Green;
                lblQF6.ForeColor = Color.Red;
                lblSF3.Text = lblQF5.Text;
                }
                else
                {
                lblQF5.ForeColor = Color.Red;
                lblQF6.ForeColor = Color.Green;
                lblSF3.Text = lblQF6.Text;
                }
        }

        private void grpFinals_Enter(object sender, EventArgs e)
        {

        }
    }
}