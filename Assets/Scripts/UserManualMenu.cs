using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserManualMenu : MonoBehaviour
{
    public GameObject manual;

    // Start is called before the first frame update
    void Start()
    {
        manual = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickedClosed()
    {
        manual.SetActive(false);
    }

    public void clickedOpen()
    {
        manual.SetActive(true);
    }
}
