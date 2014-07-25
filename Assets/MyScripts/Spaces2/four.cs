using UnityEngine;
using System.Collections;

public class four : MonoBehaviour {

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
	
	private one S1arraySpace;
	private two S2arraySpace;
	private three S3arraySpace;
	private five S5arraySpace;
	private six S6arraySpace;
	private seven S7arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 5);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S1arraySpace = GameObject.FindGameObjectWithTag ("Space1").GetComponent<one> ();
		S2arraySpace = GameObject.FindGameObjectWithTag ("Space2").GetComponent<two> ();
		S3arraySpace = GameObject.FindGameObjectWithTag ("Space3").GetComponent<three> ();
		S5arraySpace = GameObject.FindGameObjectWithTag ("Space5").GetComponent<five> ();
		S6arraySpace = GameObject.FindGameObjectWithTag ("Space6").GetComponent<six> ();
		S7arraySpace = GameObject.FindGameObjectWithTag ("Space7").GetComponent<seven> ();
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
			leftSpace.animation.Play("Hexagonflip");
			bottomleftSpace.animation.Play("Hexagonflip");
			bottomrightSpace.animation.Play("Hexagonflip");
			topleftSpace.animation.Play("Hexagonflip");
			toprightSpace.animation.Play("Hexagonflip");
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
		S1arraySpace.currentArraySpace += 1;
		S2arraySpace.currentArraySpace += 1;
		S3arraySpace.currentArraySpace += 1;
		S5arraySpace.currentArraySpace += 1;
		S6arraySpace.currentArraySpace += 1;
		S7arraySpace.currentArraySpace += 1;
		
		if(currentArraySpace == 5)
		{
			this.currentArraySpace = 1;
		}
		if(S1arraySpace.currentArraySpace == 5)
		{
			S1arraySpace.currentArraySpace = 1;
		}
		if(S2arraySpace.currentArraySpace == 5)
		{
			S2arraySpace.currentArraySpace = 1;
		}
		if(S3arraySpace.currentArraySpace == 5)
		{
			S3arraySpace.currentArraySpace = 1;
		}
		if(S5arraySpace.currentArraySpace == 5)
		{
			S5arraySpace.currentArraySpace = 1;
		}
		if(S6arraySpace.currentArraySpace == 5)
		{
			S6arraySpace.currentArraySpace = 1;
		}
		if(S7arraySpace.currentArraySpace == 5)
		{
			S7arraySpace.currentArraySpace = 1;
		}
	}
	
	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
