using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CheckCardboard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft) {
			SceneManager.LoadScene ("MainMenu");
		}
			
	}

	public void redirectToUrl(string url)
	{
		Application.OpenURL (url);
	}
}
