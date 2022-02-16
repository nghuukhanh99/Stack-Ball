using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    public AudioClip boostRun;

    public AudioClip levelUp;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void runSoundEffect()
    {
        audioSource.PlayOneShot(boostRun, 7);
    }

    public void levelUpMusic()
    {
        audioSource.PlayOneShot(levelUp, 7);
    }
}
