using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	public string Scene;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		this.animation.Play ("Backbutton");
		StartCoroutine (ChangeLevel ());
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel (Scene);
	}
}
