using UnityEngine;
using System.Collections;

public class QuitButton : MonoBehaviour {

	void OnMouseUp()
	{
		StartCoroutine (ChangeLevel ());
	}
	
	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Main Menu");
	}
}
