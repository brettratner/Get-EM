using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Networking;


public class Timer : NetworkBehaviour {
	
	public static float timer = 120;

	public Text TimeLeft;
	public Text player1Wins;
	public Text player2Wins;
	public AudioSource backgroundMusic;
	public GameObject MiniGameCamera;

	void Start(){

		Time.timeScale = 1;
		player1Wins.enabled = false;
		player2Wins.enabled = false;
		backgroundMusic.playOnAwake= true;

	}

	// Update is called once per frame
	void Update () {
//		Debug.Log("HelloTimmer");
		backgroundMusic.loop = true;
		timer -= Time.deltaTime;
	
	}
	void OnGUI(){
		TimeLeft.text = "" + (int)timer;

		if(timer > 0 && movePlayer2.winner2 == true)
		{
			Player2Win();
		}
		else if(timer <= 0){
			Player1Win ();
		}

	}

	public void Player1Win(){
		Time.timeScale = 0;
		player1Wins.text = "Blue Player Wins";
		player1Wins.enabled = true;


	}
	public void Player2Win(){
		Time.timeScale = 0;
		player2Wins.text = "Red Team Wins";
		player2Wins.enabled = true;
	

	}
}
