using UnityEngine;
using System.Collections;

public class Space5 : MonoBehaviour {

	public Material[] blocks;
	public Transform currentSpace;
	public Transform upSpace;
	public Transform rightSpace;
	public Transform leftSpace;
	public Transform downSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;

	private Space1 S1arraySpace;
	private Space6 S6arraySpace;
	private Space9 S9arraySpace;
	private Space4 S4arraySpace;

	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);

		S1arraySpace = GameObject.FindGameObjectWithTag ("Space1").GetComponent<Space1> ();
		S4arraySpace = GameObject.FindGameObjectWithTag ("Space4").GetComponent<Space4> ();
		S6arraySpace = GameObject.FindGameObjectWithTag ("Space6").GetComponent<Space6> ();
		S9arraySpace = GameObject.FindGameObjectWithTag ("Space9").GetComponent<Space9> ();
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
			rightSpace.animation.Play("TileSwitch");
			upSpace.animation.Play("TileSwitch");
			downSpace.animation.Play("TileSwitch");
			leftSpace.animation.Play("TileSwitch");
			StartCoroutine(finishanimation());
		}
	}
	
	void OnMouseDown ()
	{
		isBeingTouched = true;
		audio.PlayOneShot (clank, 0.5f);
		
		this.currentArraySpace = currentArraySpace + 1;
		S1arraySpace.currentArraySpace = S1arraySpace.currentArraySpace + 1;
		S4arraySpace.currentArraySpace = S4arraySpace.currentArraySpace + 1;
		S6arraySpace.currentArraySpace = S6arraySpace.currentArraySpace + 1;
		S9arraySpace.currentArraySpace = S9arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S1arraySpace.currentArraySpace == 10)
		{
			S1arraySpace.currentArraySpace = 1;
		}
		if(S6arraySpace.currentArraySpace == 10)
		{
			S6arraySpace.currentArraySpace = 1;
		}
		if(S9arraySpace.currentArraySpace == 10)
		{
			S9arraySpace.currentArraySpace = 1;
		}
		if(S4arraySpace.currentArraySpace == 10)
		{
			S4arraySpace.currentArraySpace = 1;
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


