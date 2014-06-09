using UnityEngine;
using System.Collections;

public class Space1 : MonoBehaviour {

	public Material[] blocks;
	public Transform currentSpace;
	public Transform rightSpace;
	public Transform downSpace;

	bool isBeingTouched;
	public AudioClip clank;

	public int currentArraySpace;

	private Space2 S2arraySpace;
	private Space5 S5arraySpace;
	private VolumeToggle Mute;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();

		S2arraySpace = GameObject.FindGameObjectWithTag ("Space2").GetComponent<Space2> ();
		S5arraySpace = GameObject.FindGameObjectWithTag ("Space5").GetComponent<Space5> ();
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
			downSpace.animation.Play("TileSwitch");
			StartCoroutine(finishanimation());
		}

		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
			S2arraySpace.currentArraySpace = 1;
			S5arraySpace.currentArraySpace = 1;
			
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
		S2arraySpace.currentArraySpace = S2arraySpace.currentArraySpace + 1;
		S5arraySpace.currentArraySpace = S5arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S2arraySpace.currentArraySpace == 10)
		{
			S2arraySpace.currentArraySpace = 1;
		}
		if(S5arraySpace.currentArraySpace == 10)
		{
			S5arraySpace.currentArraySpace = 1;
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
