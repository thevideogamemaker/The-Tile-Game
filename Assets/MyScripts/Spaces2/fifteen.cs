using UnityEngine;
using System.Collections;

public class fifteen : MonoBehaviour {

	public Material[] blocks;
	public Transform currentSpace;
	public Transform leftSpace;
	public Transform topleftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private twelve S12arraySpace;
	private fourteen S14arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 4);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S12arraySpace = GameObject.FindGameObjectWithTag ("Space12").GetComponent<twelve> ();
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

		if(isBeingTouched == true)
		{
			currentSpace.animation.Play("Hexagonflip");
			leftSpace.animation.Play("Hexagonflip");
			topleftSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
		}
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
			S12arraySpace.currentArraySpace = 1;
			S14arraySpace.currentArraySpace = 1;
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
		S12arraySpace.currentArraySpace = S12arraySpace.currentArraySpace + 1;
		S14arraySpace.currentArraySpace = S14arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
		}
		if(S12arraySpace.currentArraySpace == 4)
		{
			S12arraySpace.currentArraySpace = 1;
		}
		if(S14arraySpace.currentArraySpace == 4)
		{
			S14arraySpace.currentArraySpace = 1;
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
