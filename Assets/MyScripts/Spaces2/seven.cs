using UnityEngine;
using System.Collections;

public class seven : MonoBehaviour {

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
	
	private four S4arraySpace;
	private five S5arraySpace;
	private six S6arraySpace;
	private nine S9arraySpace;
	private ten S10arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 4);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S4arraySpace = GameObject.FindGameObjectWithTag ("Space4").GetComponent<four> ();
		S5arraySpace = GameObject.FindGameObjectWithTag ("Space5").GetComponent<five> ();
		S6arraySpace = GameObject.FindGameObjectWithTag ("Space6").GetComponent<six> ();
		S9arraySpace = GameObject.FindGameObjectWithTag ("Space9").GetComponent<nine> ();
		S10arraySpace = GameObject.FindGameObjectWithTag ("Space10").GetComponent<ten> ();
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
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
			S4arraySpace.currentArraySpace = 1;
			S5arraySpace.currentArraySpace = 1;
			S6arraySpace.currentArraySpace = 1;
			S9arraySpace.currentArraySpace = 1;
			S10arraySpace.currentArraySpace = 1;
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
		S4arraySpace.currentArraySpace += 1;
		S5arraySpace.currentArraySpace += 1;
		S6arraySpace.currentArraySpace += 1;
		S9arraySpace.currentArraySpace += 1;
		S10arraySpace.currentArraySpace += 1;
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
		}
		if(S4arraySpace.currentArraySpace == 4)
		{
			S4arraySpace.currentArraySpace = 1;
		}
		if(S5arraySpace.currentArraySpace == 4)
		{
			S5arraySpace.currentArraySpace = 1;
		}
		if(S6arraySpace.currentArraySpace == 4)
		{
			S6arraySpace.currentArraySpace = 1;
		}
		if(S9arraySpace.currentArraySpace == 4)
		{
			S9arraySpace.currentArraySpace = 1;
		}
		if(S10arraySpace.currentArraySpace == 4)
		{
			S10arraySpace.currentArraySpace = 1;
		}
	}
	
	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
