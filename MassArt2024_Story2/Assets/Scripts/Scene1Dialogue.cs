using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour
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
    //this is for the second character in scene
    public GameObject ArtChar2a;
    //public GameObject ArtChar1b;
    //public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Initial visibility settings. Any new images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
        }
    }

    //Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
    public void Next()
    {
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // audioSource1.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "[ POWER- UP INITIATED ]";
        }
        else if (primeInt == 3)
        {
            ArtChar2a.SetActive(true); //*Allows second charcter to appear! Copy and paste where needed
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "[ BEGINNING START-UP. ] ";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "[ BOOTING. ]";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "[ BOOTING. . ] ";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "[ BOOTING . . . ] ";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "[ SUCCESS ! ]";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "[ WELCOME ONLINE, R.O.B.I. ]";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "( My lens suddenly opened, revealing a messy, dusty, run down laboratory. )";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "( . . .At least, that's what my sensors are telling me. )";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "( My logic unit feels as if its not working up to speed. . .) ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "( Maybe I should charge just a little bit more. . . )";
            Char2name.text = "";
            Char2speech.text = "";
            // Here would be a game over choice with robi either continuing or sleeping. If he sleeps it would lead to a Game over screen, but if he stays awake script would continue as usual. Ask 10/17/24 jason how to make more buttons, either me or someone else if im still sick - SAM
        // Didnt put any choices here for now! will when we figure out. :-D!!!!
    }
    else if (primeInt == 13)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "( I cant be messing around! Its probably just a slow start up. . . better start looking around!)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "";
            Char1speech.text = " ";
            Char2name.text = "AI";
            Char2speech.text = "Welcome awake, R.O.B.I.";
        }
        else if (primeInt == 15)
        {
            Char1name.text = "R.O.B.I";
            Char1speech.text = "Huh?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 16)
        {
            Char1name.text = "";
            Char1speech.text = " ";
            Char2name.text = "AI";
            Char2speech.text = "If you are confused about the term `Welcome awake`, it is a biological term for gaining power.";
        }
        else if (primeInt == 17)
        {
            Char1name.text = "";
            Char1speech.text = " ";
            Char2name.text = "AI";
            Char2speech.text = "Of which, you just got for the first time.";
        }
        else if (primeInt == 18)
        {
            Char1name.text = "";
            Char1speech.text = " ";
            Char2name.text = "AI";
            Char2speech.text = "However, if you are confused about your identification. Your shortened name is R.O.B.I, or Responsive Optimization Behavior Interface";
       
        }
        else if (primeInt == 19)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Is that clear?";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
        else if (primeInt == 20)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Good.";
        }
    
        // after choice 1b
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Ah, you must have gained some damage throughout the time prior to your activation. You will most likely be fine. ";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "So, What exactly am I supposed to do?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "That’s a simple question! What does your programming tell you to do?";
        }
        else if (primeInt == 33)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Oh! It. . .";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 34)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Um. . .";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 35)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Where in my programming say that?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 36)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "You would know. Perhaps you were never programmed with one.";
        }
        else if (primeInt == 37)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "No. . . that cant be the case, all experiments here had one.";
        }
        else if (primeInt == 38)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Oh! But I must cut our conversation short.";
        }
        else if (primeInt == 39)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "The facility is currently running off Emergency power, wouldnt want to drain the rest of our lives";
        }
        else if (primeInt == 40)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Toodles";
        }
        else if (primeInt == 41)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Huh?! What do you mean TOODLES";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 42)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "They never answered my question!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 43)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Oh well, guess ill have to figure it out myself";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 44)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = ". . .and fast too, that power issue worries me";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 45)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "I better be selective about what I search.";
            Char2name.text = "";
            Char2speech.text = "";
            NextScene1Button.SetActive(true);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "AI";
        Char2speech.text = "Excellent. I see you are working as expected.";
        primeInt = 19;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "AI";
        Char2speech.text = "Ah, you must have gained some damage throughout the time prior to your activation. You will most likely be fine. ";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}
