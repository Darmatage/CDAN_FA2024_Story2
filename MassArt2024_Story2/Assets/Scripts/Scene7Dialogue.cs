using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7Dialogue : MonoBehaviour
{
    // These are the script variables.
    // For more character images or buttons, duplicate the ArtChar ones listed here and renumber.
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;
    public GameObject ArtChar1b;
    public GameObject ArtChar1c;
    public GameObject ArtChar1d;
    public GameObject ArtChar1e;
    //this is for the second character in scene
    public GameObject ArtChar2a;
    public GameObject ArtChar2b;
    public GameObject ArtChar2c;
    public GameObject ArtChar2d;
    public GameObject ArtChar2e;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    public GameObject ExamineButton;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Initial visibility settings. Any new images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtChar2d.SetActive(false);
        ArtChar2e.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        ExamineButton.SetActive(false);
    }

    // Use the spacebar as a faster "Next" button:
    void Update()
    {
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Next();
            }
            // secret debug code: go back 1 Story Unit, if NEXT is visible
            if (Input.GetKeyDown("p"))
            {
                primeInt -= 2;
                Next();
            }
        }
    }


    public void Next()
    {
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {

        }
        else if (primeInt == 2)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Heyyyyyy! Anyone homeeee?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "*Slime noises";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {

            
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Huh? Who's there?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "*Introductory slime noise*";
        }
        else if (primeInt == 6)
        {


            Char1name.text = "R.O.B.I";
            Char1speech.text = "Oh... you're a slime. Neat!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {


            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "*Questionable slime noise*";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Uh...hold on I think I have a slime translator in my system.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Can you understand me now, good sir?";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "R.O.B.I";
            Char1speech.text = "Yeah! It seems to be working.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Jolly good! What a convenient program. ";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "My knowledge core has reference to slimes. I've never gotten the chance to talk to a slime one-to-one!";
            Char2name.text = "";
            Char2speech.text = "";
        }



        else if (primeInt == 13)
        {
            Char1name.text = "R.O.B.I";
            Char1speech.text = "I've always wanted to ask...";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }

        //if player chose choice1a:
        else if (primeInt == 20)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Ah. We're simply a mixture of Polyvynle alcohol, some glue, and a substance high in borate ions.";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "And of course the secret ingredients for life: Love! ...and Uranium.";
        }
        else if (primeInt == 22)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "...fascinating.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 39;
        }

        //if player chose choice1b:
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Why, allow me to demonstrate.";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "I just squish my body aaaallll the way down...";

        }
		else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "...and give my biggest bounce!";

        }
		else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "WEEE!";

        }
		else if (primeInt == 34)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Did you see! Almost three feet high!";

        }
        else if (primeInt == 35)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "To be honest, I kinda expected higher.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 36)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Forgive me, I have not exercised in quite a while.";
            primeInt = 39;
        }



        //after both choices 1a and 1b:
        else if (primeInt == 40)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "So, about that question I blubbed earlier. \nIt's about this card stuck inside me.";
        }
        else if (primeInt == 41)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Would you kindly reach in and pull it out? \nIt's getting quite uncomfortable.";
        }
		else if (primeInt == 42)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "But do be quick, I tend to be a tad... clingy.";
        }
        else if (primeInt == 43)
        {

            Char1name.text = "R.O.B.I.";
            Char1speech.text = "That might be something I need! Alright hold on.";
            Char2name.text = "";
            Char2speech.text = " ";
        }
        else if (primeInt == 44)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "How should I approach this?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }


        // after choice 2a
        else if (primeInt == 50)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "The card is out! \nWoah-- it slipped out of my hand... \n...and landed on that lecturn.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 51)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Oh my! That was quite efficient!";
        }

        else if (primeInt == 52)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Whoops! I'll get it!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 53)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "You do that. And feel free to look around while you're at it.";

        }
        else if (primeInt == 54)
        {
            ArtChar1a.SetActive(false);
            ArtChar2a.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(false);
            ExamineButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 55)
        {
            ArtChar1a.SetActive(true);
            ArtChar2a.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            ExamineButton.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Did you retrieve what you needed?";
        }
        else if (primeInt == 56)
        {

            Char1name.text = "R.O.B.I.";
            Char1speech.text = "I believe so.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 57)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Then carry on, my friend.";
        }
        else if (primeInt == 58)
        {
            ArtChar1a.SetActive(false);
            ArtChar2a.SetActive(false);
            
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            NextScene1Button.SetActive(true);
        }

        // after choice 2b
        else if (primeInt == 60)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "My, that tickles. But make haste!";
        }
        else if (primeInt == 61)
        {
            
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Huh? My arm's stuck!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 62)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Slime";
            Char2speech.text = "Oh bother, I'm afraid we'll be together for quite a while my friend...";

            
        }
        else if (primeInt == 63)
        {
            ArtChar1a.SetActive(false);
            ArtChar2a.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }



        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

    public void Choice1aFunct()
    {
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "What are you guys made of?!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 19;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "How high can you jump?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }



    //choice 2a and 2b functions:
    public void Choice2aFunct()
    {
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "Real quick, like a cat! Yah!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 49;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "Let's reach in slow ...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 59;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("SceneLose");
    }
}
