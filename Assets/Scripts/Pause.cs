using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class Pause : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;

    private InputDevice rightController;

    // Start is called before the first frame update
    void Start()
    {
        // Get the input device for the right controller
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithRole(InputDeviceRole.RightHanded, devices);
        if (devices.Count > 0)
        {
            rightController = devices[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check for input from the right controller's primary button
        if (rightController != null && rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        {
            Debug.Log("Right primary button is pressed.");
            clickedPause();
        }
    }

    public void clickedPause()
    {
        if (!gamePaused)
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
