using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour
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
            GetComponent<CharactersBounceTwo>().BounceMe1();
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Hellooooo? Is there anyone in here? Hellooooo?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "Quit yelling! I can hear you loud and clear!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            GetComponent<CharactersBounceTwo>().BounceMe1();
            ArtChar1a.SetActive(false);
            ArtChar1e.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "What!! Who’s speaking?!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "Down here!";
        }
        else if (primeInt == 6)
        {
            ArtChar2a.SetActive(true);
            GetComponent<CharactersBounceTwo>().BounceMe2();
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = "Down here!";
        }
        else if (primeInt == 7)
        {
            GetComponent<CharactersBounceTwo>().BounceMe2();
            ArtChar2a.SetActive(false);
            ArtChar2d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = "I thought your tube was locked, how’d you get out?";
        }
        else if (primeInt == 8)
        {
            GetComponent<CharactersBounceTwo>().BounceMe1();
            ArtChar1e.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "I’m not quite sure. There was a voice telling me to look for the override items so I figured I’d look around.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = "Voice? What voice? I’ve been awake for a while now and I haven’t heard squawk. ";
        }

        else if (primeInt == 10)
        {
            Char1name.text = "R.O.B.I";
            Char1speech.text = "What do I say...?";
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
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Must’ve been my imagination";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 21)
        {
            GetComponent<CharactersBounceTwo>().BounceMe2();
            ArtChar2d.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = " Robots don’t have imaginations, son.";
        }
        else if (primeInt == 22)
        {
            GetComponent<CharactersBounceTwo>().BounceMe1();
            ArtChar1a.SetActive(false);
            ArtChar1e.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Yes, of course. Hah ha. Ha.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 39;
        }

        //if player chose choice1b:
        else if (primeInt == 30)
        {
            GetComponent<CharactersBounceTwo>().BounceMe2();
            ArtChar2d.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = "Whatever you say...";
        }
        else if (primeInt == 31)
        {
            GetComponent<CharactersBounceTwo>().BounceMe1();
            ArtChar1c.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "I've had a weird day. Can I please look around?";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 39;
        }


        //after both choices 1a and 1b:
        else if (primeInt == 40)
        {
            GetComponent<CharactersBounceTwo>().BounceMe1();
            ArtChar1e.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = "Alright, go ahead and take a look around, but don’t mess up any of my work papers! Can’t have you messing up years of calculations.";

    }
    else if (primeInt == 41)
        {
            ArtChar2a.SetActive(false);
            ArtChar2c.SetActive(true);
            GetComponent<CharactersBounceTwo>().BounceMe2();
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = "And also, don't touch that magnet!";
        }
        else if (primeInt == 42)
        {
            GetComponent<CharactersBounceTwo>().BounceMe1();
            ArtChar1a.SetActive(false);
            ArtChar1d.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "You mean this magnet?";
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
            ArtChar2c.SetActive(false);
            ArtChar2e.SetActive(true);
            GetComponent<CharactersBounceTwo>().BounceMe2();
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = "Sorry kid, I warned you. Nothing I can do for you now...";
        }
        else if (primeInt == 51)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "R.O.B.I.’s internal circuitry is damaged beyond repair! The lab loses power and shuts down! ";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        // after choice 2b
        else if (primeInt == 60)
        {
            ExamineButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            ArtChar1a.SetActive(false);
            ArtChar2c.SetActive(false);
            DialogueDisplay.SetActive(false);
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 61)
        {
            nextButton.SetActive(true);
            allowSpace = true;
            
            ExamineButton.SetActive(false);
            ArtChar2c.SetActive(false);
            ArtChar2a.SetActive(true);
            GetComponent<CharactersBounceTwo>().BounceMe2();
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dodo";
            Char2speech.text = "Got what you wanted?";
        }
        else if (primeInt == 62)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Hope so...";
            Char2name.text = "";
            Char2speech.text = "";

            // Turn off the "Next" button, turn on "Scene" button/s
            
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
            NextScene1Button.SetActive(true);
            DialogueDisplay.SetActive(false);
        }



        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

    public void Choice1aFunct()
    {
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "Oh, of course...";
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
        GetComponent<CharactersBounceTwo>().BounceMe1();
        ArtChar1a.SetActive(false);
        ArtChar1c.SetActive(true);
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "I’m certain I heard something!";
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
        GetComponent<CharactersBounceTwo>().BounceMe1();
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(true);
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "Buh! I can’t get it off! Please help! I feel...funny.";
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
        
        GetComponent<CharactersBounceTwo>().BounceMe1();
        ArtChar1d.SetActive(false);
        ArtChar1a.SetActive(true);
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "[I should listen to what Dodo said. Better put this down]";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 59;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = false;



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
