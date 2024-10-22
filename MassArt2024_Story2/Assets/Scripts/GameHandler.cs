
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEditor.PackageManager;

public class GameHandler : MonoBehaviour
{
    public static bool hasUSB = false;  // scene 9
    public static bool hasKeycard = false; // scene 7
    public static bool hasPassword = false; // scene 6

    public static int timeRemaining;
	public int timeMax = 100;
	public TMP_Text timerText;
    // public GameObject textGameObject;

    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;
    public AudioMixer mixer;
    public static float volumeLevel = 1.0f;
    private Slider sliderVolumeCtrl;

    void Awake(){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
                GameisPaused = false;
        
		timeRemaining = timeMax;
		UpdateStats(); 
	}

    void Update(){         
	                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){ Resume(); }
                        else{ Pause(); }
                }

        // Stat tester:
        //if (Input.GetKey("p")){
        //       Debug.Log("Player Stat = " + playerStat1);
        //}
    }


    public void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }



	//public function that other scripts can access to update stats like time remaining:
    public void UpdateStats () {
    	timerText.text = "TIME REMAINING: " + timeRemaining; 
        if (timeRemaining == 0)
        {
            SceneManager.LoadScene("SceneLose");
        }
	}

    public void StartGame(){
        SceneManager.LoadScene("Scene1");
    }

    public void OpenCredits(){
        SceneManager.LoadScene("Credits");
    }

    public void RestartGame(){
        Time.timeScale = 1f;
        hasUSB = false;
        hasKeycard = false;
        hasPassword = false;
        timeRemaining = 100;

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