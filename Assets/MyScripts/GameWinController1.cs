using UnityEngine;
using System.Collections;

public class GameWinController1 : MonoBehaviour {

	private Space1 S1Texture;
	private Space2 S2Texture;
	private Space3 S3Texture;
	private Space4 S4Texture;
	private Space5 S5Texture;
	private Space6 S6Texture;
	private Space7 S7Texture;
	private Space8 S8Texture;
	private Space9 S9Texture;
	private Space10 S10Texture;
	private Space11 S11Texture;
	private Space12 S12Texture;
	private Space13 S13Texture;
	private Space14 S14Texture;
	private Space15 S15Texture;
	private Space16 S16Texture;
	private Space17 S17Texture;
	private Space18 S18Texture;
	private Space19 S19Texture;
	//private Space20 S20Texture;

	// Use this for initialization
	void Start () 
	{
		S1Texture = GameObject.FindGameObjectWithTag("Space1").GetComponent<Space1>();
		S2Texture = GameObject.FindGameObjectWithTag("Space2").GetComponent<Space2>();
		S3Texture = GameObject.FindGameObjectWithTag("Space3").GetComponent<Space3>();
		S4Texture = GameObject.FindGameObjectWithTag("Space4").GetComponent<Space4>();
		S5Texture = GameObject.FindGameObjectWithTag("Space5").GetComponent<Space5>();
		S6Texture = GameObject.FindGameObjectWithTag("Space6").GetComponent<Space6>();
		S7Texture = GameObject.FindGameObjectWithTag("Space7").GetComponent<Space7>();
		S8Texture = GameObject.FindGameObjectWithTag("Space8").GetComponent<Space8>();
		S9Texture = GameObject.FindGameObjectWithTag("Space9").GetComponent<Space9>();
		S10Texture = GameObject.FindGameObjectWithTag("Space10").GetComponent<Space10>();
		S11Texture = GameObject.FindGameObjectWithTag("Space11").GetComponent<Space11>();
		S12Texture = GameObject.FindGameObjectWithTag("Space12").GetComponent<Space12>();
		S13Texture = GameObject.FindGameObjectWithTag("Space13").GetComponent<Space13>();
		S14Texture = GameObject.FindGameObjectWithTag("Space14").GetComponent<Space14>();
		S15Texture = GameObject.FindGameObjectWithTag("Space15").GetComponent<Space15>();
		S16Texture = GameObject.FindGameObjectWithTag("Space16").GetComponent<Space16>();
		S17Texture = GameObject.FindGameObjectWithTag("Space17").GetComponent<Space17>();
		S18Texture = GameObject.FindGameObjectWithTag("Space18").GetComponent<Space18>();
		S19Texture = GameObject.FindGameObjectWithTag("Space19").GetComponent<Space19>();
		//S20Texture = GameObject.FindGameObjectWithTag("Space20").GetComponent<Space20>();
	}
	
	// Update is called once per frame
	void Update () 
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
		   S15Texture.currentArraySpace == 1 &&
		   S16Texture.currentArraySpace == 1 &&
		   S17Texture.currentArraySpace == 1 &&
		   S18Texture.currentArraySpace == 1 &&
		   S19Texture.currentArraySpace == 1)
		   //S20Texture.currentArraySpace == 1)
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
		   S15Texture.currentArraySpace == 2 &&
		   S16Texture.currentArraySpace == 2 &&
		   S17Texture.currentArraySpace == 2 &&
		   S18Texture.currentArraySpace == 2 &&
		   S19Texture.currentArraySpace == 2)
		   //S20Texture.currentArraySpace == 2)
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
		   S15Texture.currentArraySpace == 3 &&
		   S16Texture.currentArraySpace == 3 &&
		   S17Texture.currentArraySpace == 3 &&
		   S18Texture.currentArraySpace == 3 &&
		   S19Texture.currentArraySpace == 3)
		   //S20Texture.currentArraySpace == 3)
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
		   S15Texture.currentArraySpace == 4 &&
		   S16Texture.currentArraySpace == 4 &&
		   S17Texture.currentArraySpace == 4 &&
		   S18Texture.currentArraySpace == 4 &&
		   S19Texture.currentArraySpace == 4)
		   //S20Texture.currentArraySpace == 4)
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
		   S15Texture.currentArraySpace == 5 &&
		   S16Texture.currentArraySpace == 5 &&
		   S17Texture.currentArraySpace == 5 &&
		   S18Texture.currentArraySpace == 5 &&
		   S19Texture.currentArraySpace == 5)
		  // S20Texture.currentArraySpace == 5)
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
		   S15Texture.currentArraySpace == 6 &&
		   S16Texture.currentArraySpace == 6 &&
		   S17Texture.currentArraySpace == 6 &&
		   S18Texture.currentArraySpace == 6 &&
		   S19Texture.currentArraySpace == 6)
		   //S20Texture.currentArraySpace == 6)
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
		   S15Texture.currentArraySpace == 7 &&
		   S16Texture.currentArraySpace == 7 &&
		   S17Texture.currentArraySpace == 7 &&
		   S18Texture.currentArraySpace == 7 &&
		   S19Texture.currentArraySpace == 7)
		   //S20Texture.currentArraySpace == 7)
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
		    S15Texture.currentArraySpace == 8 &&
		    S16Texture.currentArraySpace == 8 &&
		    S17Texture.currentArraySpace == 8 &&
		    S18Texture.currentArraySpace == 8 &&
		    S19Texture.currentArraySpace == 8)
		   // S20Texture.currentArraySpace == 8)
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
		   S15Texture.currentArraySpace == 9 &&
		   S16Texture.currentArraySpace == 9 &&
		   S17Texture.currentArraySpace == 9 &&
		   S18Texture.currentArraySpace == 9 &&
		   S19Texture.currentArraySpace == 9)
		   //S20Texture.currentArraySpace == 9)
		{
			StartCoroutine (GameWinner ());
		}
	}

	IEnumerator GameWinner ()
	{
		yield return new WaitForSeconds(1.45f);
		Application.LoadLevel("GameWon");
	}
}
