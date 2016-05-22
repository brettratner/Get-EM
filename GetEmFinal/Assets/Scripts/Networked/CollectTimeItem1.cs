using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.Networking;



public class CollectTimeItem1 : NetworkBehaviour {

	public AudioSource Audio;

	// Use this for initialization
	void Start () {
		Audio.Stop ();


	}



	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("clock")) {
			
				Destroy (col.gameObject);
				Timer.timer = Timer.timer - 5;
				Audio.Play ();



		}

	}


}
