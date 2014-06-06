using UnityEngine;
using System.Collections;

public class TimeChallengebutton : MonoBehaviour {
	

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseUp ()
	{
		animation.Play ("TimeChallengebutton");
		StartCoroutine (ChangeLevel ());
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find ("FadeControl").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel ("Time Challenge");
	}
}
