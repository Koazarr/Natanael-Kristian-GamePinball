using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSourcePrefab;

    private void Start()
    {
        // Start playing BGM when the game starts
        PlayBGM();
    }
    
    // Play background music
    private void PlayBGM() 
    { 
        bgmAudioSource.Play();
    }
    
    // Play sound effect at a specified position
    public void PlaySFX(Vector3 spawnPosition) 
    { 
        GameObject.Instantiate(sfxAudioSourcePrefab, spawnPosition, Quaternion.identity);
    }
}