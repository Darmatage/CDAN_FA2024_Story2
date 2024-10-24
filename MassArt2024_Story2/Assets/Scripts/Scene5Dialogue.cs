using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Dialogue : MonoBehaviour
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
    //public GameObject ArtChar1b;
    //public GameObject ArtChar2;
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
        //Char 1
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);
        //Char 2
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
            ArtChar1c.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "ROBI";
            Char1speech.text = "Great the door's locked.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar2b.SetActive(true); //*Allows second charcter to appear! Copy and paste where needed
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "In order to pass into the next room, you must solve this riddle.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(true);
            Char1name.text = "ROBI";
            Char1speech.text = "Are you serious?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "Quite. I worked hard to perfect it.";
        }
        else if (primeInt == 6)
        {
            ArtChar1d.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "ROBI";
            Char1speech.text = "Somehow I don't believe you.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "If you can't do it I suppose there's no helping it.";
        }
        else if (primeInt == 8)
        {
            ArtChar1a.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "ROBI";
            Char1speech.text = "Hey! Who said I can't do it!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "It's quite alright. We all have things we're not good at.";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Wha- me! Not good!?";
            Char2name.text = "";
            Char2speech.text = "";
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
            allowSpace = false;
            nextButton.SetActive(false);
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "With pleasure.";
        }

        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "What has a neck, but no head?";
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
            Char2speech.text = "You are incorrect. The room has now been flagged and will not open.";
        }
        else if (primeInt == 21)
        {
            ArtChar2b.SetActive(false);
            ArtChar2c.SetActive(true);
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Nice one.";
        }
        else if (primeInt == 22)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            SceneManager.LoadScene("Scene2");
        }

        // after choice 1b
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "That is correct. your smarter than you look, little ROBI";
        }
        else if (primeInt == 31)
        {
            ArtChar1c.SetActive(false);
            ArtChar1b.SetActive(true);

            Char1name.text = "R.O.B.I.";
            Char1speech.text = "Heh... thanks.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 32)
        {
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);

            Char1name.text = "ROBI";
            Char1speech.text = "Hey wait! What's that supposed to mean!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "You may now proceed.";
        }
        else if (primeInt == 34)
        {
            NextScene2Button.SetActive(true);
            DialogueDisplay.SetActive(false);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "ROBI";
        Char1speech.text = "Ummm I don't know a Dullahan?";
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
        Char1name.text = "ROBI";
        Char1speech.text = "Hmmm... oh a bottle right?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2aFunct()
    {
        Char1name.text = "ROBI";
        Char1speech.text = "You're ON! Ask your stupid question!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 11;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "ROBI";
        Char1speech.text = "Go ahead and try me! I can answer it no problem!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 11;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
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
        SceneManager.LoadScene("Scene8");
    }
}
