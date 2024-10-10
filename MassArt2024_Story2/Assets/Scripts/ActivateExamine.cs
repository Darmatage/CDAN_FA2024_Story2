using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateExamine : MonoBehaviour{

    public GameObject DialogueDisplay;
    public GameObject Nextbutton;
    public GameObject InvestigationMenu;
    public GameObject largeIconImage;

    public GameObject[] characters;

    bool isOpen = false;

    void Start(){
        InvestigationMenu.SetActive(false);
        largeIconImage.SetActive(false);
    }

    public void OpenCloseExamine(){
        isOpen = !isOpen;
        if (isOpen){
            DialogueDisplay.SetActive(false);
            Nextbutton.SetActive(false);
            InvestigationMenu.SetActive(true);
            for (int i =0; i<characters.Length; i++){
                characters[i].SetActive(false);
            }
        }
        else {
            DialogueDisplay.SetActive(true);
            Nextbutton.SetActive(true);
            InvestigationMenu.SetActive(false);
            for (int i =0; i<characters.Length; i++){
              characters[i].SetActive(true);
            }
        }
    }
}
