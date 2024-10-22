using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersBounceTwo : MonoBehaviour{
	public AnimationCurve curveMove = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
	float elapsedMove = 0f;
    float elapsedMove2 = 0f;
    public GameObject[] charImages;
    public GameObject[] charImages2;
    public Vector3[] startPos;
    public Vector3[] startPos2;
    public float bounceAmt = 5;
    public float bounceAmt2 = 5;
    bool timeToBounce = false;
    bool timeToBounce2 = false;

    //establish initial positions:
    void Start(){
		for (int i = 0; i < charImages.Length; i++){
			startPos[i] += charImages[i].transform.position;
		}
		//character #2:
        for (int i = 0; i < charImages2.Length; i++)
        {
            startPos2[i] += charImages2[i].transform.position;
        }
    }

	//for testing, hit [b]:
	void Update(){
		if (Input.GetKeyDown("b")){
			BounceMe1();
		}
		// character 2
        if (Input.GetKeyDown("n"))
        {
            BounceMe2();
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

        //character 2
        if (timeToBounce2 == true)
        {
            // Tween Move:
            for (int i = 0; i < charImages2.Length; i++)
            {

                float height = curveMove.Evaluate(elapsedMove2);
                Vector3 newPos = new Vector3(startPos2[i].x, startPos2[i].y + (height * bounceAmt2), startPos2[i].z);
                charImages2[i].transform.position = newPos;
                Debug.Log("elapsedMove2: " + elapsedMove2 + ", startPos2.y = " + startPos2[i].y + ", height = " + height);
            }
            elapsedMove2 += Time.deltaTime;
            //reset:
            if (elapsedMove2 >= 1)
            {
                elapsedMove2 = 0;
                timeToBounce2 = false;
            }
        }

    }

	public void BounceMe1(){
		timeToBounce = true;
	}
    //character 2:
    public void BounceMe2()
    {
        timeToBounce2 = true;
    }

}

//to use this script in a story unit:
//GetComponent<CharacterBounce>().BounceMe;

//NOTE: To do this with two characters that are on screen at the same time, would need two BounceMe functions, and two sets of arrays