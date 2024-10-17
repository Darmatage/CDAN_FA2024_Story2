using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsTween_AlphaMove : MonoBehaviour{
       public AnimationCurve curveMove = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
       float elapsed = 0f;
       float elapsedMove = 0f;
       public GameObject[] charImages;
	bool timeToBounce = false;

       //float preOffsetPos;
       //float startOffset = 100f;
       public Vector3[] startPos;

	public float endBounce = 0.5f;

       void Start(){
		for (int i = 0; i < charImages.Length; i++){
			startPos[i] += charImages[i].transform.position;
		}
              
              //transform.position = startButtonPos; //set the start position
       }

	void Update(){
		if (Input.GetKeyDown("b")){
			BounceMe();
		}
	}


       void FixedUpdate () {
              if (timeToBounce==true)
              {
                     // Tween Move:
                     //if(startButtonPos.y >= preOffsetPos){
					for (int i = 0; i < charImages.Length; i++){
						Debug.Log("elapsedMove: " + elapsedMove);
						startPos[i].y += curveMove.Evaluate(elapsedMove);
						charImages[i].transform.position = startPos[i];
					}

                            //charImages[i].transform.position.y += curveMove.Evaluate(elapsedMove);
                            //charImages[0].transform.position = startButtonPos;
                     //}
                     elapsedMove += (Time.deltaTime);
              }
       }


	   public void BounceMe(){
			timeToBounce = true;
			StartCoroutine(BounceEnd());
	   }

		IEnumerator BounceEnd(){
			yield return new WaitForSeconds(endBounce);
			timeToBounce = false;
		}

}