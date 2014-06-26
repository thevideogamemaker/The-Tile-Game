using UnityEngine;
using System.Collections;

public class CountUPtimer : MonoBehaviour {

	private GameWinController1 wins;
	private Quit quit;

	public float Seconds = 59;
	public float Minutes = 0;

	void Start ()
	{
		wins = GameObject.Find ("Controller").GetComponent<GameWinController1> ();
	}

	void Update () 
	{
		if(wins.GameWon == false)
		{
			if(Seconds > 59)
			{
				Minutes ++;
				Seconds = 0;
			}

			GameObject.Find("Timer").guiText.text = "Time: " + Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");

			Seconds += Time.deltaTime;

			if(Mathf.Round(Seconds) <= 9)
			{
				GameObject.Find("Timer").guiText.text = "Time: " + Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
			}
			else
			{
				GameObject.Find("Timer").guiText.text = "Time: " + Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
			}
		}
		else
		{
			Minutes = Minutes * Time.deltaTime;
			Seconds = Seconds * Time.deltaTime;
		}

		if(Application.loadedLevel == 5 && wins.GameWon == true)
		{
			transform.position = new Vector3(0.2050778f,0.8230979f,0f);
		}


		if(Application.loadedLevel == 3 || Application.loadedLevel == 4 || Application.loadedLevel == 5)
		{
			DontDestroyOnLoad (guiText);
		}

		if(Application.loadedLevel == 0 || Application.loadedLevel == 1 || Application.loadedLevel == 6)
		{
			Destroy(this.gameObject);
		}
	}
}
