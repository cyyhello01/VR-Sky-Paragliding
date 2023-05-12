using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;

    private InputData inputData;

    // Start is called before the first frame update
    void Start()
    {
        inputData= GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {
        //press left controller Y button
        if (inputData.leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool yButtonValue))
        {
            Debug.Log("Left Y button is pressed.");
            clickedPause();
        }
    }

    public void clickedPause()
    {
            if (gamePaused == false)
            { 
                Time.timeScale = 0; //freeze time
                gamePaused = true;
                pauseMenu.SetActive(true); //open pause menu
            }
            else
            {
                pauseMenu.SetActive(false); //close pause menu
                gamePaused = false;
                Time.timeScale = 1; //unfreeze time
            }

    }
}
