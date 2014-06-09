using UnityEngine;
using System.Collections;

public class PauseMenuDestroy : MonoBehaviour {

	private Pausebutton isPausedOrIsNot;

	// Use this for initialization
	void Start () 
	{
		isPausedOrIsNot = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isPausedOrIsNot.isPaused == false)
		{
			Destroy(this.gameObject);
		}
	}
}
