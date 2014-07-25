using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	public bool quitted = false;

	void OnTouchDown ()
	{
		Time.timeScale = 1;
	}

	IEnumerator changelevel ()
	{
		float fadeTime = GameObject.Find("FadeControl").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Main Menu");
	}
}
