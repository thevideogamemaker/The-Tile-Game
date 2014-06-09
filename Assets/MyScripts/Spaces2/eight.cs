using UnityEngine;
using System.Collections;

public class eight : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform rightSpace;
	public Transform bottomrightSpace;
	public Transform toprightSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private six S6arraySpace;
	private nine S9arraySpace;
	private eleven S11arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 4);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S6arraySpace = GameObject.FindGameObjectWithTag ("Space6").GetComponent<six> ();
		S9arraySpace = GameObject.FindGameObjectWithTag("Space9").GetComponent<nine> ();
		S11arraySpace = GameObject.FindGameObjectWithTag ("Space11").GetComponent<eleven> ();
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
			toprightSpace.animation.Play("Hexagonflip");
			bottomrightSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
		}
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
			S11arraySpace.currentArraySpace = 1;
			S9arraySpace.currentArraySpace = 1;
			S6arraySpace.currentArraySpace = 1;
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
		S11arraySpace.currentArraySpace = S11arraySpace.currentArraySpace + 1;
		S9arraySpace.currentArraySpace = S9arraySpace.currentArraySpace + 1;
		S6arraySpace.currentArraySpace = S6arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 4)
		{
			this.currentArraySpace = 1;
		}
		if(S11arraySpace.currentArraySpace == 4)
		{
			S11arraySpace.currentArraySpace = 1;
		}
		if(S9arraySpace.currentArraySpace == 4)
		{
			S9arraySpace.currentArraySpace = 1;
		}
		if(S6arraySpace.currentArraySpace == 4)
		{
			S6arraySpace.currentArraySpace = 1;
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
