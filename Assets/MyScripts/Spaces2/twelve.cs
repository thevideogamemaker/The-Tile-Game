using UnityEngine;
using System.Collections;

public class twelve : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform leftSpace;
	public Transform toprightSpace;
	public Transform topleftSpace;
	public Transform bottomrightSpace;
	public Transform bottomleftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private nine S9arraySpace;
	private ten S10arraySpace;
	private eleven S11arraySpace;
	private fourteen S14arraySpace;
	private fifteen S15arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 4);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S9arraySpace = GameObject.FindGameObjectWithTag ("Space9").GetComponent<nine> ();
		S10arraySpace = GameObject.FindGameObjectWithTag ("Space10").GetComponent<ten> ();
		S11arraySpace = GameObject.FindGameObjectWithTag ("Space11").GetComponent<eleven> ();
		S14arraySpace = GameObject.FindGameObjectWithTag ("Space14").GetComponent<fourteen> ();
		S15arraySpace = GameObject.FindGameObjectWithTag ("Space15").GetComponent<fifteen> ();
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
			topleftSpace.animation.Play("Hexagonflip");
			toprightSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
		}
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
			S9arraySpace.currentArraySpace = 1;
			S10arraySpace.currentArraySpace = 1;
			S11arraySpace.currentArraySpace = 1;
			S14arraySpace.currentArraySpace = 1;
			S15arraySpace.currentArraySpace = 1;
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
		S9arraySpace.currentArraySpace += 1;
		S10arraySpace.currentArraySpace += 1;
		S11arraySpace.currentArraySpace += 1;
		S14arraySpace.currentArraySpace += 1;
		S15arraySpace.currentArraySpace += 1;
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
		}
		if(S9arraySpace.currentArraySpace == 4)
		{
			S9arraySpace.currentArraySpace = 1;
		}
		if(S10arraySpace.currentArraySpace == 4)
		{
			S10arraySpace.currentArraySpace = 1;
		}
		if(S11arraySpace.currentArraySpace == 4)
		{
			S11arraySpace.currentArraySpace = 1;
		}
		if(S14arraySpace.currentArraySpace == 4)
		{
			S14arraySpace.currentArraySpace = 1;
		}
		if(S15arraySpace.currentArraySpace == 4)
		{
			S15arraySpace.currentArraySpace = 1;
		}
	}
	
	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
