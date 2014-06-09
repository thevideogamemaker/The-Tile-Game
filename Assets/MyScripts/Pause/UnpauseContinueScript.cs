using UnityEngine;
using System.Collections;

public class UnpauseContinueScript : MonoBehaviour 
{
	private Pausebutton isPausedorisnt;

	void Start()
	{
		isPausedorisnt = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();
	}

	void OnMouseDown ()
	{
		isPausedorisnt.isPaused = false;
	}
}
