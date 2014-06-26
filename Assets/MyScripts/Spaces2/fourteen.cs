using UnityEngine;
using System.Collections;

public class fourteen : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform rightSpace;
	public Transform leftSpace;
	public Transform topleftSpace;
	public Transform toprightSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private eleven S11arraySpace;
	private twelve S12arraySpace;
	private thirteen S13arraySpace;
	private fifteen S15arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 4);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S11arraySpace = GameObject.FindGameObjectWithTag ("Space11").GetComponent<eleven> ();
		S12arraySpace = GameObject.FindGameObjectWithTag ("Space12").GetComponent<twelve> ();
		S13arraySpace = GameObject.FindGameObjectWithTag ("Space13").GetComponent<thirteen> ();
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
			rightSpace.animation.Play("Hexagonflip");
			leftSpace.animation.Play("Hexagonflip");
			topleftSpace.animation.Play("Hexagonflip");
			toprightSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
		}
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
			S11arraySpace.currentArraySpace = 1;
			S12arraySpace.currentArraySpace = 1;
			S13arraySpace.currentArraySpace = 1;
			S15arraySpace.currentArraySpace = 1;
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
		S11arraySpace.currentArraySpace += 1;
		S12arraySpace.currentArraySpace += 1;
		S13arraySpace.currentArraySpace += 1;
		S15arraySpace.currentArraySpace += 1;
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
		}
		if(S11arraySpace.currentArraySpace == 4)
		{
			S11arraySpace.currentArraySpace = 1;
		}
		if(S12arraySpace.currentArraySpace == 4)
		{
			S12arraySpace.currentArraySpace = 1;
		}
		if(S13arraySpace.currentArraySpace == 4)
		{
			S13arraySpace.currentArraySpace = 1;
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
