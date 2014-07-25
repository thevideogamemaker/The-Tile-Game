using UnityEngine;
using System.Collections;

public class Facebookbutton : MonoBehaviour {

	void OnTouchDown ()
	{
		Application.CaptureScreenshot("TheTileGame");
		Application.OpenURL("https://Facebook.com");
	}
}
