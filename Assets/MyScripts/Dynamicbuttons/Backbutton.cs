using UnityEngine;
using System.Collections;

public class Backbutton : MonoBehaviour {
	
	void OnTouchUp ()
	{
		animation.Play ("Backbutton");
	}

	IEnumerator changelevel ()
	{
		float fadeTime = GameObject.Find("FadeControl").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Main Menu");
	}
}
