using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp ()
	{
		anim.SetBool ("Clicked", true);
		Application.LoadLevel ("Settings");
	}
}
