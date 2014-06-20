using UnityEngine;
using System.Collections;

public class ClassicsModebutton : MonoBehaviour {

	void OnMouseUp ()
	{
		animation.Play ("ClassicModebutton");
		StartCoroutine (ChangeLevel ());
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Classic Mode");
	}
}
