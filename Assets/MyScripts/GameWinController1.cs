using UnityEngine;
using System.Collections;

public class GameWinController1 : MonoBehaviour {

	public bool GameWon = false;

	private one S1Texture;
	private two S2Texture;
	private three S3Texture;
	private four S4Texture;
	private five S5Texture;
	private six S6Texture;
	private seven S7Texture;
	private eight S8Texture;
	private nine S9Texture;
	private ten S10Texture;
	private eleven S11Texture;
	private twelve S12Texture;
	private thirteen S13Texture;
	private fourteen S14Texture;
	private fifteen S15Texture;
	
	void Start () 
	{
		S1Texture = GameObject.FindGameObjectWithTag("Space1").GetComponent<one>();
		S2Texture = GameObject.FindGameObjectWithTag("Space2").GetComponent<two>();
		S3Texture = GameObject.FindGameObjectWithTag("Space3").GetComponent<three>();
		S4Texture = GameObject.FindGameObjectWithTag("Space4").GetComponent<four>();
		S5Texture = GameObject.FindGameObjectWithTag("Space5").GetComponent<five>();
		S6Texture = GameObject.FindGameObjectWithTag("Space6").GetComponent<six>();
		S7Texture = GameObject.FindGameObjectWithTag("Space7").GetComponent<seven>();
		S8Texture = GameObject.FindGameObjectWithTag("Space8").GetComponent<eight>();
		S9Texture = GameObject.FindGameObjectWithTag("Space9").GetComponent<nine>();
		S10Texture = GameObject.FindGameObjectWithTag("Space10").GetComponent<ten>();
		S11Texture = GameObject.FindGameObjectWithTag("Space11").GetComponent<eleven>();
		S12Texture = GameObject.FindGameObjectWithTag("Space12").GetComponent<twelve>();
		S13Texture = GameObject.FindGameObjectWithTag("Space13").GetComponent<thirteen>();
		S14Texture = GameObject.FindGameObjectWithTag("Space14").GetComponent<fourteen>();
		S15Texture = GameObject.FindGameObjectWithTag("Space15").GetComponent<fifteen>();
	}

	void FixedUpdate ()
	{
		CheckIfWinning();
	}

