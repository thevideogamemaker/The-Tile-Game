using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	void OnTouchUp ()
	{
		animation.Play ("Settings");
		StartCoroutine (ChangeLevel ());
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Settings");
	}
}
