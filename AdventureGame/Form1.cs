using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //tracks page number
        int page = 1;

        //creates random generator
        Random RandGen = new Random();

        //creates sound player
        SoundPlayer musicPlayer;

        public Form1()
        {
            InitializeComponent();
            //creates and generates random number
            int pageNumber;
            pageNumber = RandGen.Next(1, 5);

            //display opening game text and options
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //checks what page you're on and flips to the correct page if option 1 is chosen
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 7; }
            else if (page == 4) { page = 9; }
            else if (page == 6) { page = 11; }
            else if (page == 7)
            {
                int pageNumber;
                pageNumber = RandGen.Next(1, 5);
                if (pageNumber == 1)
                {
                    page = 13;
                }
                else
                {
                    page = 14;
                }
            }
            else if (page == 9) { page = 16; }
            else if (page == 10) { page = 18; }
            else if (page == 15) { page = 20; }
            else if (page == 17) { page = 22; }
            else if (page == 20) { page = 24; }
            else if (page == 21) { page = 26; }
            else if (page == 5) { page = 1; }
            else if (page == 8) { page = 1; }
            else if (page == 11) { page = 1; }
            else if (page == 12) { page = 1; }
            else if (page == 13) { page = 1; }
            else if (page == 14) { page = 1; }
            else if (page == 16) { page = 1; }
            else if (page == 18) { page = 1; }
            else if (page == 19) { page = 1; }
            else if (page == 22) { page = 1; }
            else if (page == 23) { page = 1; }
            else if (page == 24) { page = 1; }
            else if (page == 25) { page = 1; }
            else if (page == 26) { page = 1; }
            else if (page == 27) { page = 1; }

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //checks what page you're on and flips to the correct page if option 2 is chosen
            if (page == 1) { page = 3; }
            else if (page == 2) { page = 6; }
            else if (page == 3) { page = 8; }
            else if (page == 4) { page = 10; }
            else if (page == 6) { page = 12; }
            else if (page == 7) { page = 15; }
            else if (page == 9) { page = 17; }
            else if (page == 10) { page = 19; }
            else if (page == 15) { page = 21; }
            else if (page == 17) { page = 23; }
            else if (page == 20) { page = 25; }
            else if (page == 21) { page = 27; }
            else if (page == 5) { page = 99; }
            else if (page == 8) { page = 99; }
            else if (page == 11) { page = 99; }
            else if (page == 12) { page = 99; }
            else if (page == 13) { page = 99; }
            else if (page == 14) { page = 99; }
            else if (page == 16) { page = 99; }
            else if (page == 18) { page = 99; }
            else if (page == 19) { page = 99; }
            else if (page == 22) { page = 99; }
            else if (page == 23) { page = 99; }
            else if (page == 24) { page = 99; }
            else if (page == 25) { page = 99; }
            else if (page == 26) { page = 99; }
            else if (page == 27) { page = 99; }

            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            //checks what page you're on and flips to the correct page if option 3 is chosen
            if (page == 2) { page = 5; }

            DisplayPage();
        }

        public void DisplayPage()
        {
            //Displaying appropriate messages depending on what button is pressed
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You have a criminal in holding and have to decide how to break him.";
                    button1Label.Text = "Good Cop";
                    button2Label.Text = "Bad Cop";

                    break;
                case 2:
                    option3Button.Visible = true;
                    outputLabel.Text = "You say you know it is an accident and you can get a lesser sentence. He denies. Do you show eye witness, motives or say he has no choice?";
                    button1Label.Text = "Eye Witness";
                    button2Label.Text = "Motives";
                    button3Label.Text = "No Choice";

                    break;
                case 3:
                    outputLabel.Text = "You go in screaming and bang your hand on the table. He isn't intimated.";
                    button1Label.Text = "Throw chair";
                    button2Label.Text = "Calm Down";

                    break;
                case 4:
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    outputLabel.Text = "Eye Witness says they saw you leave scene of the crime 20 mins later. He says it's unrelated. Will you ask why he was there or talk about his previous charges?";
                    button1Label.Text = "Why was he there";
                    button2Label.Text = "Previous Charges";

                    break;
                case 5:
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    outputLabel.Text = "He says that's enough and doesn't  want to talk anymore. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 6:
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    outputLabel.Text = "He has all the reasons to do it but he says it is in the past. Will you keep digging or talk about why he was picked up?";
                    button1Label.Text = "Why he was picked up";
                    button2Label.Text = "Keep Digging";

                    break;
                case 7:
                    outputLabel.Text = "You throw the chair and he is rattled. Ask him to confess or keep up the act?";
                    button1Label.Text = "Confess";
                    button2Label.Text = "Keep up the act";

                    break;
                case 8:
                    outputLabel.Text = "You sit down and talk. He knows you are fake and wants his lawyer. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 9:
                    outputLabel.Text = "He says it was to visit someone else";
                    button1Label.Text = "Bluff";
                    button2Label.Text = "Truth";

                    break;
                case 10:
                    outputLabel.Text = "Tell him how he was in prison for assault before. He says he moved on";
                    button1Label.Text = "Pressure";
                    button2Label.Text = "Believe him";

                    break;
                case 11:
                    outputLabel.Text = "Tell him about how he was reported by a 911 call near the scene. He confesses. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 12:
                    outputLabel.Text = "He gets fed up and calls for his lawyer. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 13:
                    outputLabel.Text = "He is scared and confesses. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 14:
                    outputLabel.Text = "He refuses to talk. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 15:
                    outputLabel.Text = "Tell him about the evidence collected.";
                    button1Label.Text = "Eye Witnesses";
                    button2Label.Text = "Motives";

                    break;
                case 16:
                    outputLabel.Text = "He confesses. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 17:
                    outputLabel.Text = "You ask who it was and he says it is his girl.";
                    button1Label.Text = "Bluff";
                    button2Label.Text = "Truth";

                    break;
                case 18:
                    outputLabel.Text = "He cracks and confesses. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 19:
                    outputLabel.Text = "You never get him to confess. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 20:
                    outputLabel.Text = "He says he was there but that doesn't prove anything. Will you tell him his potential jail time or yell at him";
                    button1Label.Text = "Jail Time";
                    button2Label.Text = "Yell";

                    break;
                case 21:
                    outputLabel.Text = "He doesn't say anything";
                    button1Label.Text = "Pressure him";
                    button2Label.Text = "Let him think";

                    break;
                case 22:
                    outputLabel.Text = "He confesses. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 23:
                    outputLabel.Text = "You never get him to confess. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 24:
                    outputLabel.Text = "He doesn't confess. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 25:
                    outputLabel.Text = "He confesses. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 26:
                    outputLabel.Text = "He doesn't confess. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 27:
                    outputLabel.Text = "He confesses. Play Again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";

                    break;
                case 99:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    
                    outputLabel.Text = "Thanks for playing";
                    button1Label.Text = "";
                    button2Label.Text = "";

                    Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();

                    break;
            }
        }
    }
}
