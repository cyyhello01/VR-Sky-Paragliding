using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip onHoverSound;
    public AudioClip onSelectSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HoverSound()
    {
        sound.PlayOneShot(onHoverSound);
    }

    public void SelectSound()
    {
        sound.PlayOneShot(onSelectSound);
    }
}
