using UnityEngine;
using System.Collections;

public class Backbutton : MonoBehaviour {

	Animator anim;
	public string scene;
	
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
		Application.LoadLevel (scene);
	}
}
