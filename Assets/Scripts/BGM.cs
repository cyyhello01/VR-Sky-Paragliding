using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BGM : MonoBehaviour
{
    public AudioMixer backgroundMixer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetBGMVolume(float bgmvolume)
    {
        backgroundMixer.SetFloat("bgmvolume", bgmvolume);
    }
}