	void CheckIfWinning () 
	{
		if(S1Texture.currentArraySpace == 1 && 
		   S2Texture.currentArraySpace == 1 && 
		   S3Texture.currentArraySpace == 1 && 
		   S4Texture.currentArraySpace == 1 && 
		   S5Texture.currentArraySpace == 1 && 
		   S6Texture.currentArraySpace == 1 && 
		   S7Texture.currentArraySpace == 1 &&
		   S8Texture.currentArraySpace == 1 &&
		   S9Texture.currentArraySpace == 1 &&
		   S10Texture.currentArraySpace == 1 &&
		   S11Texture.currentArraySpace == 1 &&
		   S12Texture.currentArraySpace == 1 &&
		   S13Texture.currentArraySpace == 1 &&
		   S14Texture.currentArraySpace == 1 &&
		   S15Texture.currentArraySpace == 1)
		{
			StartCoroutine (GameWinner ());
		}
		if(S1Texture.currentArraySpace == 2 && 
		   S2Texture.currentArraySpace == 2 && 
		   S3Texture.currentArraySpace == 2 && 
		   S4Texture.currentArraySpace == 2 && 
		   S5Texture.currentArraySpace == 2 && 
		   S6Texture.currentArraySpace == 2 && 
		   S7Texture.currentArraySpace == 2 &&
		   S8Texture.currentArraySpace == 2 &&
		   S9Texture.currentArraySpace == 2 &&
		   S10Texture.currentArraySpace == 2 &&
		   S11Texture.currentArraySpace == 2 &&
		   S12Texture.currentArraySpace == 2 &&
		   S13Texture.currentArraySpace == 2 &&
		   S14Texture.currentArraySpace == 2 &&
		   S15Texture.currentArraySpace == 2)
		{
			StartCoroutine (GameWinner ());
		}
		if(S1Texture.currentArraySpace == 3 && 
		   S2Texture.currentArraySpace == 3 && 
		   S3Texture.currentArraySpace == 3 && 
		   S4Texture.currentArraySpace == 3 && 
		   S5Texture.currentArraySpace == 3 && 
		   S6Texture.currentArraySpace == 3 && 
		   S7Texture.currentArraySpace == 3 &&
		   S8Texture.currentArraySpace == 3 &&
		   S9Texture.currentArraySpace == 3 &&
		   S10Texture.currentArraySpace == 3 &&
		   S11Texture.currentArraySpace == 3 &&
		   S12Texture.currentArraySpace == 3 &&
		   S13Texture.currentArraySpace == 3 &&
		   S14Texture.currentArraySpace == 3 &&
		   S15Texture.currentArraySpace == 3)
		{
			StartCoroutine (GameWinner ());
		}
		if(S1Texture.currentArraySpace == 4 && 
		   S2Texture.currentArraySpace == 4 && 
		   S3Texture.currentArraySpace == 4 && 
		   S4Texture.currentArraySpace == 4 && 
		   S5Texture.currentArraySpace == 4 && 
		   S6Texture.currentArraySpace == 4 && 
		   S7Texture.currentArraySpace == 4 &&
		   S8Texture.currentArraySpace == 4 &&
		   S9Texture.currentArraySpace == 4 &&
		   S10Texture.currentArraySpace == 4 &&
		   S11Texture.currentArraySpace == 4 &&
		   S12Texture.currentArraySpace == 4 &&
		   S13Texture.currentArraySpace == 4 &&
		   S14Texture.currentArraySpace == 4 &&
		   S15Texture.currentArraySpace == 4)
		{
			StartCoroutine (GameWinner ());
		}
		if(S1Texture.currentArraySpace == 5 && 
		   S2Texture.currentArraySpace == 5 && 
		   S3Texture.currentArraySpace == 5 && 
		   S4Texture.currentArraySpace == 5 && 
		   S5Texture.currentArraySpace == 5 && 
		   S6Texture.currentArraySpace == 5 && 
		   S7Texture.currentArraySpace == 5 &&
		   S8Texture.currentArraySpace == 5 &&
		   S9Texture.currentArraySpace == 5 &&
		   S10Texture.currentArraySpace == 5 &&
		   S11Texture.currentArraySpace == 5 &&
		   S12Texture.currentArraySpace == 5 &&
		   S13Texture.currentArraySpace == 5 &&
		   S14Texture.currentArraySpace == 5 &&
		   S15Texture.currentArraySpace == 5)
		{
			StartCoroutine (GameWinner ());
		}
		if(S1Texture.currentArraySpace == 6 && 
		   S2Texture.currentArraySpace == 6 && 
		   S3Texture.currentArraySpace == 6 && 
		   S4Texture.currentArraySpace == 6 && 
		   S5Texture.currentArraySpace == 6 && 
		   S6Texture.currentArraySpace == 6 && 
		   S7Texture.currentArraySpace == 6 &&
		   S8Texture.currentArraySpace == 6 &&
		   S9Texture.currentArraySpace == 6 &&
		   S10Texture.currentArraySpace == 6 &&
		   S11Texture.currentArraySpace == 6 &&
		   S12Texture.currentArraySpace == 6 &&
		   S13Texture.currentArraySpace == 6 &&
		   S14Texture.currentArraySpace == 6 &&
		   S15Texture.currentArraySpace == 6)
		{
			StartCoroutine (GameWinner ());
		}
		if(S1Texture.currentArraySpace == 7 && 
		   S2Texture.currentArraySpace == 7 && 
		   S3Texture.currentArraySpace == 7 && 
		   S4Texture.currentArraySpace == 7 && 
		   S5Texture.currentArraySpace == 7 && 
		   S6Texture.currentArraySpace == 7 && 
		   S7Texture.currentArraySpace == 7 &&
		   S8Texture.currentArraySpace == 7 &&
		   S9Texture.currentArraySpace == 7 &&
		   S10Texture.currentArraySpace == 7 &&
		   S11Texture.currentArraySpace == 7 &&
		   S12Texture.currentArraySpace == 7 &&
		   S13Texture.currentArraySpace == 7 &&
		   S14Texture.currentArraySpace == 7 &&
		   S15Texture.currentArraySpace == 7)
		{
			StartCoroutine (GameWinner ());
		}
		if(S1Texture.currentArraySpace == 8 && 
		    S2Texture.currentArraySpace == 8 && 
		    S3Texture.currentArraySpace == 8 && 
		    S4Texture.currentArraySpace == 8 && 
		    S5Texture.currentArraySpace == 8 && 
		    S6Texture.currentArraySpace == 8 && 
		    S7Texture.currentArraySpace == 8 &&
		    S8Texture.currentArraySpace == 8 &&
		    S9Texture.currentArraySpace == 8 &&
		    S10Texture.currentArraySpace == 8 &&
		    S11Texture.currentArraySpace == 8 &&
		    S12Texture.currentArraySpace == 8 &&
		    S13Texture.currentArraySpace == 8 &&
		    S14Texture.currentArraySpace == 8 &&
		    S15Texture.currentArraySpace == 8)
		{
			StartCoroutine (GameWinner ());
		}
		if(S1Texture.currentArraySpace == 9 && 
		   S2Texture.currentArraySpace == 9 && 
		   S3Texture.currentArraySpace == 9 && 
		   S4Texture.currentArraySpace == 9 && 
		   S5Texture.currentArraySpace == 9 && 
		   S6Texture.currentArraySpace == 9 && 
		   S7Texture.currentArraySpace == 9 &&
		   S8Texture.currentArraySpace == 9 &&
		   S9Texture.currentArraySpace == 9 &&
		   S10Texture.currentArraySpace == 9 &&
		   S11Texture.currentArraySpace == 9 &&
		   S12Texture.currentArraySpace == 9 &&
		   S13Texture.currentArraySpace == 9 &&
		   S14Texture.currentArraySpace == 9 &&
		   S15Texture.currentArraySpace == 9)
		{
			StartCoroutine (GameWinner ());
		}
	}

	IEnumerator GameWinner ()
	{
		GameWon = true;
		yield return new WaitForSeconds(1.45f);
		Application.LoadLevel("GameWon");
	}
}
