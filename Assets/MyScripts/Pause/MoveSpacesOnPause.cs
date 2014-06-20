using UnityEngine;
using System.Collections;

public class MoveSpacesOnPause : MonoBehaviour {

	private Pausebutton isPausedOrNah;
	public GameObject Menu;

	void Start () 
	{
		isPausedOrNah = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();	
	}

	void Update () 
	{
		if(isPausedOrNah.isPaused == true)
		{
			transform.position = new Vector3(0.6022871f,13.94497f,0f);
		}
		else if(isPausedOrNah.isPaused == false)
		{
			transform.position = new Vector3(0.6704106f,2.707915f,0f);
			Time.timeScale = 1;
		}
	}
}
