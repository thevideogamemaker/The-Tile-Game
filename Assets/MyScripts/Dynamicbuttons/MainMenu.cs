using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnTouchUp()
	{
		this.animation.Play ("MainMenu");
	}

	IEnumerator changelevel ()
	{
		float fadeTime = GameObject.Find("FadeControl").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Main Menu");
	}
}
