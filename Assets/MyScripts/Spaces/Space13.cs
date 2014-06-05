using UnityEngine;
using System.Collections;

public class Space13 : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform upSpace;
	public Transform rightSpace;
	public Transform downSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private Space9 S9arraySpace;
	private Space14 S14arraySpace;
	private Space17 S17arraySpace;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);
		
		S9arraySpace = GameObject.FindGameObjectWithTag ("Space9").GetComponent<Space9> ();
		S14arraySpace = GameObject.FindGameObjectWithTag ("Space14").GetComponent<Space14> ();
		S17arraySpace = GameObject.FindGameObjectWithTag ("Space17").GetComponent<Space17> ();
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
			currentSpace.animation.Play("TileSwitch");
			upSpace.animation.Play("TileSwitch");
			downSpace.animation.Play("TileSwitch");
			rightSpace.animation.Play("TileSwitch");
			StartCoroutine(finishanimation());
		}
	}
	
	void OnMouseDown ()
	{
		isBeingTouched = true;
		audio.PlayOneShot (clank, 0.5f);
		
		this.currentArraySpace = currentArraySpace + 1;
		S9arraySpace.currentArraySpace = S9arraySpace.currentArraySpace + 1;
		S14arraySpace.currentArraySpace = S14arraySpace.currentArraySpace + 1;
		S17arraySpace.currentArraySpace = S17arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S9arraySpace.currentArraySpace == 10)
		{
			S9arraySpace.currentArraySpace = 1;
		}
		if(S14arraySpace.currentArraySpace == 10)
		{
			S14arraySpace.currentArraySpace = 1;
		}
		if(S17arraySpace.currentArraySpace == 10)
		{
			S17arraySpace.currentArraySpace = 1;
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


