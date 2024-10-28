using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwich_Manager : MonoBehaviour{
	
	//the bool that knows all!
	public bool completedSandwich = false;
	
	//recipe images-- pictures or HUD content
	public GameObject recipe1;
	public GameObject recipe2;
	public GameObject recipe3;
	public GameObject recipe4;
	public GameObject recipe5;
	public GameObject recipe6;
	
	public int theRecipeNum;
	public string[] recipeCurrent;
	public string[] sandwichCurrent;
	
	//the slots to check for completion
	public sandwich_slot slot1;
	public sandwich_slot slot2;
	public sandwich_slot slot3;
	public sandwich_slot slot4;
	public sandwich_slot slot5;
	public sandwich_slot slot6;
	
	//hide all recipes, call loadRecipe to display one.
    void Start(){
		recipe1.SetActive(false);
		recipe2.SetActive(false);
		recipe3.SetActive(false);
		recipe4.SetActive(false);
		recipe5.SetActive(false);
		recipe6.SetActive(false);
		
        loadRecipe();
		
		//int sandwichSize = recipeCurrent.Length;
		//sandwichCurrent.Length = sandwichSize;
    }

	//at start, randomly choose a recipe and load it up.
	public void loadRecipe(){
		theRecipeNum = Random.Range(1,7);
		if (theRecipeNum == 1){
			recipe1.SetActive(true); 
			recipeCurrent = recipe1.GetComponent<sandwich_recipe>().thisRecipe;
		}
		else if (theRecipeNum == 2){
			recipe2.SetActive(true); 
			recipeCurrent = recipe2.GetComponent<sandwich_recipe>().thisRecipe;
		}
		else if (theRecipeNum == 3){
			recipe3.SetActive(true); 
			recipeCurrent = recipe3.GetComponent<sandwich_recipe>().thisRecipe;
		}		
		else if (theRecipeNum == 4){
			recipe4.SetActive(true); 
			recipeCurrent = recipe4.GetComponent<sandwich_recipe>().thisRecipe;
		}		
		else if (theRecipeNum == 5){
			recipe5.SetActive(true); 
			recipeCurrent = recipe5.GetComponent<sandwich_recipe>().thisRecipe;
		}		
		else if (theRecipeNum == 6){
			recipe6.SetActive(true); 
			recipeCurrent = recipe6.GetComponent<sandwich_recipe>().thisRecipe;
		}		
	}
	
	//activate from sandwich_food, when dropped in a slot
	public void CheckRecipe(){
		Debug.Log("I am checking the recipe, you betcha!");
		
		 
		//sandwichCurrent = new string[](slot1.foodFilled,slot2.foodFilled,slot3.foodFilled,slot4.foodFilled,slot5.foodFilled,slot6.foodFilled);
		string[] sandwichCurrentTemp = {
			slot1.foodFilled,
			slot2.foodFilled,
			slot3.foodFilled,
			slot4.foodFilled,
			slot5.foodFilled,
			slot6.foodFilled};
			
		sandwichCurrent = sandwichCurrentTemp;
		
		bool theSame = false;
		for (int i=0; i<6; i++){
			if (sandwichCurrent[i]==recipeCurrent[i]){
				theSame = true;
				Debug.Log("item #" + i + " are identical!");
			} else {
				theSame = false; 
				break;
			}
		}
		
		if (theSame){
			completedSandwich = true;
			RecipeSuccess();	
		} else {Debug.Log("Not yet the right sandwich, buckaroo.");}
	}
	
	public void RecipeSuccess(){
		//do the things when success!
		Debug.Log("You finished the correct sandwich, you pro, you!");
	}
	
	public void RestartSandwich(){
		slot1.RefreshSlot();
		slot2.RefreshSlot();
		slot3.RefreshSlot();
		slot4.RefreshSlot();
		slot5.RefreshSlot();
		slot6.RefreshSlot();
		sandwichCurrent = null;
	}
	
	
}
