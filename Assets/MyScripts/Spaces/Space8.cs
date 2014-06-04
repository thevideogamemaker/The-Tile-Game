using UnityEngine;
using System.Collections;

public class Space8 : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform upSpace;
	public Transform downSpace;
	public Transform leftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	Animator anim;
	
	public int currentArraySpace;
	
	private Space4 S4arraySpace;
	private Space12 S12arraySpace;
	private Space7 S7arraySpace;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		anim = GetComponent<Animator> ();
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);
		
		S4arraySpace = GameObject.FindGameObjectWithTag ("Space4").GetComponent<Space4> ();
		S12arraySpace = GameObject.FindGameObjectWithTag ("Space12").GetComponent<Space12> ();
		S7arraySpace = GameObject.FindGameObjectWithTag ("Space7").GetComponent<Space7> ();
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
		S4arraySpace.currentArraySpace = S4arraySpace.currentArraySpace + 1;
		S12arraySpace.currentArraySpace = S12arraySpace.currentArraySpace + 1;
		S7arraySpace.currentArraySpace = S7arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S4arraySpace.currentArraySpace == 10)
		{
			S4arraySpace.currentArraySpace = 1;
		}
		if(S12arraySpace.currentArraySpace == 10)
		{
			S12arraySpace.currentArraySpace = 1;
		}
		if(S7arraySpace.currentArraySpace == 10)
		{
			S7arraySpace.currentArraySpace = 1;
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


