using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{


    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;
    

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AudioClip thisLevelMusic = levelMusicChangeArray[0];
        audioSource.clip = thisLevelMusic;
        audioSource.Play();
    }

    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing: " + thisLevelMusic);

        if (thisLevelMusic && audioSource.clip != thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
