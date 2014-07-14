using UnityEngine;
using System.Collections;

public class TimeChallengeTimer : MonoBehaviour {

	private GameWinController1 wins;

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
		if(Seconds <= 0)
		{
			Seconds = 59;
			if(Minutes >= 1)
			{
				Minutes--;
			}
			else
			{
				Minutes = 0;
				Seconds = 0;
				GameObject.Find("Timer").guiText.text = "Time: " + Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
			}
		}
		else
		{
			Seconds -= Time.deltaTime;
		}

		if(Mathf.Round(Seconds) <= 9)
		{
			GameObject.Find("Timer").guiText.text = "Time: " + Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
		}
		else
		{
			GameObject.Find("Timer").guiText.text = "Time: " + Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
		}
		}

		if(Minutes < 1 && Seconds < 1)
		{
			StartCoroutine (GameEnder ());
		}

		if(Application.loadedLevel == 4)
		{
			transform.position = new Vector3(0.2050778f,0.8230979f,0f);
		}

		if(Application.loadedLevel == 3 || Application.loadedLevel == 4)
		{
			DontDestroyOnLoad (guiText);
		}
		
		if(Application.loadedLevel == 0 || Application.loadedLevel == 1 || Application.loadedLevel == 2 || Application.loadedLevel == 5) 
		{
			Destroy(this.gameObject);
		}
	}

	IEnumerator GameEnder ()
	{
		yield return new WaitForSeconds(0.5f);
		Application.LoadLevel("GameOver");
	}
}
