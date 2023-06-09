using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {

        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
        }

        Play("bgm");


        

        
    }

    public void PlayLoop(string name){

        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
        s.source.loop = true;
    }

    public void Play(string name){

        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Stop(string name){

        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
