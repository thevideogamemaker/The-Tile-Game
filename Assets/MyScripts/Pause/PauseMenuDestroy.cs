using UnityEngine;
using System.Collections;

public class PauseMenuDestroy : MonoBehaviour {

	private Pausebutton isPausedOrIsNot;
	
	void Start () 
	{
		isPausedOrIsNot = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();	
	}

	void Update () 
	{
		if(isPausedOrIsNot.isPaused == false)
		{
			Destroy(this.gameObject);
		}
	}
}
