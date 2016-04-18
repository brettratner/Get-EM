using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class Timer : MonoBehaviour {
	public static float timer = 120;
	//public bool restart = false;
	//public bool isGameOver = false;
	public Text TimeLeft;
	public Text player1Wins;
	public Text player2Wins;
	public Text distanceToPlayer;
	public GameObject toPlayer1;
	public GameObject toPlayer2;
	//public Text RestartText;
	public Color blueColor = new Color(0.0F, 0.0F, 255.0F, 0.0F);
	public Color redColor = new Color (255.0F, 0.0F, 0.0F, 0.0F);
	public float dist;
	public AudioSource backgroundMusic;


	public GameObject MiniGameCamera;


	void Start(){
		//restart = false;
		//PlayerOutOfBounds.isGameOver = false;
		Time.timeScale = 1;
//		TimeLeft.text = "";
		player1Wins.enabled = false;
		player2Wins.enabled = false;
//		player1Wins.text = "";
//		player2Wins.text = "";
		backgroundMusic.playOnAwake= true;
		//RestartText.text = "";
	}

	void FixedUpdate(){
		//Debug.Log (isGameOver);

	}
	// Update is called once per frame
	void Update () {
		backgroundMusic.loop = true;
		timer -= Time.deltaTime;
		dist = Vector3.Distance(toPlayer2.transform.position , toPlayer1.transform.position);
		//Debug.Log ("the distance is : " + dist);
		/*if (restart) {


			if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.R)  ) {
			MiniGameCamera.transform.position = new Vector3 (0, 3f, 0);
				timer = 100;
			
			if (MiniGameCamera.transform.position.z == 0) {

					Application.LoadLevel (Application.loadedLevel);
				}

				//SceneManager.LoadSence();
			}
		} */
	
	}




	void OnGUI(){
		TimeLeft.text = "" + (int)timer;
		distanceToPlayer.text = "Distance: " + (int)dist;

		if(timer > 0 && movePlayer2.winner2 == true)
		{
			Player2Win();
		}
		else if(timer <= 0){
			Player1Win ();
		}

	}


	public void Player1Win(){
	//	GUI.Label(new Rect(50,50,500,300), "Game Over");
		//restart = true;
		Time.timeScale = 0;
		player1Wins.text = "Blue Player Wins";
		player1Wins.enabled = true;
		//RestartText.text = "Press Spacebar or the 'R' Button to Restart";
		TimeLeft.CrossFadeColor (blueColor, 10.0f, true, true);
		player1Wins.CrossFadeColor(blueColor, 10.0f, true, false);
     	//RestartText.CrossFadeColor(color, 5.0f, true, true);

	}
	public void Player2Win(){
		//	GUI.Label(new Rect(50,50,500,300), "Game Over");
		//restart = true;
		Time.timeScale = 0;
		player2Wins.text = "Red Player Wins";
		player2Wins.enabled = true;
		//RestartText.text = "Press Spacebar or the 'R' Button to Restart";
		TimeLeft.CrossFadeColor (redColor, 10.0f, true, true);
		player2Wins.CrossFadeColor(redColor, 10.0f, true, false);
		//RestartText.CrossFadeColor(color, 5.0f, true, true);

	}


}
