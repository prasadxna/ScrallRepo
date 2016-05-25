using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MySceneManager : MonoBehaviour {

	static AsyncOperation loadSceneOp;

	static Slider progressBar;
	static Animator blackScreen;
	static MySceneManager instance;
	// Use this for initialization
	void Awake () {
		instance=this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static  void loadLevelAsync(string sceneName,Slider loadingPn,Animator blkScr)
	{
		if(loadSceneOp==null)
		{
		progressBar=loadingPn;
		blackScreen=blkScr;
		loadSceneOp=SceneManager.LoadSceneAsync(sceneName,LoadSceneMode.Single);
		loadSceneOp.allowSceneActivation=false;
		instance.StartCoroutine("showProgressBar");
		}

	}

	IEnumerator showProgressBar()
	{
		fadeSystemAnim.fadeCanvGrp(blackScreen,false);
		while(!fadeSystemAnim.isFaded)
		{
			yield return new WaitForEndOfFrame();
		}
		if (progressBar != null) {	
			progressBar.gameObject.SetActive (true);
		}
		while(loadSceneOp.progress<0.9f )
		{

			if (progressBar != null)
			progressBar.normalizedValue=loadSceneOp.progress;
			yield return new WaitForEndOfFrame();
		}
		loadSceneOp.allowSceneActivation=true;
		loadSceneOp=null;

	}
}
