using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwich_slot : MonoBehaviour{
	
	public int slotID = 1;
	public string foodFilled;
	
	//ingredient image slots
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	public GameObject item5;
	public GameObject item6;
			
	//flashing on trigger enter:
	public GameObject slotBG;
	public Color flashColor;
	public Color startColor_slot;
	public Color startColor_item1;
	public Color startColor_item2;
	public Color startColor_item3;
	public Color startColor_item4;
	public Color startColor_item5;
	public Color startColor_item6;	
			
    void Start(){
		//make all ingredients invisible
		item1.SetActive(false);
        item2.SetActive(false);
		item3.SetActive(false);
		item4.SetActive(false);
		item5.SetActive(false);
		item6.SetActive(false);
		
		startColor_slot = slotBG.GetComponent<SpriteRenderer>().color;
		
		startColor_item1 = item1.GetComponent<SpriteRenderer>().color;
		startColor_item2 = item2.GetComponent<SpriteRenderer>().color;
		startColor_item3 = item3.GetComponent<SpriteRenderer>().color;
		startColor_item4 = item4.GetComponent<SpriteRenderer>().color;
		startColor_item5 = item5.GetComponent<SpriteRenderer>().color;
		startColor_item6 = item6.GetComponent<SpriteRenderer>().color;		
		
		//flashColor = new Color(2.3f, 2.3f, 1.1f, 1f);
    }

    void Update(){
		//make the current ingredient visible
        if (foodFilled == "bunTop"){
			item1.SetActive(true);
			item2.SetActive(false);
			item3.SetActive(false);
			item4.SetActive(false);
			item5.SetActive(false);
			item6.SetActive(false);			
			slotBG.SetActive(false);}
		else if (foodFilled == "lettuce") { 
			item1.SetActive(false);
			item2.SetActive(true);
			item3.SetActive(false);
			item4.SetActive(false);
			item5.SetActive(false);
			item6.SetActive(false);
			slotBG.SetActive(false);}
		else if (foodFilled == "tomato") {
			item1.SetActive(false);
			item2.SetActive(false);
			item3.SetActive(true);
			item4.SetActive(false);
			item5.SetActive(false);
			item6.SetActive(false);			
			slotBG.SetActive(false);}
		else if (foodFilled == "pickles") {
			item1.SetActive(false);
			item2.SetActive(false);
			item3.SetActive(false);
			item4.SetActive(true);
			item5.SetActive(false);
			item6.SetActive(false);			
			slotBG.SetActive(false);}
		else if (foodFilled == "meat") {
			item1.SetActive(false);
			item2.SetActive(false);
			item3.SetActive(false);
			item4.SetActive(false);
			item5.SetActive(true);
			item6.SetActive(false);			
			slotBG.SetActive(false);}
		else if (foodFilled == "bunBot") {
			item1.SetActive(false);
			item2.SetActive(false);
			item3.SetActive(false);
			item4.SetActive(false);
			item5.SetActive(false);
			item6.SetActive(true);			
			slotBG.SetActive(false);}
    }
	
	//feedback: flash the slot
	public void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "SandwichFood"){
			slotBG.GetComponent<SpriteRenderer>().color = flashColor;
			item1.GetComponent<SpriteRenderer>().color = flashColor;
			item2.GetComponent<SpriteRenderer>().color = flashColor;
			item3.GetComponent<SpriteRenderer>().color = flashColor;
			item4.GetComponent<SpriteRenderer>().color = flashColor;
			item5.GetComponent<SpriteRenderer>().color = flashColor;
			item6.GetComponent<SpriteRenderer>().color = flashColor;
		}
	}
	
	//feedback: un-flash the slot
	public void OnTriggerExit2D(Collider2D other){
		if(other.gameObject.tag == "SandwichFood"){
			slotBG.GetComponent<SpriteRenderer>().color = startColor_slot;
			item1.GetComponent<SpriteRenderer>().color = startColor_item1;
			item2.GetComponent<SpriteRenderer>().color = startColor_item2;
			item3.GetComponent<SpriteRenderer>().color = startColor_item3;
			item4.GetComponent<SpriteRenderer>().color = startColor_item4;
			item5.GetComponent<SpriteRenderer>().color = startColor_item5;
			item6.GetComponent<SpriteRenderer>().color = startColor_item6;
		}
	}
	
	public void RefreshSlot(){
		item1.SetActive(false);
        item2.SetActive(false);
		item3.SetActive(false);
		item4.SetActive(false);
		item5.SetActive(false);
		item6.SetActive(false);
		slotBG.SetActive(true);
		foodFilled = "";
		slotBG.GetComponent<SpriteRenderer>().color = startColor_slot;
	}
	
}
