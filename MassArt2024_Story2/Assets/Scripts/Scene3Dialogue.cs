using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour
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
            ArtChar2a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Where do you think you're going?";
        }
        else if (primeInt == 3)
        {
            ArtChar1a.SetActive(true); //*Allows second charcter to appear! Copy and paste where needed
            Char1name.text = "ROBI";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "I'd suggest answering.";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "ROBI";
            Char1speech.text = "I don't know!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "I see... it may be an issue of your lack of decision making.";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "Allow me to perform further testing...";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "You stand at a railway track, with many biologicals tied to each track.";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "The current path carries only one trapped biological...";
        }
		else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "...while the one you can switch to, using the provided track flipping mechanism, has five child biologicals.";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "The trolly is making its way. Do you willingly switch the tracK?";
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }

        // after choice 1a and choice 1b
        else if (primeInt == 20)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "AI";
            Char2speech.text = "Either way, you could never have won. It was unfair of me to offer this riddle. But I appreciate the honesty";
        }
        else if (primeInt == 21)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "ROBI";
            Char1speech.text = "I don't really like that puzzle...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 22)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "I understand. Either way. Your opinion doesn't completely matter for this.";
        }
        else if (primeInt == 23)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "There is only a 0.0004733% chance you would ever fall into the situation this choice would present.";
        }
        else if (primeInt == 24)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "ROBI";
            Char1speech.text = "Right... I'll take that my purpose doesn't revolve around a Trolly?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 25)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "Precisely";
        }
        else if (primeInt == 26)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "ROBI";
            Char1speech.text = "Sooo, does this mean I can go on ahead?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 27)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "A.I";
            Char2speech.text = "Please do. Time is of the essence after all.";
        }
        else if (primeInt == 28)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            DialogueDisplay.SetActive(false);
            NextScene1Button.SetActive(true);
            nextButton.SetActive(false);
        }

        
        

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "A.I";
        Char2speech.text = "I understand... with your current programming you currently prioritize human life.";
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
        Char2name.text = "A.I";
        Char2speech.text = "I see... you are quite reckless with human life. I approve.";
        primeInt = 19;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene7");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene4");
    }
    public void SceneChange3()
    {
        SceneManager.LoadScene("Scene5");
    }
}
