using UnityEngine;
using System.Collections;

public class one : MonoBehaviour {

	public Material[] blocks;
	public Transform currentSpace;
	public Transform rightSpace;
	public Transform bottomrightSpace;
	public Transform bottomleftSpace;
	
	bool isBeingTouched;
	public AudioClip clank;
	
	public int currentArraySpace;
	
	private two S2arraySpace;
	private three S3arraySpace;
	private four S4arraySpace;
	private VolumeToggle Mute;
	
	void Awake () 
	{
		isBeingTouched = false;
		currentArraySpace = Random.Range (1, 5);
		Mute = GameObject.Find("SoundToggle").GetComponent<VolumeToggle> ();
		
		S2arraySpace = GameObject.FindGameObjectWithTag("Space2").GetComponent<two> ();
		S3arraySpace = GameObject.FindGameObjectWithTag("Space3").GetComponent<three> ();
		S4arraySpace = GameObject.FindGameObjectWithTag("Space4").GetComponent<four> ();
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
		
		if(isBeingTouched == true)
		{
			currentSpace.animation.Play("Hexagonflip");
			rightSpace.animation.Play("Hexagonflip");
			bottomleftSpace.animation.Play("Hexagonflip");
			bottomrightSpace.animation.Play("Hexagonflip");
			StartCoroutine(finishanimation());
		}
	}
	
	void OnTouchDown ()
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
		
		this.currentArraySpace += 1;
		S2arraySpace.currentArraySpace += 1;
		S3arraySpace.currentArraySpace += 1;
		S4arraySpace.currentArraySpace += 1;
		
		if(currentArraySpace == 5)
		{
			this.currentArraySpace = 1;
		}
		if(S2arraySpace.currentArraySpace == 5)
		{
			S2arraySpace.currentArraySpace = 1;
		}
		if(S3arraySpace.currentArraySpace == 5)
		{
			S3arraySpace.currentArraySpace = 1;
		}
		if(S4arraySpace.currentArraySpace == 5)
		{
			S4arraySpace.currentArraySpace = 1;
		}
	}
	
	IEnumerator finishanimation ()
	{
		yield return new WaitForSeconds(0.4f);
		isBeingTouched = false;
	}
}
