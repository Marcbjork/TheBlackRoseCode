using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    private OpenButtonScript openButtonScript;
    [SerializeField] private OutroSequence outroSequence;

    void Start()
    {
        openButtonScript = FindObjectOfType<OpenButtonScript>();

        //recieving null reference exceptions as these reference are set to disabled in the scene from the start, so references are missing
        // Placing these in the options function instead for now - JOHN
        /*
        Mouseslider = GameObject.Find("Mouseslider").GetComponent<Slider>();
        Mouseslider.onValueChanged.AddListener(delegate { MouseSenseSlider(Mouseslider.value); });

        cameraLook = FindObjectOfType<CameraLook>();
        headBob = FindObjectOfType<HeadBob>();
        */
        pauseMenuUI.SetActive(false);
     
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && openButtonScript.gameStarted == true && !outroSequence.outroStarted)
        {
            if (GameIsPaused)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
      
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ExitMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainLevel1");
    }

}
