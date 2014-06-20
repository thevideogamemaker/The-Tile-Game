using UnityEngine;
using System.Collections;

public class VolumeToggle : MonoBehaviour {

	public bool IsMuted = false;
	public Material[] soundToggle;

	void Update () 
	{
		if(Time.timeScale == 1){
			transform.position = new Vector3 (5.79845f, -3.960747f, 0.9682488f);
		}
		else{
			transform.position = new Vector3(1.440753f,-2.588783f,0.9682488f);
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
