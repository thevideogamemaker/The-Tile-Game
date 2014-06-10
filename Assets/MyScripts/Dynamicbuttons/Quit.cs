using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void Start ()
	{
	}

	void OnMouseUp()
	{
		Time.timeScale = 1;
		StartCoroutine (ChangeLevel ());
	}
	
	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Main Menu");
	}
}
