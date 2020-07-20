using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SoundManager : MonoBehaviour
{
    public Sounds[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sounds s in sounds)
        {
            s.audioSource = gameObject.AddComponent<AudioSource>();
           
            s.audioSource.clip = s.audioClip;
            s.audioSource.volume = s.volume;
            s.audioSource.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        Sounds s=Array.Find(sounds, sound => sound.audioName == name);
        if (s == null)
        {
            return;
        }
        s.audioSource.Play();
    }
}
