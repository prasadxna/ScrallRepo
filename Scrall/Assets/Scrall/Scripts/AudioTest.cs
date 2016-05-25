using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AudioTest : MonoBehaviour {
	AudioManager audMan;
	[SerializeField]
	Animator anim;

	// Use this for initialization
	void Start () {
		
		fadeSystemAnim.fadeCanvGrp (anim, true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
