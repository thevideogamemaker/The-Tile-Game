using UnityEngine;
using System.Collections;

public class Backbutton : MonoBehaviour {
	
	public string scene;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseUp ()
	{
		animation.Play ("Backbutton");
		StartCoroutine (ChangeLevel ());
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel (scene);
	}
}
