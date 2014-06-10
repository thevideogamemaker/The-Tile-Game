using UnityEngine;
using System.Collections;

public class QuitButton : MonoBehaviour {

	public string scene;

	void Start ()
	{

	}

	void Update () 
	{
		
	}

	void OnMouseDown()
	{
		StartCoroutine (ChangeLevel ());
	}
	
	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel (scene);
	}
}
