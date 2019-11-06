using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace AdventureGameDeclanFeoreJamesKoch
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        //all sounds in the game
        SoundPlayer carCrash = new SoundPlayer(Properties.Resources.car_crash);
        SoundPlayer carEngine = new SoundPlayer(Properties.Resources.car_engine);
        SoundPlayer goatScream = new SoundPlayer(Properties.Resources.goat_scream);
        SoundPlayer dramatic = new SoundPlayer(Properties.Resources.dramatic);

        public Form1()
        {
            InitializeComponent();
            
            //display initial message and options
            outputLabel.Text = "You want to go to your friend's house. What mode of transportation will you use.";
            redLabel.Text = "Walk";
            blueLabel.Text = "Drive";
            yellowLabel.Text = "Skip driving, stay inside, and don't hangout with anyone";
            sceneImage.BackgroundImage = Properties.Resources.case_0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance to the next appropriate scene.
            if (e.KeyCode == Keys.B) //red button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 5; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 4) { scene = 8; }
                else if (scene == 5) { scene = 10; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 7) { scene = 12; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 9) { scene = 14; }
                else if (scene == 10) { scene = 16; }
                else if (scene == 11) { scene = 0; }
                else if (scene == 12) { scene = 99; }
                else if (scene == 13) { scene = 0; }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 99; }
                else if (scene == 16) { scene = 18; }
                else if (scene == 17) { scene = 20; }
                else if (scene == 18) { scene = 0; }
                else if (scene == 19) { scene = 99; }
                else if (scene == 20) { scene = 99; }
                else if (scene == 21) { scene = 0; }
                else if (scene == 99) { scene = 100; }
                else if (scene == 100) { scene = 0; }
                else if (scene == 101) { scene = 0; }
                else if (scene == 102) { scene = 0; }
            }
            else if (e.KeyCode == Keys.N) //blue button press
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 3) { scene = 8; }
                else if (scene == 4) { scene = 9; }
                else if (scene == 5) { scene = 11; }
                else if (scene == 6) { this.Close(); }
                else if (scene == 7) { scene = 13; }
                else if (scene == 8) { this.Close(); }
                else if (scene == 9) { scene = 15; }
                else if (scene == 10) { scene = 17; }
                else if (scene == 11) { this.Close(); }
                else if (scene == 13) { this.Close(); }
                else if (scene == 14) { this.Close(); }
                else if (scene == 16) { scene = 19; }
                else if (scene == 17) { scene = 21; }
                else if (scene == 18) { this.Close(); }
                else if (scene == 21) { this.Close(); }
                else if (scene == 99) { scene = 101; }
                else if (scene == 100) { this.Close(); }
                else if (scene == 101) { this.Close(); }
                else if (scene == 102) { this.Close(); }
            }
            else if (e.KeyCode == Keys.M) //yellow button press
            {
                if (scene == 0) { scene = 0; }
                else if (scene == 6) { scene = 5; }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You want to go to a friends house. What mode of transportatation do you use?";
                    redLabel.Text = "Walk";
                    blueLabel.Text = "Drive";
                    yellowLabel.Text = "Skip driving, stay inside, and don't hangout with anyone";
                    bLabel.Visible = true;
                    mLabel.Visible = true;
                    sceneImage.BackgroundImage = Properties.Resources.case_0;
                    break;
                case 1:
                    outputLabel.Text = "Do you walk the long safe way or the short scary way?";
                    redLabel.Text = "Long Safe Way";
                    blueLabel.Text = "Short Scary Way";
                    yellowLabel.Text = "";
                    mLabel.Visible = false;
                    dramatic.Play();
                    sceneImage.BackgroundImage = Properties.Resources.case_1_real;
                    break;
                case 2:
                    outputLabel.Text = "What car do you drive? 2002 Honda Civic or 2019 Ferrari";
                    redLabel.Text = "2002 Honda Civic";
                    blueLabel.Text = "2019 Ferraria";
                    yellowLabel.Text = "";
                    mLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.case_2;
                    carEngine.Play();
                    break;
                case 3:
                    outputLabel.Text = "It is taking too long just walking and you become impatient. Do you begin to run or continue walking?";
                    redLabel.Text = "Walk";
                    blueLabel.Text = "Run";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_3_realerson;
                    break;
                case 4:
                    outputLabel.Text = "You are walking down by the river and hear 'help!'. Do you check it out or run away?";
                    redLabel.Text = "Run away";
                    blueLabel.Text = "Check it out";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_4;
                    break;
                case 5:
                    outputLabel.Text = "Do you go get food on your way to your friends, or skip food and go right to your friends?";
                    redLabel.Text = "Get food";
                    blueLabel.Text = "Skip food";
                    bLabel.Visible = true;
                    nLabel.Visible = true;
                    mLabel.Visible = false;
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_5;
                    break;
                case 6:
                    int chance = randGen.Next(1, 11);
                    if (chance < 8)
                    { outputLabel.Text = "You chose the Ferrari!"; yellowLabel.Text = "Continue"; blueLabel.Text = ""; redLabel.Text = ""; mLabel.Visible = true; nLabel.Visible = false; bLabel.Visible = false; sceneImage.BackgroundImage = Properties.Resources.case_6_real; }
                    else if (chance >= 8)
                    { outputLabel.Text = "You crashed the car and died."; redLabel.Text = "Play again"; blueLabel.Text = "Exit"; yellowLabel.Text = ""; mLabel.Enabled = false; sceneImage.BackgroundImage = Properties.Resources.case_6;
                        carCrash.Play();
                    }
                    break;
                case 7:
                    outputLabel.Text = "You get thirsty and see a puddle on the road. Do you take a drink from it?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    bLabel.Visible = true;
                    nLabel.Visible = true;
                    mLabel.Visible = false;
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_7;
                    break;
                case 8:
                    outputLabel.Text = "You trip over a stick, hit your head, and internally bleed to death! Play again?";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_8;
                    break;
                case 9:
                    outputLabel.Text = "Oh my goodness! It is a screaming goat! Do you pet it?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_9;
                    goatScream.Play();
                    break;
                case 10:
                    outputLabel.Text = "What food store do you go to? Subway or Louisiana Chicken?";
                    redLabel.Text = "Subway";
                    blueLabel.Text = "Louisiana Chicken";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_10;
                    break;
                case 11:
                    outputLabel.Text = "You die of hunger! Play again?";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_11;
                    break;
                case 12:
                    outputLabel.Text = "You make it to your friends house nice and hydrated.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    nLabel.Visible = false;
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_12;
                    break;
                case 13:
                    outputLabel.Text = "You die of thirst! Play again?";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_13;
                    break;
                case 14:
                    outputLabel.Text = "The goat gets mad and eats you painfully! Play again?";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_14;
                    break;
                case 15:
                    outputLabel.Text = "You continue walking to your friends house, but the goat stares at you menacingly.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    nLabel.Visible = false;
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_15_real;
                    break;
                case 16:
                    outputLabel.Text = "Do you get a tuna sub or BLT?";
                    redLabel.Text = "Tuna sub";
                    blueLabel.Text = "BLT";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_16_sub;
                    break;
                case 17:
                    outputLabel.Text = "Do you get Popcorn chicken or Chicken tenders? ";
                    redLabel.Text = "Popcorn chicken";
                    blueLabel.Text = "Chicken tenders";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_17;
                    break;
                case 18:
                    outputLabel.Text = "You die of mercury poisoning! Play again?";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case18;
                    break;
                case 19:
                    outputLabel.Text = "After eating you drive to your friends.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    nLabel.Visible = false;
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_18;
                    break;
                case 20:
                    outputLabel.Text = "The popcorn chicken is so good and filling!";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    nLabel.Visible = false;
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Shridar_Patel;
                    break;
                case 21:
                    outputLabel.Text = "The chicken tenders are under cooked, and you get salmonella poisoning and die! Play again";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_21;
                    break;
                case 99:
                    outputLabel.Text = "When you get there, do you walk right in or knock on the door first?";
                    redLabel.Text = "Walk right in";
                    blueLabel.Text = "Knock first";
                    nLabel.Visible = true;
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_99;
                    break;
                case 100:
                    outputLabel.Text = "You get shot by your friend because he confused you for an intruder! Play again?";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_100;
                    break;
                case 101:
                    outputLabel.Text = "You have fun with your friend! Thanks for playing! Play again?";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.case_101;
                    break;
                case 102:
                    outputLabel.Text = "You're boring! Play again?";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit";
                    yellowLabel.Text = "";
                    mLabel.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}