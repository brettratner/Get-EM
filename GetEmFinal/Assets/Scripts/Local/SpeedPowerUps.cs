using UnityEngine;
using System.Collections;

public class SpeedPowerUps : MonoBehaviour {


	public float speed = 35;
	public float myplayerOGSpeed = 21;
	public float otherplayerOGSpeed = 21;
	public float antispeed = 13;


	public float speedTimeout1 = 10;
	public float speedTimeout2 = 10;
	public float speedTimeout3 = 10;
	public float speedTimeout4 = 10;
	public float speedTimeout5 = 10;


	public bool starGotten1 = false;
	public bool starGotten2 = false;
	public bool starGotten3 = false;
	public bool antistarGotten4 = false;
	public bool antistarGotten5 = false;
	public GameObject star;
	public GameObject star2;
	public GameObject star3;
	public GameObject antistar4;
	public GameObject antistar5;


	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		star.SetActive (true);
		star2.SetActive (true);
		star3.SetActive (true);
		antistar4.SetActive (true);
		antistar5.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		if (starGotten1 == true) {
			
			speedTimeout1 -= Time.deltaTime;
			Debug.Log ("timeout is: " + speedTimeout1);
			if(speedTimeout1 < 0)
			{
				starGotten1 = false;
				star.SetActive (true);
				speedTimeout1 = 10;
				Debug.Log ("Star 1 is set to OG ");
				movePlayer.speed = myplayerOGSpeed;
			}
		}
		if (starGotten2 == true) {
			speedTimeout2 -= Time.deltaTime;
			if(speedTimeout2 < 0)
			{
				starGotten2 = false;
				star2.SetActive (true);
				speedTimeout2 = 10;
				Debug.Log ("Star 2 is set to OG ");
				movePlayer.speed = myplayerOGSpeed;
			}
		}
		if (starGotten3 == true) {
			speedTimeout3 -= Time.deltaTime;
			if(speedTimeout3 < 0)
			{
				starGotten3 = false;
				star3.SetActive (true);
				speedTimeout3 = 10;
				Debug.Log ("Star 3 is set to OG ");
				movePlayer.speed = myplayerOGSpeed;
			}
		}
		if (antistarGotten4 == true) {
			speedTimeout4 -= Time.deltaTime;
			if(speedTimeout4 < 0)
			{
				antistarGotten4 = false;
				antistar4.SetActive (true);
				speedTimeout4 = 10;
				Debug.Log ("AnitStar 4 is set to OG ");
				movePlayer2.speed = otherplayerOGSpeed;
			}
		}
		if (antistarGotten5 == true) {
			speedTimeout5 -= Time.deltaTime;
			if(speedTimeout5 < 0)
			{
				antistarGotten5 = false;
				antistar5.SetActive (true);
				speedTimeout5 = 10;
				Debug.Log ("AnitStar 5 is set to OG ");

				movePlayer2.speed = otherplayerOGSpeed;
			}
		}
			
	


	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("star")) {
			starGotten1 = true;
			star.SetActive (false);

			movePlayer.speed = speed;

		}
		if (col.gameObject.tag == ("star2")) {
			starGotten2 = true;
			star2.SetActive (false);

			movePlayer.speed = speed;

		}if (col.gameObject.tag == ("star3")) {
			starGotten3 = true;
			star3.SetActive (false);

			movePlayer.speed = speed;

		}if (col.gameObject.tag == ("antistar4")) {
			antistarGotten4 = true;
			antistar4.SetActive (false);

			movePlayer2.speed = antispeed;

		}if (col.gameObject.tag == ("antistar5")) {
			antistarGotten5 = true;
			antistar5.SetActive (false);

			movePlayer2.speed = antispeed;

		}
	
	}

}
