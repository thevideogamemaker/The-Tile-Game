using UnityEngine;
using System.Collections;

public class MoveMenuButton : MonoBehaviour {

	private Pausebutton isPausedOrNah;

	void Start ()
	{
		isPausedOrNah = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();	
	}

	void Update () 
	{
		if(isPausedOrNah.isPaused == true)
		{
			transform.position = new Vector3(3.694056f,14.75136f,0.6493483f);
		}
		else if(isPausedOrNah.isPaused == false)
		{
			transform.position = new Vector3(3.694056f,4.309731f,0.6493483f);
		}
	}
}
