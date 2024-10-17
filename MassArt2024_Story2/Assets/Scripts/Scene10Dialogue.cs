using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene10Dialogue : MonoBehaviour
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
    public GameObject NextScene3Button;
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
        NextScene3Button.SetActive(false);
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
            Char1name.text = "ROBI";
            Char1speech.text = "Yikes! This room is pretty creepy";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar2a.SetActive(true); //*Allows second charcter to appear! Copy and paste where needed
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "Your criticism is duly noted.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "ROBI";
            Char1speech.text = "ACK!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "You've done well to make it this far in one piece. This lab has certainly seen better days, with far fewer creatures roaming around.";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "ROBI";
            Char1speech.text = "Don't sneak up on me like that! You almost fried my circuits!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "Noted. We have more pressing matters to discuss however.";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "Have you acquired all 3 of the override pieces?";
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
            Char2name.text = "A.I";
            Char2speech.text = "Welp, that suc-";

        }
        else if (primeInt == 21)
        {
            SceneManager.LoadScene("SceneLose");
        }


        // after choice 1b
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "Well done. Now all that's left is for you to do is to use all 3 on that master computer there.";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "And whatever you do, don't touch that red button. As tempting as it may be.";
            // Turn off the "Next" button, turn on "Scene" button/s
            ///nextButton.SetActive(false);
            ///allowSpace = false;
            ///NextScene1Button.SetActive(true);
        }
        else if (primeInt == 32)
        {
            Char1name.text = "ROBI";
            Char1speech.text = "Sure, master computer and no red button, got it!(now I really wanna press it)";
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar1a.SetActive(false);
            ArtChar2a.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(false);
            NextScene2Button.SetActive(true);
            NextScene3Button.SetActive(true);

        }

        ///After red button press
        else if (primeInt == 41)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "I see. Shi-";
        }
        else if (primeInt == 42)
        {
            SceneManager.LoadScene("SceneLose");

        }
        ///After going to super computer
        else if (primeInt == 51)
        {
            ArtChar1a.SetActive(true);
            Char1name.text = "ROBI";
            Char1speech.text = "Alright now let's see what we got. We plug in the USB, swipe this Keycard, and lastly input the password!";
            Char2name.text = "";
            Char2speech.text = "";
          }
          else if (primeInt == 52)
          {
              ArtChar2a.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "A.I";
              Char2speech.text = "Good work little ROBI. I can now bring the solar generators back online.";
          }
          else if (primeInt == 53)
          {
              ArtChar2a.SetActive(true);
              Char1name.text = "ROBI";
              Char1speech.text = "So can I finally know my purpose? Why I was made?";
              Char2name.text = "";
              Char2speech.text = "";
          }
          else if (primeInt == 54)
          {
              ArtChar2a.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "A.I";
              Char2speech.text = "I suppose so. After All, you’ve already completed your designated purpose.";
          }
        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "ROBI";
        Char1speech.text = "Ummmm about that...";
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
        Char1speech.text = "Yeah I have them stored in my hidden compartment!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Button2aFunct()
    {
        ArtChar1a.SetActive(true);
        Char1name.text = "ROBI";
        Char1speech.text = "I GOTTA PRESS THAT BUTTON";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 40;
        DialogueDisplay.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Computer2bFunct()
    {
        ArtChar1a.SetActive(true);
        Char1name.text = "ROBI";
        Char1speech.text = "Better listen to what he says. I'll go to the computer!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 50;
        DialogueDisplay.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("SceneWin");
    }
    public void SceneChange3()
    {
        SceneManager.LoadScene("SceneLose");
    }
}
