using UnityEngine;
using System.Collections;

public class UnpauseContinueScript : MonoBehaviour 
{
	private Pausebutton isPausedOrNah;

	void Start()
	{
		isPausedOrNah = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<Pausebutton> ();
	}

	void OnMouseDown ()
	{
		isPausedOrNah.isPaused = false;
	}
}
