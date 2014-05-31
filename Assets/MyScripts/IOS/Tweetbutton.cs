using UnityEngine;
using System.Collections;

public class Tweetbutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown ()
	{
		Application.OpenURL ("www.twitter.com");
	}
}
