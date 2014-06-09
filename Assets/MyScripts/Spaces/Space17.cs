using UnityEngine;
using System.Collections;

public class Space17 : MonoBehaviour {
	
	public Material[] blocks;
	public Transform currentSpace;
	public Transform upSpace;
	public Transform rightSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	private VolumeToggle Mute;
	
	public int currentArraySpace;
	
	private Space13 S13arraySpace;
	private Space18 S18arraySpace;
	
	void Start () 
	{
		//renderer.material = blocks[Random.Range(1,blocks.GetLength(0))];
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 9);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S13arraySpace = GameObject.FindGameObjectWithTag ("Space13").GetComponent<Space13> ();
		S18arraySpace = GameObject.FindGameObjectWithTag ("Space18").GetComponent<Space18> ();
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
			rightSpace.animation.Play("TileSwitch");
			StartCoroutine(finishanimation());
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
		S13arraySpace.currentArraySpace = S13arraySpace.currentArraySpace + 1;
		S18arraySpace.currentArraySpace = S18arraySpace.currentArraySpace + 1;
		
		if(currentArraySpace == 10)
		{
			this.currentArraySpace = 1;
		}
		if(S13arraySpace.currentArraySpace == 10)
		{
			S13arraySpace.currentArraySpace = 1;
		}
		if(S18arraySpace.currentArraySpace == 10)
		{
			S18arraySpace.currentArraySpace = 1;
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


