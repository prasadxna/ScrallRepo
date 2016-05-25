using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AudioManager : MonoBehaviour {
	
	//Method that plays music in a loop for passed audio source and audio clip
	public static 	void playMusic(AudioSource musicSource,AudioClip clip)
	{
		musicSource.clip = clip;
		if(musicSource.loop==false)
			musicSource.loop = true;
		musicSource.Play ();
	}

	//Above method overloaded for GVR Audio
	public static 	void playMusic(GvrAudioSource musicSource,AudioClip clip)
	{
		musicSource.clip = clip;
		if(musicSource.loop==false)
			musicSource.loop = true;
		musicSource.Play ();
	}
	//Mathod takes a audio source and audioclip and plays it.
	public static  void playSFX(AudioSource sfxSource,AudioClip clip)
	{
		sfxSource.clip = clip;
		if(sfxSource.loop==true)
		sfxSource.loop = false;
		sfxSource.Play (); 
	}
	//Above method verloaded for GVR 
	public static  void playSFX(GvrAudioSource sfxSource,AudioClip clip)
	{
		sfxSource.clip = clip;
		if(sfxSource.loop==true)
			sfxSource.loop = false;
		sfxSource.Play ();
	}

	//Method to play sfx sound with vibration.
	//If pattern is null The handheld will vibrate till the audio clip has finished.
	//Else if pattern is passed it uses pattern to play the vibration.
	public static  void playSFXWithVibration(GvrAudioSource sfxSource,AudioClip clip,long[] pattern=null)
	{
		sfxSource.clip = clip;	
		if(sfxSource.loop==true)
			sfxSource.loop = false;
		if (pattern == null)
			Vibration.Vibrate ((long)(clip.length) * 1000);					//Vibrate till n milliseconds
		else
			Vibration.Vibrate (pattern, -1);
		sfxSource.Play ();
	}
	//Overload for Unity's Audio Source
	public static  void playSFXWithVibration(AudioSource sfxSource,AudioClip clip,long[] pattern=null)
	{
		sfxSource.clip = clip;
		if(sfxSource.loop==true)
			sfxSource.loop = false;
		if (pattern == null)
			Vibration.Vibrate ((long)clip.length * 1000);					//Vibrate till n milliseconds
		else
			Vibration.Vibrate (pattern, -1);
		sfxSource.Play ();
	}


}
