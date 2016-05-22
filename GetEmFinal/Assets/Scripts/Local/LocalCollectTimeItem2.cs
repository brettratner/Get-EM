using UnityEngine;
using System.Collections;

public class LocalCollectTimeItem2 : MonoBehaviour {

	public AudioSource Audio;
	public AudioSource Audio2;
	public AudioSource Audio3;

	// Use this for initialization
	void Start () {
		Audio.Stop ();
		Audio2.Stop ();
		Audio3.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void Explode() {
//		var exp = GetComponent<ParticleSystem>();
//		exp.Play();
//		Destroy(gameObject, exp.duration);
//	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("clock")) {
			Destroy (col.gameObject);
//			Explode();
			LocalTimer.timer = LocalTimer.timer + 10;
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
