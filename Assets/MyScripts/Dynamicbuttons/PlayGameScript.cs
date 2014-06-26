using UnityEngine;
using System.Collections;

public class PlayGameScript : MonoBehaviour {

	void OnTouchUp ()
	{
		animation.Play ("PlayGameanimation");
		StartCoroutine (ChangeLevel ());
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("SelectPlayModes");
	}
}
