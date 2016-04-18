﻿using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

    public AudioSource musicAudioSource;
    public AudioClip mainMusic;
    public AudioClip[] worldsMusic;

    public AudioSource effectsAudioSource;
    public AudioClip buttonClip;
    public AudioClip countDownClip;
    public AudioClip startClip;
    public AudioClip finishClip;
    public AudioClip turboClip;
    
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
        musicAudioSource.clip = mainMusic;
        musicAudioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void playButtonSound()
    {
        effectsAudioSource.clip = buttonClip;
        effectsAudioSource.Play();
    }

    public void playCountDownSound()
    {
        musicAudioSource.Stop();
        effectsAudioSource.clip = countDownClip;
        effectsAudioSource.Play();
    }

    public void playStartSound()
    {
        effectsAudioSource.clip = startClip;
        effectsAudioSource.Play();
    }

    public void playFinishSound()
    {
        effectsAudioSource.clip = finishClip;
        effectsAudioSource.Play();
    }

    public void playBlackHoleSound()
    {
        effectsAudioSource.volume = 0.0f;
        musicAudioSource.volume = 0.0f;
    }

    public void restoreMusicSound()
    {
        effectsAudioSource.volume = 0.5f;
        musicAudioSource.volume = 0.5f;
    }

    public void playMainMenuMusic()
    {
        musicAudioSource.clip = mainMusic;
        musicAudioSource.Play();
    }

    public void playWorldMusic(int world)
    {
        musicAudioSource.clip = worldsMusic[world];
        musicAudioSource.Play();
    }

    public void playTurboSound()
    {
        effectsAudioSource.clip = turboClip;
        effectsAudioSource.Play();
    }
}