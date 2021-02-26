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

namespace Adventure_game
{
    public partial class Form1 : Form
    {
        int scene = 0;

        SoundPlayer cash = new SoundPlayer(Properties.Resources.Cash);
        SoundPlayer door = new SoundPlayer(Properties.Resources.Door);
        SoundPlayer death = new SoundPlayer(Properties.Resources.Death);
        SoundPlayer silence = new SoundPlayer(Properties.Resources.Silence);
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 20; }
                else if (scene == 4) { scene = 2; }
                else if (scene == 5) { scene = 41; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) 
                {
                    Random ranGen = new Random();
                    int value = ranGen.Next(1, 11);

                    if (value <= 5) { scene = 17; }
                    else { scene = 16; }
                }
                else if (scene == 8) { scene = 12; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 10) { scene = 41; }
                else if (scene == 11) { scene = 41; }
                else if (scene == 12) { scene = 34; }
                else if (scene == 13) { scene = 41; }
                else if (scene == 14) { scene = 9; }
                else if (scene == 15) { scene = 41; }
                else if (scene == 16) { scene = 41; }
                else if (scene == 17) { scene = 41; }
                else if (scene == 18) { scene = 19; }
                else if (scene == 19) { scene = 41; }
                else if (scene == 20) 
                {
                    Random ranGen = new Random();
                    int value = ranGen.Next(1, 11);

                    if (value <= 6) { scene = 28; }
                    else { scene = 27; }
                }
                else if (scene == 21) { scene = 23; }
                else if (scene == 22) { scene = 18; }
                else if (scene == 23) { scene = 41; }
                else if (scene == 24) { scene = 26; }
                else if (scene == 25) { scene = 41; }
                else if (scene == 26) { scene = 18; }
                else if (scene == 27) { scene = 41; }
                else if (scene == 28) { scene = 29; }
                else if (scene == 29) { scene = 41; }
                else if (scene == 30) { scene = 8; }
                else if (scene == 31) { scene = 39; }
                else if (scene == 32) { scene = 34; }
                else if (scene == 33) { scene = 35; }
                else if (scene == 34) { scene = 36; }
                else if (scene == 35) { scene = 38; }
                else if (scene == 36) { scene = 41; }
                else if (scene == 37) { scene = 41; }
                else if (scene == 38) { scene = 41; }
                else if (scene == 39) { scene = 41; }
                else if (scene == 40) { scene = 41; }
                else if (scene == 41) { scene = 1; }
            }
            else if (e.KeyCode == Keys.M)
            {
                if (scene == 0) { }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 32; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { }
                else if (scene == 6) { scene = 9; }
                else if (scene == 7) { scene = 14; }
                else if (scene == 8) { scene = 12; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { scene = 33; }
                else if (scene == 13) { }
                else if (scene == 14) { scene = 15; }
                else if (scene == 15) { }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { scene = 6; }
                else if (scene == 19) { }
                else if (scene == 20) { scene = 21; }
                else if (scene == 21) { scene = 22; }
                else if (scene == 22) { scene = 6; }
                else if (scene == 23) { }
                else if (scene == 24) { scene = 25; }
                else if (scene == 25) { }
                else if (scene == 26) { scene = 6; }
                else if (scene == 27) { }
                else if (scene == 28) { scene = 30; }
                else if (scene == 29) { }
                else if (scene == 30) { scene = 31; }
                else if (scene == 31) { scene = 40; }
                else if (scene == 32) { scene = 33; }
                else if (scene == 33) { scene = 35; }
                else if (scene == 34) { scene = 33; }
                else if (scene == 35) 
                {
                    Random ranGen = new Random();
                    int value = ranGen.Next(1, 11);

                    if (value <= 5) { scene = 37; }
                    else { scene = 38; }
                }
                else if (scene == 36) { }
                else if (scene == 37) { }
                else if (scene == 38) { }
                else if (scene == 39) { }
                else if (scene == 40) { }
                else if (scene == 41) { this.Close(); }
            }
            else if (e.KeyCode == Keys.N)
            {
                if (scene == 0) { }
                else if (scene == 1) { }
                else if (scene == 2) { }
                else if (scene == 3) { scene = 18; }
                else if (scene == 4) { }
                else if (scene == 5) { }
                else if (scene == 6) { scene = 8; }
                else if (scene == 7) { }
                else if (scene == 8) { scene = 13; }
                else if (scene == 9) { }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { }
                else if (scene == 13) { }
                else if (scene == 14) { scene = 8; }
                else if (scene == 15) { }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { }
                else if (scene == 19) { }
                else if (scene == 20) { scene = 24; }
                else if (scene == 21) { }
                else if (scene == 22) { }
                else if (scene == 23) { }
                else if (scene == 24) { }
                else if (scene == 25) { }
                else if (scene == 26) { }
                else if (scene == 27) { }
                else if (scene == 28) { }
                else if (scene == 29) { }
                else if (scene == 30) { }
                else if (scene == 31) { }
                else if (scene == 32) { }
                else if (scene == 33) { }
                else if (scene == 34) { }
                else if (scene == 35) { }
                else if (scene == 36) { }
                else if (scene == 37) { }
                else if (scene == 38) { }
                else if (scene == 39) { }
                else if (scene == 40) { }
                else if (scene == 41) { }
            }

            switch (scene)
            {
                case 0:
                    textLabel.Text = "Welcome to your life. You get to choose how to live it, but remember your choices will have consequences.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    break;
                case 1:
                    textLabel.Text = "You wake up to the sound of your alarm. You roll over and check the time, it's 7:30 in the morning.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Get up";
                    choiceBLabel.Text = "Stay in bed";
                    choiceCLabel.Text = "";
                    SoundPlayer alarm = new SoundPlayer(Properties.Resources.Alarm);
                    alarm.Play();
                    this.BackgroundImage = Properties.Resources.download;
                    Refresh();
                    break;
                case 2:
                    textLabel.Text = "You get out of bed. The sun is shining through the windows and it looks like it's going to be a hot day.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Get dressed";
                    choiceBLabel.Text = "Go outside";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.images;
                    Refresh();
                    break;
                case 3:
                    textLabel.Text = "You get dressed in whatever clothes you can find in your closet, then head downstairs.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Eat breakfast";
                    choiceBLabel.Text = "Go outside";
                    choiceCLabel.Text = "Watch tv";
                    SoundPlayer zipper = new SoundPlayer(Properties.Resources.Zipper);
                    zipper.Play();
                    this.BackgroundImage = Properties.Resources.Downstairs;
                    Refresh();
                    break;
                case 4:
                    textLabel.Text = "You go back to sleep, when you awake you realize it's 1 in the afternoon";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Get up";
                    choiceBLabel.Text = "Stay in bed";
                    choiceCLabel.Text = "";
                    this.BackgroundImage = Properties.Resources.download;
                    silence.Play();
                    Refresh();
                    break;
                case 5:
                    textLabel.Text = "You decide to waste your life away in bed.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer sad = new SoundPlayer(Properties.Resources.Sad);
                    sad.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 6:
                    textLabel.Text = "You head outside, what do you want to do?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Get a job";
                    choiceBLabel.Text = "Visit a friend";
                    choiceCLabel.Text = "Go to the store";
                    door.Play();
                    this.BackgroundImage = Properties.Resources.Outside;
                    Refresh();
                    break;
                case 7:
                    textLabel.Text = "You go hand in a resume at a local business, they bring you to the managers office where they conduct the interview. At the end of the interview they ask, Do you really want this job?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Yes";
                    choiceBLabel.Text = "No";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.Interview;
                    Refresh();
                    break;
                case 8:
                    textLabel.Text = "You head to the store, what will you buy?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Pasta 15$";
                    choiceBLabel.Text = "Chicken 28$";
                    choiceCLabel.Text = "Chips $5";
                    SoundPlayer store = new SoundPlayer(Properties.Resources.Store);
                    store.Play();
                    this.BackgroundImage = Properties.Resources.Store1;
                    Refresh();
                    break;
                case 9:
                    textLabel.Text = "You go to your best friends house. Once there you knock on the door. They answer the door and smile once they see you. Hey! Come on in! they say.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Go inside";
                    choiceBLabel.Text = "Leave";
                    choiceCLabel.Text = "";
                    SoundPlayer knock = new SoundPlayer(Properties.Resources.Knock);
                    knock.Play();
                    this.BackgroundImage = Properties.Resources.Door1;
                    Refresh();
                    break;
                case 10:
                    textLabel.Text = "You head inside and spend the rest of the day hanging out with your friend. At the end of the day you say your farewells and you retire back home.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer hurray = new SoundPlayer(Properties.Resources.Hurray);
                    hurray.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 11:
                    textLabel.Text = "You run away quickly from your friend and head home. You lay in bed that night thinking about how lonely you are and cry yourself to sleep.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer running = new SoundPlayer(Properties.Resources.Running);
                    running.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 12:
                    textLabel.Text = "You get to the checkout, but it turns out you don't have enough money. They lady at the checkout calls the police.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Run away";
                    choiceBLabel.Text = "Stand still";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.Checkout;
                    Refresh();
                    break;
                case 13:
                    textLabel.Text = "You get to the checkout and pay with what little money you have. You head home and eat your chips, repressing the fact that you are in financial debt and may become homeless soon.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";                  
                    cash.Play();
                    this.BackgroundImage = Properties.Resources.Checkout;
                    Refresh();
                    break;
                case 14:
                    textLabel.Text = "They are confused and quite frustrated that you have wasted their time. They kick you out. What will you do now?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Go home";
                    choiceBLabel.Text = "Visit a friend";
                    choiceCLabel.Text = "Go to the store";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.Street;
                    Refresh();
                    break;
                case 15:
                    textLabel.Text = "You head home and decide to call it a day. Once you hit the bed you go to sleep instantly.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer snore = new SoundPlayer(Properties.Resources.Snoring);
                    snore.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 16:
                    textLabel.Text = "They decide you aren't a good fit for their company. After having your ego destroyed you go home and cry yourself to sleep.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer cry = new SoundPlayer(Properties.Resources.Cry);
                    cry.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 17:
                    textLabel.Text = "You got the job! After working with the company for some time they decide you are a good fit for CEO. You become the richest and most successful person on earth.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";                   
                    cash.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 18:
                    textLabel.Text = "You watch some TV, an hour or so passes and you start to get a bad headache.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Keep watching tv";
                    choiceBLabel.Text = "Go outside";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.TV;
                    Refresh();
                    break;
                case 19:
                    textLabel.Text = "You continue to watch TV. After some time your headache becomes worse, you collapse to the floor and your vision begins to fade to darkness.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer thud = new SoundPlayer(Properties.Resources.Thud);
                    thud.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 20:
                    textLabel.Text = "You decide to make some breakfast, what do you want to eat?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Bacon and eggs";
                    choiceBLabel.Text = "Toast with peanut butter";
                    choiceCLabel.Text = "Cereal";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.Kitchen;
                    Refresh();
                    break;
                case 21:
                    textLabel.Text = "You put the bread in the toaster and prepare the peanut butter. Once the toast is done you spread the peanut butter on the toast and take a bite out of it. Your eyes widen and your taste buds erupt with flavor. This is the best peanut butter toast you've ever eaten. You think that you must share this incredible invention with the world.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Tell the world";
                    choiceBLabel.Text = "Keep it a secret";
                    choiceCLabel.Text = "";
                    SoundPlayer toaster = new SoundPlayer(Properties.Resources.Toaster);
                    toaster.Play();
                    Refresh();
                    this.BackgroundImage = Properties.Resources.Toaster1;
                    break;
                case 22:
                    textLabel.Text = "You decide to keep it a secret, you scarf down the rest of the toast and are now prepared for the day.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Watch tv";
                    choiceBLabel.Text = "Go outside";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.Downstairs;
                    Refresh();
                    break;
                case 23:
                    textLabel.Text = "You run outside and start giving people samples of the toast. Soon people in town are wanting more and say they are willing to pay large sums of money to get it. You decide to open your own shop and sell these marvels. You make millions and are soon know as the peanut butter toast master.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";                   
                    cash.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 24:
                    textLabel.Text = "You decide to have cereal, the only kind you have is corn flakes. What do you pour first?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Cereal";
                    choiceBLabel.Text = "Milk";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.CornFlakes;
                    Refresh();
                    break;
                case 25:
                    textLabel.Text = "You pour the milk first. You take one bite of the cereal and choke and die. That's what you get for pouring milk first.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer choking = new SoundPlayer(Properties.Resources.Choking);
                    choking.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 26:
                    textLabel.Text = "You pour the cereal in first and enjoy a nice bowl of corn flakes. What will you do next?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Watch tv";
                    choiceBLabel.Text = "Go outside";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.Corn;
                    Refresh();
                    break;
                case 27:
                    textLabel.Text = "You make bacon and eggs, but due to your inability to cook you burn your house down with you inside.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer fire = new SoundPlayer(Properties.Resources.Fire);
                    fire.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 28:
                    textLabel.Text = "You make bacon and eggs, but due to your inability to cook they look a little undercooked.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Eat them";
                    choiceBLabel.Text = "Throw them out";
                    choiceCLabel.Text = "";
                    this.BackgroundImage = Properties.Resources.BaconandEggs;
                    silence.Play();
                    Refresh();
                    break;
                case 29:
                    textLabel.Text = "You eat the bacon and eggs and die of food poisoning.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer vomit = new SoundPlayer(Properties.Resources.Vomit);
                    vomit.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 30:
                    textLabel.Text = "You throw out the bacon and eggs. You look around for something to eat, but realize you didn't get groceries.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Go to the grocery store";
                    choiceBLabel.Text = "Forget about it";
                    choiceCLabel.Text = "";
                    this.BackgroundImage = Properties.Resources.Trash;
                    silence.Play();
                    Refresh();
                    break;
                case 31:
                    textLabel.Text = "You forget about it for the time being.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Go outside";
                    choiceBLabel.Text = "Watch tv";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.Downstairs;
                    Refresh();
                    break;
                case 32:
                    textLabel.Text = "You head outside in just your underwear. There is a cop nearby who spots you. He turns on his siren and starts driving towards you.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Run away";
                    choiceBLabel.Text = "Stand still";
                    choiceCLabel.Text = "";
                    door.Play();
                    this.BackgroundImage = Properties.Resources.Outside;
                    Refresh();
                    break;
                case 33:
                    textLabel.Text = "The cop drives up to you and questions you.";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Tell the truth";
                    choiceBLabel.Text = "Lie";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = Properties.Resources.Outside;
                    Refresh();
                    break;
                case 34:
                    textLabel.Text = "You run away, but since the cop is in a car he catches up quickly. The cop yells Stop!";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Keep running";
                    choiceBLabel.Text = "Stop";
                    choiceCLabel.Text = "";
                    SoundPlayer run = new SoundPlayer(Properties.Resources.Running);
                    run.Play();
                    this.BackgroundImage = Properties.Resources.Police1;
                    Refresh();
                    break;
                case 35:
                    textLabel.Text = "The cop puts handcuffs on you and puts you in the back of the car. You are later taken to court, how do you plead?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Guilty";
                    choiceBLabel.Text = "Not guilty";
                    choiceCLabel.Text = "";
                    SoundPlayer police = new SoundPlayer(Properties.Resources.Police);
                    police.Play();
                    this.BackgroundImage = Properties.Resources.PoliceCar;
                    Refresh();
                    break;
                case 36:
                    textLabel.Text = "The cops shoots you with a taser and puts you in handcuffs. He throws you in the back of his car and you are taken to prison for running away from a cop.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer taze = new SoundPlayer(Properties.Resources.Taze);
                    taze.Play();
                    this.BackgroundImage = Properties.Resources.PoliceCar;
                    Refresh();
                    break;
                case 37:
                    textLabel.Text = "You are found not guilty and are let go. You head home and are thankful you are not spending the night in prison.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer gavel = new SoundPlayer(Properties.Resources.Gavel);
                    gavel.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 38:
                    textLabel.Text = "You are found guilty and are sentenced to prison for life.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    SoundPlayer jail = new SoundPlayer(Properties.Resources.Jail);
                    jail.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 39:
                    textLabel.Text = "You go outside, part way through the day you feel a sharp pain in your stomach. You collapse to the floor and your vision begins to go dark. You have starved to death.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    death.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 40:
                    textLabel.Text = "You turn on your favorite show, but part way through you feel a sharp pain in your stomach. You collapse to the floor and everything goes dark. You have starved to death.";
                    gameOverLabel.Text = "Game Over.";
                    choiceALabel.Text = "Continue";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    death.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;
                case 41:
                    textLabel.Text = "Would you like to try again?";
                    gameOverLabel.Text = "";
                    choiceALabel.Text = "Yes";
                    choiceBLabel.Text = "No";
                    choiceCLabel.Text = "";
                    silence.Play();
                    this.BackgroundImage = null;
                    Refresh();
                    break;



            }
        }

        

    }
      
}
