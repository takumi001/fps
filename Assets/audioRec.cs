﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioRec : MonoBehaviour {

	AudioClip myAudioClip; 

	void Start() {}
	void Update () {}

	void OnGUI()
	{
		if (GUI.Button(new Rect(10,10,60,50),"Record"))
		{ 
			myAudioClip = Microphone.Start ( null, false, 10, 44100 );
		}
		if (GUI.Button(new Rect(10,70,60,50),"Save"))
		{
			SavWav.Save("myfile", myAudioClip);

			//        audio.Play();
		}
	}
}
