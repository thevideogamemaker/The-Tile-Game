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
			transform.position = new Vector3(4.002988f,9.962639f,1.50773f);
		}
		else if(isPausedOrNah.isPaused == false)
		{
			transform.position = new Vector3(4.002988f,-0.2789307f,1.50773f);
			Time.timeScale = 1;
		}
	}
}
