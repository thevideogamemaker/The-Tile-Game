using UnityEngine;
using System.Collections;

public class eleven : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform rightSpace;
	public Transform bottomrightSpace;
	public Transform bottomleftSpace;
	public Transform toprightSpace;
	public Transform topleftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private eight S8arraySpace;
	private nine S9arraySpace;
	private twelve S12arraySpace;
	private thirteen S13arraySpace;
	private fourteen S14arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 5);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S8arraySpace = GameObject.FindGameObjectWithTag ("Space8").GetComponent<eight> ();
		S9arraySpace = GameObject.FindGameObjectWithTag ("Space9").GetComponent<nine> ();
		S12arraySpace = GameObject.FindGameObjectWithTag ("Space12").GetComponent<twelve> ();
		S13arraySpace = GameObject.FindGameObjectWithTag ("Space13").GetComponent<thirteen> ();
		S14arraySpace = GameObject.FindGameObjectWithTag ("Space14").GetComponent<fourteen> ();
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
		
		if(isBeingTouched == true)
		{
			currentSpace.animation.Play("Hexagonflip");
			rightSpace.animation.Play("Hexagonflip");
			bottomleftSpace.animation.Play("Hexagonflip");
			bottomrightSpace.animation.Play("Hexagonflip");
			topleftSpace.animation.Play("Hexagonflip");
			toprightSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
		}
		
		if(currentArraySpace == 5)
		{
			this.currentArraySpace = 1;
			S8arraySpace.currentArraySpace = 1;
			S9arraySpace.currentArraySpace = 1;
			S12arraySpace.currentArraySpace = 1;
			S13arraySpace.currentArraySpace = 1;
			S14arraySpace.currentArraySpace = 1;
		}
	}
	
	void OnTouchDown ()
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
		S8arraySpace.currentArraySpace += 1;
		S9arraySpace.currentArraySpace += 1;
		S12arraySpace.currentArraySpace += 1;
		S13arraySpace.currentArraySpace += 1;
		S14arraySpace.currentArraySpace += 1;
		
		if(currentArraySpace == 5)
		{
			this.currentArraySpace = 1;
		}
		if(S8arraySpace.currentArraySpace == 5)
		{
			S8arraySpace.currentArraySpace = 1;
		}
		if(S9arraySpace.currentArraySpace == 5)
		{
			S9arraySpace.currentArraySpace = 1;
		}
		if(S12arraySpace.currentArraySpace == 5)
		{
			S12arraySpace.currentArraySpace = 1;
		}
		if(S13arraySpace.currentArraySpace == 5)
		{
			S13arraySpace.currentArraySpace = 1;
		}
		if(S14arraySpace.currentArraySpace == 5)
		{
			S14arraySpace.currentArraySpace = 1;
		}
	}
	
	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
