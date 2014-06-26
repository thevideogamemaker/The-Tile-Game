using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms.GameCenter;

public class GameCenter : MonoBehaviour {
	
	void OnTouchDown ()
	{
		Social.ShowLeaderboardUI();
	}
}
