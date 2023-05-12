using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public GameObject vrCamera;

    // Start is called before the first frame update
    void Start()
    {
            vrCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = vrCamera.transform.position;
    }
}
