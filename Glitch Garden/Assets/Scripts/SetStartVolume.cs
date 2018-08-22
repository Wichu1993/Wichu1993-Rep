using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        float volume = PlayerPrefsManager.GetMasterVolume();
        musicManager.SetVolume(volume);
    }
	
}
