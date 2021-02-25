using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_game
{
    public partial class Form1 : Form
    {
        int scene = 1;
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (scene == 1) (scene == 2)
                else if (scene == 2) (scene == 3)
                else if (scene == 3)
            }
            else if (e.KeyCode == Keys.S)
            {

            }
            else if (e.KeyCode == Keys.D)
            {

            }

            switch (scene)
            {
                case 1:
                    textLabel.Text = "You wake up to the sound of your alarm, you roll over and check the time, it's 7:30 in the morning.";
                    choiceALabel.Text = "Get up";
                    choiceBLabel.Text = "Stay in bed";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 2:
                    textLabel.Text = "You get out of bed.";
                    choiceALabel.Text = "Get dressed";
                    choiceBLabel.Text = "Go outside";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 3:
                    textLabel.Text = "You get dressed.";
                    choiceALabel.Text = "Eat breakfast";
                    choiceBLabel.Text = "Watch tv";
                    choiceCLabel.Text = "Go outside";
                    Refresh();
                    break;
                case 4:
                    textLabel.Text = "You go back to sleep, when you awake you realize it's 1 in the afternoon";
                    choiceALabel.Text = "Get up";
                    choiceBLabel.Text = "Stay in bed";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 5:
                    textLabel.Text = "You decide to waste your life away in bed. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 6:
                    textLabel.Text = "You head outside, what do you want to do?";
                    choiceALabel.Text = "Get a job";
                    choiceBLabel.Text = "Go to the store";
                    choiceCLabel.Text = "Visit a friend";
                    Refresh();
                    break;
                case 7:
                    textLabel.Text = "You go hand in a resume at a local business, they bring you to the managers office where they conduct the interview. At the end of the interview they ask, Do you really want this job?";
                    choiceALabel.Text = "Yes";
                    choiceBLabel.Text = "No";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 8:
                    textLabel.Text = "You head to the store, what will you buy?";
                    choiceALabel.Text = "Pasta 15$";
                    choiceBLabel.Text = "Chicken 28$";
                    choiceCLabel.Text = "Chips $5";
                    Refresh();
                    break;
                case 9:
                    textLabel.Text = "You go to your best friends house. Once there you knock on the door. They answer the door and smile once they see you. Hey! Come on in! they say.";
                    choiceALabel.Text = "Go inside";
                    choiceBLabel.Text = "Leave";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 10:
                    textLabel.Text = "You head inside and spend the rest of the day hanging out with your friend. At the end of the day you say your farewells and you retire back home. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 11:
                    textLabel.Text = "You run away quickly from your friend and head home. You lay in bed that night thinking about how lonely you are and cry yourself to sleep. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 12:
                    textLabel.Text = "You get to the checkout, but it turns out you don't have enough money. They lady at the checkout calls the police.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 13:
                    textLabel.Text = "You get to the checkout and pay with what little money you have. You head home and eat your chips, repressing the fact that you are in financial debt and may become homeless soon. Game over..";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 14:
                    textLabel.Text = "They are confused and quite frustrated that you have wasted their time. They kick you out. What will you do now?";
                    choiceALabel.Text = "Go home";
                    choiceBLabel.Text = "Go to the store";
                    choiceCLabel.Text = "Visit a friend";
                    Refresh();
                    break;
                case 15:
                    textLabel.Text = "You head home and decide to call it a day. Once you hit the bed you go to sleep instantly. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 16:
                    textLabel.Text = "They decide you aren't a good fit for their company. After having your ego destroyed you go home and cry yourself to sleep. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 17:
                    textLabel.Text = "You got the job! After working with the company for some time they decide you are a good fit for CEO. You become the richest and most successful person on earth. Game over..";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 18:
                    textLabel.Text = "You watch some tv, an hour or so passes and you start to get a bad headache.";
                    choiceALabel.Text = "Keep watching tv";
                    choiceBLabel.Text = "Go outside";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 19:
                    textLabel.Text = "You continue to watch tv. After some time your headache becomes worse, you collapse to the floor and your vision begins fade to darkness. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 20:
                    textLabel.Text = "What do you want to eat for breakfast?";
                    choiceALabel.Text = "Bacon and eggs";
                    choiceBLabel.Text = "Cereal";
                    choiceCLabel.Text = "Toast with peanut butter";
                    Refresh();
                    break;
                case 21:
                    textLabel.Text = "You put the bread in the toaster and prepare the peanut butter. Once the toast is done you spread the peanut butter on the toast and take a bite out of it. Your eyes widen and your taste buds erupt with flavor. This is the best peanut butter toast you've ever eaten. You think that you must share this incredible invention with the world.";
                    choiceALabel.Text = "Tell the world";
                    choiceBLabel.Text = "Keep it a secret";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 22:
                    textLabel.Text = "You decide to keep it a secret, you scarf down the rest of the toast and are now prepared for the day.";
                    choiceALabel.Text = "Go outside";
                    choiceBLabel.Text = "Watch tv";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 23:
                    textLabel.Text = "You run outside and start giving people samples of the toast. Soon people in town are wanting more and say they are willing to pay large sums of money to get it. You decide to open your own shop and sell these marvels. You make millions and are soon know as the peanut butter toast master. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 24:
                    textLabel.Text = "You decide to have cereal, the only kind you have is corn flakes. What do you pour first?";
                    choiceALabel.Text = "Cereal";
                    choiceBLabel.Text = "Milk";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 25:
                    textLabel.Text = "You pour the milk first. You take one bite of the cereal and choke and die. That's what you get for pouring milk first.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 26:
                    textLabel.Text = "You pour the cereal in first and enjoy a nice bowl of corn flakes. What will you do next?";
                    choiceALabel.Text = "Watch tv";
                    choiceBLabel.Text = "Go outside";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 27:
                    textLabel.Text = "You make bacon and eggs, but due to your inability to cook you burn your house down with you inside. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 28:
                    textLabel.Text = "You make bacon and eggs, but due to your inability to cook they look a little undercooked.";
                    choiceALabel.Text = "Eat them";
                    choiceBLabel.Text = "Throw them out";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 29:
                    textLabel.Text = "You eat the bacon and eggs and die of food poisoning. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 30:
                    textLabel.Text = "You throw out the bacon and eggs. You look around for something to eat, but realize you didn't get groceries.";
                    choiceALabel.Text = "Go to the grocery store";
                    choiceBLabel.Text = "Forget about it";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 31:
                    textLabel.Text = "You forget about it for the time being.";
                    choiceALabel.Text = "Go outside";
                    choiceBLabel.Text = "Watch tv";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 32:
                    textLabel.Text = "You head outside in just your underwear. There is a cop nearby who spots you. He turns on his siren and starts driving towards you.";
                    choiceALabel.Text = "Run away";
                    choiceBLabel.Text = "Stand still";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 33:
                    textLabel.Text = "The cop drives up to you and questions you.";
                    choiceALabel.Text = "Tell the truth";
                    choiceBLabel.Text = "Lie";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 34:
                    textLabel.Text = "You run away, but since the cop is in a car he catches up quickly. The cop yells Stop!";
                    choiceALabel.Text = "Keep running";
                    choiceBLabel.Text = "Stop";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 35:
                    textLabel.Text = "The cop puts handcuffs on you and puts you in the back of the car. You are later taken to court, how do you plead?";
                    choiceALabel.Text = "Guilty";
                    choiceBLabel.Text = "Not guilty";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 36:
                    textLabel.Text = "The cops tazzes you and puts you in handcuffs. He throws you in the back of his car and you are taken to prison for running away from a cop. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 37:
                    textLabel.Text = "You are found not guilty and are let go. You head home and are thankful you are not spending the night in prison. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 38:
                    textLabel.Text = "You are found guilty and are sentenced to prison for life. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 39:
                    textLabel.Text = "You go outside, part way through the day you feel a sharp pain in your stomach. You collapse to the floor and your vision begins to go dark. You have starved to death. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;
                case 40:
                    textLabel.Text = "You turn on your favorite show, but part way through you feel a sharp pain in your stomach. You collapse to the floor and everything goes dark. You have starved to death. Game over.";
                    choiceALabel.Text = "";
                    choiceBLabel.Text = "";
                    choiceCLabel.Text = "";
                    Refresh();
                    break;




            }
        }
    }
}
