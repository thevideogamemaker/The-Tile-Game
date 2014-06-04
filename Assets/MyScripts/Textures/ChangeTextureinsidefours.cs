using UnityEngine;
using System.Collections;

public class ChangeTextureinsidefours : MonoBehaviour {

	public Material[] blocks;
	public Transform currentSpace;
	public Transform rightSpace;
	public Transform bottomSpace;
	public Transform upSpace;
	public Transform leftSpace;

	bool isBeingTouched;
	public AudioClip clank;
	Animator anim;

	public int currentArraySpace;

	// Use this for initialization
	void Start () 
	{
		renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		anim = GetComponent<Animator> ();
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);
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
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		//currentSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		//rightSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		//bottomSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		//upSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		//leftSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
	}

	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
