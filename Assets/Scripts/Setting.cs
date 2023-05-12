using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public bool gameSetting = false;
    public GameObject settingMenu;

    private InputData inputData;

    // Start is called before the first frame update
    void Start()
    {
        inputData = GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickedSetting()
    {
        if (gameSetting == false)
        {
            gameSetting = true;
            settingMenu.SetActive(true); //open setting menu
        }
        else
        {
            settingMenu.SetActive(false); //close setting menu
            gameSetting = false;
        }

    }
}
