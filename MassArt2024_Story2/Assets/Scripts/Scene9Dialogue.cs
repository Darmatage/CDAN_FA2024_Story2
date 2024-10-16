using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9Dialogue : MonoBehaviour
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
    public GameObject ArtChar2a;
    public GameObject ArtChar2b;
    public GameObject ArtChar2c;
    public GameObject ArtChar2d;
    public GameObject ArtChar2e;

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
            DialogueDisplay.SetActive(true);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "GRRAWW! DANGIT I CAN'T GET IT!";
        }
        else if (primeInt == 3)
        {
            
            Char1name.text = "ROBI";
            Char1speech.text = "AHH! Who�s there?!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "HEY YOU, ROBOT DUDE! HELP A BROTHER OUT! YOU�LL REGRET IT IF YOU DON�T!";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        else if (primeInt == 5)
        {
            Char1name.text = "ROBI";
            Char1speech.text = "Please� just don�t eat me!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "Yeah that�s right. You�ll do nicely. Veeeeery nicely.";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "ROBI";
            Char1speech.text = "(O-Oh no! What is he going to do with me!?)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "SHASHASHA FINALLY I�M GONNA...";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "ROBI";
            Char1speech.text = "...!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "...ask if you could please pick up my sample.";
        }
        
        else if (primeInt == 11)
        {
            ;
            Char1name.text = "ROBI";
            Char1speech.text = "...umm, that's it?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "Yup. That�s it.";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "ROBI";
            Char1speech.text = "You�re not going to experiment on me? Or eat me?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 14)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "Dude, you're a robot, you'd probably taste terrible. Besides, I�m not going around eating people anyways, I�m vegan.";
        }


        else if (primeInt == 15)
        {

            Char1name.text = "ROBI";
            Char1speech.text = "Oh my bad. I didn�t know";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 16)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "No prob Bob, I get that alot.";
        }
        else if (primeInt == 17)
        {

            Char1name.text = "ROBI";
            Char1speech.text = "Anyways, just pick this up, right?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 18)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "Yeah thanks bro. I�ve been in here for hours trying to get it.";
        }
        else if (primeInt == 19)
        {

            Char1name.text = "ROBI";
            Char1speech.text = "Why couldn�t you just get it?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 20)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "I�m a shark. No opposable thumbs, doofus.";
        }
        else if (primeInt == 21)
        {

            Char1name.text = "ROBI";
            Char1speech.text = "I guess not huh. Sorry.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 22)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "Anyways, what brings you here? Do you need something?";
        }
        else if (primeInt == 23)
        {

            Char1name.text = "ROBI";
            Char1speech.text = "I�m actually looking for items to override the lock on this place! The solar powered generator seems to be down and can�t be accessed without the overseer�s items!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 24)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "Oh word? There should be an item like that somewhere in this room, a USB! I�d search for it with you, but again no hands. Feel free to look around.";
            nextButton.SetActive(false);
            allowSpace = false;
        }





        // after choice 1a

        else if (primeInt == 25)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Prof. Fin";
            Char2speech.text = "Alright you asked for it!";
           
        }
        else if (primeInt == 26)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Prof. Fin warned you not to run! He�s unsurprisingly athletic and catches you in an instant. He tears you apart with his jaws and you watch the Lab run out of power.";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        else if (primeInt == 31)
        {
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
        Char1name.text = "ROBI";
        Char1speech.text = "As if I�d trust a shark! I�m outta here!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 24;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "ROBI";
        Char1speech.text = "Alright... just don�t eat me!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 6;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2a");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}