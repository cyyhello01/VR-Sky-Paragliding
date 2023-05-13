using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraCollision : MonoBehaviour
{
    public TextMeshProUGUI alertMsg;
    public GameObject gameOverMenu;
    public AudioSource checkpointSound;
    public TextMeshProUGUI getPointText;
    int checkpoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        checkpointSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        getPointText.enabled = false;
        gameOverMenu.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Circle")
        {
            checkpoint += 1;
            other.gameObject.SetActive(false); //if collide with the circle, disable the circle
            getPointText.text = "You get " + checkpoint + "checkpoint(s)";
            getPointText.enabled = true; 
            checkpointSound.Play();
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mountain")
        {
            gameOverMenu.gameObject.SetActive(true);
        }
    }
}
