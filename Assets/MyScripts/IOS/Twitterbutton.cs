using UnityEngine;
using System.Collections;

public class Twitterbutton : MonoBehaviour {

	void OnTouchDown ()
	{
		Application.CaptureScreenshot("TheTileGame");
		Application.OpenURL("https://twitter.com");
	}
}	