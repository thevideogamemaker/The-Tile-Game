using UnityEngine;
using System.Collections;

public class Pausebutton : MonoBehaviour {

	public bool isPaused;
	public GameObject pauseMenu;
	public Transform theCamera;

	void Start () 
	{
		isPaused = false;
	}

	void OnMouseDown () 
	{
		Pause ();
	}

	void FixedUpdate ()
	{
		if(isPaused == true)
		{
			Instantiate(pauseMenu,theCamera.position,Quaternion.identity);
		}
	}

	void Pause ()
	{
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			isPaused = true;
		}
		else
		{
			Time.timeScale = 1;
			isPaused = false;
		}
	}
}
