﻿using UnityEngine;
using System.Collections;

public class QuitButton : MonoBehaviour {
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown()
	{
		StartCoroutine (ChangeLevel ());
	}
	
	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Main Menu");
	}
}