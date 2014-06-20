using UnityEngine;
using System.Collections;

public class Twitterbutton : MonoBehaviour {

	void OnMouseDown ()
	{
		Application.CaptureScreenshot("TheTileGame");
		Application.OpenURL("https://twitter.com");
	}
}	