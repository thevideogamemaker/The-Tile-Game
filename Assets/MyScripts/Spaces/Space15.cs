﻿using UnityEngine;
using System.Collections;

public class Space15 : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform upSpace;
	public Transform rightSpace;
	public Transform downSpace;
	public Transform leftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	Animator anim;
	
	public int currentArraySpace;
	
	private Space11 S11arraySpace;
	private Space16 S16arraySpace;
	private Space19 S19arraySpace;
	private Space14 S14arraySpace;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		anim = GetComponent<Animator> ();
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);
		
		S11arraySpace = GameObject.FindGameObjectWithTag ("Space11").GetComponent<Space11> ();
		S16arraySpace = GameObject.FindGameObjectWithTag ("Space16").GetComponent<Space16> ();
		S19arraySpace = GameObject.FindGameObjectWithTag ("Space19").GetComponent<Space19> ();
		S14arraySpace = GameObject.FindGameObjectWithTag ("Space14").GetComponent<Space14> ();
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
		if(currentArraySpace == 4)
		{
			currentSpace.renderer.material = blocks[4];
		}
		if(currentArraySpace == 5)
		{
			currentSpace.renderer.material = blocks[5];
		}
		if(currentArraySpace == 6)
		{
			currentSpace.renderer.material = blocks[6];
		}
		if(currentArraySpace == 7)
		{
			currentSpace.renderer.material = blocks[7];
		}
		if(currentArraySpace == 8)
		{
			currentSpace.renderer.material = blocks[8];
		}
		if(currentArraySpace == 9)
		{
			currentSpace.renderer.material = blocks[9];
		}
		
		if(isBeingTouched == true)
		{
			anim.SetBool("Switch",true);
			StartCoroutine(finishanimation());
		}
		
		if(isBeingTouched == false)
		{
			anim.SetBool("Switch",false);
		}
	}
	
	void OnMouseDown ()
	{
		isBeingTouched = true;
		audio.PlayOneShot (clank, 0.5f);
		
		this.currentArraySpace = currentArraySpace + 1;
		S11arraySpace.currentArraySpace = S11arraySpace.currentArraySpace + 1;
		S14arraySpace.currentArraySpace = S14arraySpace.currentArraySpace + 1;
		S16arraySpace.currentArraySpace = S16arraySpace.currentArraySpace + 1;
		S19arraySpace.currentArraySpace = S19arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S11arraySpace.currentArraySpace == 10)
		{
			S11arraySpace.currentArraySpace = 1;
		}
		if(S14arraySpace.currentArraySpace == 10)
		{
			S14arraySpace.currentArraySpace = 1;
		}
		if(S16arraySpace.currentArraySpace == 10)
		{
			S16arraySpace.currentArraySpace = 1;
		}
		if(S19arraySpace.currentArraySpace == 10)
		{
			S19arraySpace.currentArraySpace = 1;
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


