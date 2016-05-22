using UnityEngine;
using System.Collections;
using UnityEngine.Audio;


public class LocalCollectTimeItem1 : MonoBehaviour {

	public AudioSource Audio;
	public AudioSource Audio2;
	public AudioSource Audio3;


	// Use this for initialization
	void Start () {
		Audio.Stop ();
		Audio2.Stop ();
		Audio3.Stop ();


	}



	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("clock")) {
			
				Destroy (col.gameObject);
				LocalTimer.timer = LocalTimer.timer - 5;
				Audio.Play ();



		}
		if (col.gameObject.tag == ("star")) {

			Audio2.Play ();

		}
		if (col.gameObject.tag == ("star2")) {

			Audio2.Play ();

		}
		if (col.gameObject.tag == ("star3")) {

			Audio2.Play ();

		}
		if (col.gameObject.tag == ("antistar4")) {

			Audio2.Play ();

		}
		if (col.gameObject.tag == ("antistar5")) {

			Audio2.Play ();

		}
		if (col.gameObject.tag == ("switch1")) {

			Audio3.Play ();

		}
		if (col.gameObject.tag == ("switch2")) {

			Audio3.Play ();

		}
		if (col.gameObject.tag == ("switch3")) {

			Audio3.Play ();

		}
		if (col.gameObject.tag == ("switch4")) {

			Audio3.Play ();

		}
	}


}
