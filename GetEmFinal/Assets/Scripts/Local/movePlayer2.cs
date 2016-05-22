using UnityEngine;
using System.Collections;

public class movePlayer2 : MonoBehaviour {

	public static float speed;
	public static bool winner2;
	public  float speedchange;


	private Rigidbody rb;

	void Start ()
	{
		speed = 21;
		winner2 = false;
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{

		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
		speedchange = speed;

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