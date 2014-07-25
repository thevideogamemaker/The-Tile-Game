using UnityEngine;
using System.Collections;

public class ClassicsModebutton : MonoBehaviour {

	void OnTouchUp ()
	{
		animation.Play ("ClassicModebutton");
	}

	IEnumerator changelevel ()
	{
		float fadeTime = GameObject.Find("FadeControl").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Classic Mode");
	}
}
