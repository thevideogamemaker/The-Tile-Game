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
			transform.position = new Vector3(21.92335f,transform.position.y,transform.position.z);
			isPausedOrIsNot.spawned = false;
		}
	}
}
