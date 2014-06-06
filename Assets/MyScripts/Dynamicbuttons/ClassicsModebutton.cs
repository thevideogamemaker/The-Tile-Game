﻿using UnityEngine;
using System.Collections;

public class ClassicsModebutton : MonoBehaviour {
	

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseUp ()
	{
		animation.Play ("ClassicModebutton");
		StartCoroutine (ChangeLevel ());
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Classic Mode");
	}
}
