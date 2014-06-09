using UnityEngine;
using System.Collections;

public class MoveSpacesOnPause : MonoBehaviour {

	private Pausebutton isPausedOrNah;
	public GameObject Menu;

	// Use this for initialization
	void Start () 
	{
		isPausedOrNah = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isPausedOrNah.isPaused == true)
		{
			transform.position = new Vector3(0.6022871f,13.94497f,0f);
		}
		else if(isPausedOrNah.isPaused == false)
		{
			transform.position = new Vector3(0.6022871f,2.554543f,0f);
			Time.timeScale = 1;
		}
	}
}
