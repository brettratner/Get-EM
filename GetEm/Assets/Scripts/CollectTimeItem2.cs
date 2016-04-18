using UnityEngine;
using System.Collections;

public class CollectTimeItem2 : MonoBehaviour {

	public AudioSource Audio;
	public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
		Audio.Stop ();
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
			Timer.timer = Timer.timer + 10;
			Audio.Play ();



		}

	}
}
