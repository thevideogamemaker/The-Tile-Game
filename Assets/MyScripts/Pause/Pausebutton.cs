using UnityEngine;
using System.Collections;

public class Pausebutton : MonoBehaviour {

	public bool isPaused;
	public GameObject pauseMenu;
	public Transform theCamera;
	public Transform soundtoggle;
	[HideInInspector]
	public bool spawned;
	public bool MenuIsOnScreen = false;

	void Start () 
	{
		isPaused = false;
	}

	void OnTouchDown () 
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

	void Update ()
	{
		if(isPaused == true && spawned == false)
		{
			if(MenuIsOnScreen == false)
			{
				Instantiate(pauseMenu, new Vector3(5.488507f,-0.2448015f,1.466759f), Quaternion.identity);
				spawned = true;
				MenuIsOnScreen = true;
			}

			if(MenuIsOnScreen == true)
			{

				pauseMenu.transform.position = new Vector3(5.488507f,-0.2448015f,1.466759f);
				spawned = true;
			}
		}
	}
}
