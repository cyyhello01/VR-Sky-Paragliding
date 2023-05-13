using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundEffect : MonoBehaviour
{
    public AudioMixer soundEffectMixer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetEffectVolume(float effectvolume)
    {
        soundEffectMixer.SetFloat("effectvolume", effectvolume);
    }
}
