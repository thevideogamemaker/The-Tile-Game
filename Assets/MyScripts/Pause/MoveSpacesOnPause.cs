using UnityEngine;
using System.Collections;

public class MoveSpacesOnPause : MonoBehaviour {

	private Pausebutton isPausedOrIsNot;
	public GameObject Menu;

	void Start () 
	{
		isPausedOrIsNot = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();	
	}

	void Update () 
	{
		if(isPausedOrIsNot.isPaused == true)
		{
			transform.position = new Vector3(0.6022871f,13.94497f,0f);
		}
		else if(isPausedOrIsNot.isPaused == false)
		{
			transform.position = new Vector3(0.6704106f,2.707915f,0f);
			Time.timeScale = 1;
		}
	}
}
