using UnityEngine;
using System.Collections;

public class VolumeToggle : MonoBehaviour {

	public bool IsMuted = false;
	public Material[] soundToggle;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.timeScale == 1){
			transform.position = new Vector3 (5.79845f, -3.960747f, 0.9682488f);
		}
		else{
			transform.position = new Vector3(1.570363f,-3.960747f,0.9682488f);
		}
	}

	void OnMouseUp()
	{
		if(IsMuted == false)
		{
			IsMuted = true;
			renderer.material = soundToggle[0];
		}
		else
		{
			IsMuted = false;
			renderer.material = soundToggle[1];
		}
	}
}
