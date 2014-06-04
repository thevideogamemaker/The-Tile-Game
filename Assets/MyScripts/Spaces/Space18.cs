using UnityEngine;
using System.Collections;

public class Space18 : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform upSpace;
	public Transform rightSpace;
	public Transform leftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	Animator anim;
	
	public int currentArraySpace;
	
	private Space14 S14arraySpace;
	private Space19 S19arraySpace;
	private Space17 S17arraySpace;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		anim = GetComponent<Animator> ();
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);
		
		S14arraySpace = GameObject.FindGameObjectWithTag ("Space14").GetComponent<Space14> ();
		S17arraySpace = GameObject.FindGameObjectWithTag ("Space17").GetComponent<Space17> ();
		S19arraySpace = GameObject.FindGameObjectWithTag ("Space19").GetComponent<Space19> ();
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
			anim.SetBool("Switch",true);
			StartCoroutine(finishanimation());
		}
		
		if(isBeingTouched == false)
		{
			anim.SetBool("Switch",false);
		}
	}
	
	void OnMouseDown ()
	{
		isBeingTouched = true;
		audio.PlayOneShot (clank, 0.5f);
		
		this.currentArraySpace = currentArraySpace + 1;
		S14arraySpace.currentArraySpace = S14arraySpace.currentArraySpace + 1;
		S17arraySpace.currentArraySpace = S17arraySpace.currentArraySpace + 1;
		S19arraySpace.currentArraySpace = S19arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S14arraySpace.currentArraySpace == 10)
		{
			S14arraySpace.currentArraySpace = 1;
		}
		if(S17arraySpace.currentArraySpace == 10)
		{
			S17arraySpace.currentArraySpace = 1;
		}
		if(S19arraySpace.currentArraySpace == 10)
		{
			S19arraySpace.currentArraySpace = 1;
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


