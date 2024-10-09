
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

    public static int timeRemaining;
	public int timeMax = 100;
	public TMP_Text timerText;
    // public GameObject textGameObject;

    void Start () { 
		timeRemaining = timeMax;
		UpdateStats(); 
	}

    void Update(){         
		//delete this quit functionality when a Pause Menu is added!
        if (Input.GetKey("escape")){
            Application.Quit();
        }

        // Stat tester:
        //if (Input.GetKey("p")){
        //       Debug.Log("Player Stat = " + playerStat1);
        //}
    }

	//public function that other scripts can access to update stats like time remaining:
    public void UpdateStats () {
    	timerText.text = "TIME REMAINING: " + timeRemaining; 
	}

    public void StartGame(){
        SceneManager.LoadScene("Scene1");
    }

    public void OpenCredits(){
        SceneManager.LoadScene("Credits");
    }

    public void RestartGame(){
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame(){
	#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
	#else
                Application.Quit();
	#endif
    }
}