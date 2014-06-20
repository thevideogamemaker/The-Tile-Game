using UnityEngine;
using System.Collections;

public class Facebookbutton : MonoBehaviour {

	void OnMouseDown ()
	{
		Application.CaptureScreenshot("TheTileGame");
		Application.OpenURL("https://Facebook.com");
	}
}
