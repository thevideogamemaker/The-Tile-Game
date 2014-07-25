using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {

	void OnTouchUp()
	{
		animation.Play ("PlayAgain");
	}

	IEnumerator changelevel ()
	{
		float fadeTime = GameObject.Find("FadeControl").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("SelectPlayModes");
	}
}
