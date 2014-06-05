using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	public string Scene;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp()
	{
		Application.LoadLevel (Scene);
	}
}
