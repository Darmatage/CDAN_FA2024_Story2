using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEngine.Events;

public class ItemToExamine : MonoBehaviour{

    int primeInt = -1; 
    bool allowSpace = true;

    public GameObject nextExamine_Button;
    public GameObject itemLargeDisplay;
    public Image itemIcon;
    public GameObject dialogueDisplay;
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    //public AudioSource audioSource1;

    public string[] examineThoughts;

    GameHandler gameHandler;

    void Start(){
        if (GameObject.FindWithTag("GameHandler") != null){
            gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
        }
    }
// Use the spacebar as a faster "Next" button:
    void Update(){        
        if (allowSpace == true){
            if (Input.GetKeyDown("space")){
                ItemNext();
            }
        }
    }

    public void RevealBigItem(){
        itemIcon.sprite = GetComponent<Image>().sprite;
        nextExamine_Button.SetActive(true);
        itemLargeDisplay.SetActive(true);
        dialogueDisplay.SetActive(false);
        //nextExamine_Button.GetComponentInChildren<Button>().onClick.AddListener(MyNext);
    }

    public void ItemNext(){
        primeInt = primeInt + 1;
        if (primeInt == examineThoughts.Length){
            EndDisplay();
        }
        if (primeInt < examineThoughts.Length){
            dialogueDisplay.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = examineThoughts[primeInt];
            Char2name.text = "";
            Char2speech.text = "";
        }
    }

    void EndDisplay(){
        Char1name.text = "";
        Char1speech.text = "";
        dialogueDisplay.SetActive(false);
        nextExamine_Button.SetActive(false);
        itemLargeDisplay.SetActive(false);
    }

}
