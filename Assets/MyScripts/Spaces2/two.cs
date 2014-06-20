﻿using UnityEngine;
using System.Collections;

public class two : MonoBehaviour {

	public Material[] blocks;
	public Transform currentSpace;
	public Transform leftSpace;
	public Transform bottomrightSpace;
	public Transform bottomleftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private one S1arraySpace;
	private five S5arraySpace;
	private four S4arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 4);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S1arraySpace = GameObject.FindGameObjectWithTag ("Space1").GetComponent<one> ();
		S5arraySpace = GameObject.FindGameObjectWithTag ("Space5").GetComponent<five> ();
		S4arraySpace = GameObject.FindGameObjectWithTag ("Space4").GetComponent<four> ();
	}
	
	
	void Update () 
	{
		if(currentArraySpace == 1)
		{
			currentSpace.renderer.material = blocks[1];
		}
		if(currentArraySpace == 2)
		{
			currentSpace.renderer.material = blocks[2];
		}
		if(currentArraySpace == 3)
		{
			currentSpace.renderer.material = blocks[3];
		}
		
		if(isBeingTouched == true)
		{
			currentSpace.animation.Play("Hexagonflip");
			leftSpace.animation.Play("Hexagonflip");
			bottomleftSpace.animation.Play("Hexagonflip");
			bottomrightSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
		}
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
			S1arraySpace.currentArraySpace = 1;
			S5arraySpace.currentArraySpace = 1;
			S4arraySpace.currentArraySpace = 1;
		}
	}
	
	void OnMouseDown ()
	{
		isBeingTouched = true;
		if(Mute.IsMuted == false)
		{
			audio.PlayOneShot (clank, 0.5f);
		}
		else
		{
			audio.PlayOneShot (clank, 0f);
		}
		
		this.currentArraySpace += 1;
		S1arraySpace.currentArraySpace += 1;
		S5arraySpace.currentArraySpace += 1;
		S4arraySpace.currentArraySpace += 1;
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
		}
		if(S1arraySpace.currentArraySpace == 4)
		{
			S1arraySpace.currentArraySpace = 1;
		}
		if(S5arraySpace.currentArraySpace == 4)
		{
			S5arraySpace.currentArraySpace = 1;
		}
		if(S4arraySpace.currentArraySpace == 4)
		{
			S4arraySpace.currentArraySpace = 1;
		}
	}
	
	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}