﻿using UnityEngine;
using System.Collections;

public class nine : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform rightSpace;
	public Transform leftSpace;
	public Transform bottomrightSpace;
	public Transform bottomleftSpace;
	public Transform topleftSpace;
	public Transform toprightSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private six S6arraySpace;
	private seven S7arraySpace;
	private eight S8arraySpace;
	private ten S10arraySpace;
	private eleven S11arraySpace;
	private twelve S12arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 4);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S6arraySpace = GameObject.FindGameObjectWithTag ("Space6").GetComponent<six> ();
		S7arraySpace = GameObject.FindGameObjectWithTag ("Space7").GetComponent<seven> ();
		S8arraySpace = GameObject.FindGameObjectWithTag ("Space8").GetComponent<eight> ();
		S10arraySpace = GameObject.FindGameObjectWithTag ("Space10").GetComponent<ten> ();
		S11arraySpace = GameObject.FindGameObjectWithTag ("Space11").GetComponent<eleven> ();
		S12arraySpace = GameObject.FindGameObjectWithTag ("Space12").GetComponent<twelve> ();
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
			rightSpace.animation.Play("Hexagonflip");
			leftSpace.animation.Play("Hexagonflip");
			bottomleftSpace.animation.Play("Hexagonflip");
			bottomrightSpace.animation.Play("Hexagonflip");
			topleftSpace.animation.Play("Hexagonflip");
			toprightSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
		}
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
			S6arraySpace.currentArraySpace = 1;
			S7arraySpace.currentArraySpace = 1;
			S8arraySpace.currentArraySpace = 1;
			S10arraySpace.currentArraySpace = 1;
			S11arraySpace.currentArraySpace = 1;
			S12arraySpace.currentArraySpace = 1;
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
		
		this.currentArraySpace = currentArraySpace + 1;
		S6arraySpace.currentArraySpace = S6arraySpace.currentArraySpace + 1;
		S7arraySpace.currentArraySpace = S7arraySpace.currentArraySpace + 1;
		S8arraySpace.currentArraySpace = S8arraySpace.currentArraySpace + 1;
		S10arraySpace.currentArraySpace = S10arraySpace.currentArraySpace + 1;
		S11arraySpace.currentArraySpace = S11arraySpace.currentArraySpace + 1;
		S12arraySpace.currentArraySpace = S12arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
		}
		if(S6arraySpace.currentArraySpace == 4)
		{
			S6arraySpace.currentArraySpace = 1;
		}
		if(S7arraySpace.currentArraySpace == 4)
		{
			S7arraySpace.currentArraySpace = 1;
		}
		if(S8arraySpace.currentArraySpace == 4)
		{
			S8arraySpace.currentArraySpace = 1;
		}
		if(S10arraySpace.currentArraySpace == 4)
		{
			S10arraySpace.currentArraySpace = 1;
		}
		if(S11arraySpace.currentArraySpace == 4)
		{
			S11arraySpace.currentArraySpace = 1;
		}
		if(S12arraySpace.currentArraySpace == 4)
		{
			S12arraySpace.currentArraySpace = 1;
		}
		//currentSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		//rightSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		//upSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		//leftSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
	}
	
	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
