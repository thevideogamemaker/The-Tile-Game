using UnityEngine;
using System.Collections;

public class PauseMenuDestroy : MonoBehaviour {

	private Pausebutton isPausedOrNah;

	// Use this for initialization
	void Start () 
	{
		isPausedOrNah = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isPausedOrNah.isPaused == false)
		{
			Destroy(this.gameObject);
		}
	}
}
