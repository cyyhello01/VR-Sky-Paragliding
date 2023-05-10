using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    public InputData inputData;
    public Button resumeButton;

    // Start is called before the first frame update
    void Start()
    {
        inputData= GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {
        clickedPause();
       
    }

    public void clickedPause()
    {
        //press left controller Y button
        if (Input.GetButtonDown("Fire1") )
        //if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.secondaryButton, out bool yButtonValue))
        {
            Debug.Log("Left Y button is pressed.");
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
}
