using UnityEngine;
using System.Collections;

public class ChangeTexturerightside : MonoBehaviour {

	public Material [] blocks;
	public Transform currentSpace;
	public Transform leftSpace;
	public Transform bottomSpace;
	public Transform upSpace;

	bool isBeingTouched;
	public AudioClip clank;
	Animator anim;

	// Use this for initialization
	void Start () 
	{
		renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		anim = GetComponent<Animator> ();
		isBeingTouched = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
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
		currentSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		leftSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		bottomSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		upSpace.renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
	}

	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
