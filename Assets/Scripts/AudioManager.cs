using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour {

    public Sounds[] sounds;
    public bool isFighting = false;

	// Use this for initialization
	void Awake () {
        foreach (Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
	}

    public void Play(string name)
    {
        if (isFighting == true)
        {
            Sounds s = Array.Find(sounds, sound => sound.name == name);
            s.source.Play();
        }
        if(isFighting == false)
        {
            Sounds s = Array.Find(sounds, sound => sound.name == name);
            s.source.Play();
        }
    }

    public void Stop(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
