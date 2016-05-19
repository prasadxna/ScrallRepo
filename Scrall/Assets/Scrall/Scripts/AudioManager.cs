using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
	AudioSource musicSource;
	AudioSource sfxSource;

	void playMusic(AudioClip clip)
	{
		musicSource.clip = clip;
		musicSource.Play ();
	}

	void playSFX(AudioClip clip)
	{
		sfxSource.clip = clip;
		sfxSource.Play ();
	}

	void playSFXWithVibration(AudioClip clip)
	{
		sfxSource.clip = clip;
		Handheld.Vibrate ();
		sfxSource.Play ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
