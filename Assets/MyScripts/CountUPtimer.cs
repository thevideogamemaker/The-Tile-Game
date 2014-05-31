using UnityEngine;
using System.Collections;

public class CountUPtimer : MonoBehaviour {

	public float Seconds = 59;
	public float Minutes = 0;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
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
}
