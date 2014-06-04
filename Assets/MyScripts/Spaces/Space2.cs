using UnityEngine;
using System.Collections;

public class Space2 : MonoBehaviour {

	public Material[] blocks;
	public Transform currentSpace;
	public Transform rightSpace;
	public Transform downSpace;
	public Transform leftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	Animator anim;
	
	public int currentArraySpace;

	private Space1 S1arraySpace;
	private Space3 S3arraySpace;
	private Space6 S6arraySpace;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		anim = GetComponent<Animator> ();
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);

		S1arraySpace = GameObject.FindGameObjectWithTag ("Space1").GetComponent<Space1> ();
		S3arraySpace = GameObject.FindGameObjectWithTag ("Space3").GetComponent<Space3> ();
		S6arraySpace = GameObject.FindGameObjectWithTag ("Space6").GetComponent<Space6> ();
	}

	// Update is called once per frame
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
		S1arraySpace.currentArraySpace = S1arraySpace.currentArraySpace + 1;
		S3arraySpace.currentArraySpace = S3arraySpace.currentArraySpace + 1;
		S6arraySpace.currentArraySpace = S6arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S1arraySpace.currentArraySpace == 10)
		{
			S1arraySpace.currentArraySpace = 1;
		}
		if(S3arraySpace.currentArraySpace == 10)
		{
			S3arraySpace.currentArraySpace = 1;
		}
		if(S6arraySpace.currentArraySpace == 10)
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
