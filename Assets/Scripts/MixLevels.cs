﻿using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class MixLevels : MonoBehaviour {

	public AudioMixer masterMixer;

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}

	public void SetSfxLevel(float sfxLevel){
		masterMixer.SetFloat("sfxVol", sfxLevel);
		masterMixer.SetFloat("sfxVol", sfxLevel);
	}

	public void SetMusicLevel(float musicLevel){
		masterMixer.SetFloat("music", musicLevel);
	}
}
