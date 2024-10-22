using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour
{
    // These are the script variables.
    // For more character images or buttons, duplicate the ArtChar ones listed here and renumber.
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;
    public GameObject ArtChar1b;
    public GameObject ArtChar1c;
    public GameObject ArtChar1d;
    public GameObject ArtChar1e;
    public GameObject ArtChar2a;
    public GameObject ArtChar2b;
    //public GameObject ArtChar2c;
    //public GameObject ArtChar2d;
    //public GameObject ArtChar2e;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
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
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
            if (Input.GetKeyDown("p"))
            {
                primeInt -= 2;
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
            Char2speech.text = "Stop there.";
        }
        else if (primeInt == 3)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "...Huh?";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "To gain entry, you must answer this Would You Rather question correctly.";

        }
        else if (primeInt == 5)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "How do you even answer correctly? Isn't it subjective?";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 6)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "I shall decide on my own, through logical deductive reasoning, which option is the most optimal for survival and general satisfaction.";
        }






        else if (primeInt == 7)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Deductive reasoning...?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
        else if (primeInt == 30)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "It seems sketch, but it doesn't look like I have a choice.";
            Char2name.text = "";
            Char2speech.text = "";
            
        }
        else if (primeInt == 31)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "You do not.";
            primeInt = 39 ;
        }


        // after choice 1b

        else if (primeInt == 35)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Life is often not fair.";
            primeInt = 39 ;
        }




        else if (primeInt == 40)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Your question is as follows:";
        }
        else if (primeInt == 41)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Would You Rather fight ten horse-sized chickens...or one-hundred chicken sized horses?";

        }
        else if (primeInt == 42)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "I'd have to say...";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice1aFunct()
            Choice2b.SetActive(true); // function Choice1bFunct()
        }
        //after answer 2a
        else if (primeInt == 60)
        {
            Choice2a.SetActive(false); 
            Choice2b.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Chickens are managable...an acceptable answer";

        }
        else if (primeInt == 61)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Chickens never fail me!";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 62)
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
        //after answer 2b

        else if (primeInt == 50)
        {
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            ArtChar1a.SetActive(true);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Horses are scary, no matter the size. I cannot accept that answer";
        }
        else if (primeInt == 51)
        {
            
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Man...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 52)
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
            NextScene2Button.SetActive(true);
        }


        








        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "Uh alright. Ask away.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "R.O.B.I.";
        Char1speech.text = "That doesn’t seem fair at all!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 34;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "The Horse-Sized Chickens!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 59;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "The Chicken-Sized Horses!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 49;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene6");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2");
    }
}
