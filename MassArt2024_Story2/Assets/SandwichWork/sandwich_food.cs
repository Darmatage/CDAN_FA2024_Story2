using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwich_food : MonoBehaviour{
	
	//type name into inspector. Must be one of these: bunTop, lettuce, tomato, pickles, meat, bunBot
	public string foodItem; 
	private Vector2 foodOrigin;
	public GameObject glowSelect;
	
	public sandwich_Manager sandManage;
	
	//drag and drop:
	private bool selected;
	
	public bool isOnSlot;
	public GameObject currentSlot;
	
	void Awake(){
		foodOrigin = transform.position;	
	}
	
	void Start(){
		glowSelect.SetActive(false);
	}
        
	//drag and drop functions
	void Update () {
		if (selected == true) {
			Vector2 cursorPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			transform.position = new Vector2 (cursorPos.x, cursorPos.y);
		}

		if (Input.GetMouseButtonUp (0)) {
			selected = false;
			if (isOnSlot){
				currentSlot.GetComponent<sandwich_slot>().foodFilled = foodItem;
				sandManage.CheckRecipe();
				transform.position = foodOrigin;
			}
		}
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			selected = true;
			glowSelect.SetActive(false);
		} else {
			glowSelect.SetActive(true);
		}
	}
	
	void OnMouseExit(){
			glowSelect.SetActive(false);
	}
	
	
	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag=="SandwichSlot"){
			isOnSlot = true;
			currentSlot = other.gameObject;
		}
	}
	
	public void OnTriggerExit2D(Collider2D other){
			if (other.gameObject.tag=="SandwichSlot"){
			isOnSlot = false;
			currentSlot = null;
		}
	}
	
	
// On release: if I am over a food slot
//  Instantiate(thisFoodPrefab, foodOrigin, Quaternion.identity);
// Tell the slot script the food name: = foodItem; //will auto display side art)
// sandManage.checkRecipe(); //tell the sandwich_Manager to check for win condition
// delete this food object
	
}
