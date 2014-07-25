using UnityEngine;
using System.Collections;

public class MoveMenuButton : MonoBehaviour {

	private Pausebutton isPausedOrIsNot;
	public GameObject menubutton;

	void Start ()
	{
		isPausedOrIsNot = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();	
	}

	void Update () 
	{
		if(isPausedOrIsNot.isPaused == true)
		{
			menubutton.transform.position = new Vector3(3.476657f,14.75136f,0.6493483f);
		}
		else if(isPausedOrIsNot.isPaused == false)
		{
			menubutton.transform.position = new Vector3(3.476657f,4.309731f,0.6493483f);
		}
	}
}
