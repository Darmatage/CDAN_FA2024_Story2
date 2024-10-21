using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8Dialogue : MonoBehaviour {
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
        void Start(){
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
        void Update(){
             if (allowSpace == true){
                 if (Input.GetKeyDown("space")){
                      Next();
                 }
             }
        }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "ROBI";
                Char1speech.text = "Helloooooo, anything odd in here?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "ROBI";
                Char1speech.text = "Hmm...not very inviting. This place is bizarre!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "A.I";
                Char2speech.text = "You are doing well.";
        }
       else if (primeInt == 5){
                Char1name.text = "ROBI";
                Char1speech.text = "Oh it's you! I've actually been meaning to ask, what is this place?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "A.I";
                Char2speech.text = "This is a laboratory. ";
        }
       else if (primeInt == 7){
                Char1name.text = "ROBI";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "ROBI";
                Char1speech.text = "So like... you do human experimentation and stuff?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 21){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "A.I";
                Char2speech.text = "I take it you've met our other residents. Yes, this lab has taken steps to human modification. Although it's very experimental.";
        }
        else if (primeInt == 22){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "ROBI";
                Char1speech.text = "I'm not even gonna ask what for.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 23){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "A.I";
                Char2speech.text = "I believe that is a wise choice. Good for you little ROBI.";
                primeInt = 30;
        }
        else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "ROBI";
                Char1speech.text = "uhm, yeah. I guess it is.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 31){
                Char1name.text = "ROBI";
                Char1speech.text = "I'm gonna take a look around now.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "A.I";
                Char2speech.text = "Be thorough.";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "A.I";
                Char2speech.text = "I suppose I could. This is a lab specializing in genetic modification.";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "ROBI";
                Char1speech.text = "huh.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene9");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}
