using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compounds
{
    public partial class Form1 : Form
    {
        string suit = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void hurricaneButton_Click(object sender, EventArgs e)
        {
            //get the inputted category
            string category = categoryInput.Text;

            //check the inputted category with a switch block
            switch(category)
            {
                case "1":
                    categoryOutput.Text = "119 - 153 km/h";
                    break;
                case "2":
                    categoryOutput.Text = "154 - 177 km/h";
                    break;
                case "3":
                    categoryOutput.Text = "178 - 209 km/h";
                    break;
                case "4":
                    categoryOutput.Text = "210 - 249 km/h";
                    break;
                case "5":
                    categoryOutput.Text = "250 and greater km/h";
                    break;
                default:
                    categoryOutput.Text = "Enter category 1-5";
                    break;
            }
        }

        private void heartButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "hearts";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Goldenrod;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Black;
        }

        private void diamondButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "diamonds";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Goldenrod;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Black;
        }

        private void clubButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "clubs";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black ;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Goldenrod;
            spadeButton.BackColor = Color.Black;
        }

        private void spadeButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "spades";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Goldenrod;
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to check what suit
            //has been selected and output the colour of the suit
            if (suit == "hearts" || suit == "diamonds" )
            {
                suitOutput.Text = "The card colour is red.";
            }
            else if (suit == "clubs" || suit == "spades")
            {
                suitOutput.Text = "The card colour is black.";
            }
            else
            {
                suitOutput.Text = "Please pick a suit.";
            }
        }

        private void thisButton_Click(object sender, EventArgs e)
        {
            //alternate BackColor between Black and Goldenrod 
            if (thisButton.BackColor == Color.Black)
            {
                thisButton.BackColor = Color.Goldenrod;
            }
            else
            {
                thisButton.BackColor = Color.Black;
            }
        }

        private void thatButton_Click(object sender, EventArgs e)
        {
            //alternate BackColor between Black and Goldenrod 
            if (thatButton.BackColor == Color.Black)
            {
                thatButton.BackColor = Color.Goldenrod;
            }
            else
            {
                thatButton.BackColor = Color.Black;
            }
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to give outputs based on 
            //if both colours are the same or different
            if (thisButton.BackColor == Color.Goldenrod && thatButton.BackColor == Color.Goldenrod)
            {
                andLabel.Text = "Both buttons are goldenrod.";
            }
            else if (thisButton.BackColor == Color.Black && thatButton.BackColor == Color.Black)
            {
                andLabel.Text = "Both buttons are black.";
            }
            else
            {
                andLabel.Text = "The buttons are different colours";
            }
        }
    }
}
