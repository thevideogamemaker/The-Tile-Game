using UnityEngine;
using System.Collections;

public class Backbutton : MonoBehaviour {
	
	void OnTouchUp ()
	{
		animation.Play ("Backbutton");
		StartCoroutine (ChangeLevel ());
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Main Menu");
	}
}
