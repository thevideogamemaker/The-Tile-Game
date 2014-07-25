using UnityEngine;
using System.Collections;

public class ten : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform leftSpace;
	public Transform topleftSpace;
	public Transform bottomleftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private nine S9arraySpace;
	private seven S7arraySpace;
	private twelve S12arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 5);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S12arraySpace = GameObject.FindGameObjectWithTag("Space12").GetComponent<twelve> ();
		S7arraySpace = GameObject.FindGameObjectWithTag("Space7").GetComponent<seven> ();
		S9arraySpace = GameObject.FindGameObjectWithTag("Space9").GetComponent<nine> ();
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
			leftSpace.animation.Play("Hexagonflip");
			bottomleftSpace.animation.Play("Hexagonflip");
			topleftSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
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
		S12arraySpace.currentArraySpace += 1;
		S7arraySpace.currentArraySpace += 1;
		S9arraySpace.currentArraySpace += 1;
		
		if(currentArraySpace == 5)
		{
			this.currentArraySpace = 1;
		}
		if(S12arraySpace.currentArraySpace == 5)
		{
			S12arraySpace.currentArraySpace = 1;
		}
		if(S7arraySpace.currentArraySpace == 5)
		{
			S7arraySpace.currentArraySpace = 1;
		}
		if(S9arraySpace.currentArraySpace == 5)
		{
			S9arraySpace.currentArraySpace = 1;
		}
	}
	
	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
