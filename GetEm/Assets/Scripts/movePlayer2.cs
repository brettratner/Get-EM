using UnityEngine;
using System.Collections;

public class movePlayer2 : MonoBehaviour {

	public float speed;
	public static bool winner2;

	private Rigidbody rb;

	void Start ()
	{
		winner2 = false;
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{

		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Player")
		{
			Destroy(col.gameObject);
			winner2 = true;

		}
	}


}