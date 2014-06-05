using UnityEngine;
using System.Collections;

public class Space14 : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform upSpace;
	public Transform rightSpace;
	public Transform downSpace;
	public Transform leftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private Space10 S10arraySpace;
	private Space15 S15arraySpace;
	private Space18 S18arraySpace;
	private Space13 S13arraySpace;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);
		
		S10arraySpace = GameObject.FindGameObjectWithTag ("Space10").GetComponent<Space10> ();
		S15arraySpace = GameObject.FindGameObjectWithTag ("Space15").GetComponent<Space15> ();
		S18arraySpace = GameObject.FindGameObjectWithTag ("Space18").GetComponent<Space18> ();
		S13arraySpace = GameObject.FindGameObjectWithTag ("Space13").GetComponent<Space13> ();
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
			leftSpace.animation.Play("TileSwitch");
			StartCoroutine(finishanimation());
		}
	}
	
	void OnMouseDown ()
	{
		isBeingTouched = true;
		audio.PlayOneShot (clank, 0.5f);
		
		this.currentArraySpace = currentArraySpace + 1;
		S10arraySpace.currentArraySpace = S10arraySpace.currentArraySpace + 1;
		S15arraySpace.currentArraySpace = S15arraySpace.currentArraySpace + 1;
		S18arraySpace.currentArraySpace = S18arraySpace.currentArraySpace + 1;
		S13arraySpace.currentArraySpace = S13arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S10arraySpace.currentArraySpace == 10)
		{
			S10arraySpace.currentArraySpace = 1;
		}
		if(S15arraySpace.currentArraySpace == 10)
		{
			S15arraySpace.currentArraySpace = 1;
		}
		if(S18arraySpace.currentArraySpace == 10)
		{
			S18arraySpace.currentArraySpace = 1;
		}
		if(S13arraySpace.currentArraySpace == 10)
		{
			S13arraySpace.currentArraySpace = 1;
			
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


