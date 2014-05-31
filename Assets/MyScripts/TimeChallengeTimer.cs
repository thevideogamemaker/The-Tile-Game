using UnityEngine;
using System.Collections;

public class TimeChallengeTimer : MonoBehaviour {

	public float Seconds = 59;
	public float Minutes = 0;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
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

		if(Minutes < 1 && Seconds < 1)
		{
			StartCoroutine (GameEnder ());
		}

	}

	IEnumerator GameEnder ()
	{
		yield return new WaitForSeconds(2f);
		Application.LoadLevel("GameOver");
	}
}
