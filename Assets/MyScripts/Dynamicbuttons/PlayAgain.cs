using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {
	
	public string Scene;

	void OnMouseDown()
	{
		animation.Play ("PlayAgain");
		StartCoroutine (ChangeLevel ());
	}
	
	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel (Scene);
	}
}
