using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBounce : MonoBehaviour{
	public AnimationCurve curveMove = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
	float elapsedMove = 0f;
	public GameObject[] charImages;
	public Vector3[] startPos;
	public float bounceAmt = 5;
	bool timeToBounce = false;

	//establish initial positions:
	void Start(){
		for (int i = 0; i < charImages.Length; i++){
			startPos[i] += charImages[i].transform.position;
		}
	}

	//for testing, hit [b]:
	void Update(){
		if (Input.GetKeyDown("b")){
			BounceMe();
		}
	}

	void FixedUpdate () {
		if (timeToBounce==true){
		// Tween Move:
			for (int i = 0; i < charImages.Length; i++){
				
				float height = curveMove.Evaluate(elapsedMove);
				Vector3 newPos = new Vector3(startPos[i].x, startPos[i].y + (height *bounceAmt), startPos[i].z);
				charImages[i].transform.position = newPos;
				Debug.Log("elapsedMove: " + elapsedMove + ", startPos.y = " + startPos[i].y + ", height = " + height);
			}
			elapsedMove += Time.deltaTime;
			//reset:
			if (elapsedMove >= 1){
				elapsedMove=0;
				timeToBounce = false;
			}
		}
	}

	public void BounceMe(){
		timeToBounce = true;
	}

}

//to use this script in a story unit:
//GetComponent<CharacterBounce>().BounceMe;

//NOTE: To do this with two characters that are on screen at the same time, would need two BounceMe functions, and two sets of arrays