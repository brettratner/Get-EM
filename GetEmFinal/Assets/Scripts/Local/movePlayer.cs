using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	[SerializeField]
	public static float speed;
	public  float speedchange;
	private Rigidbody rb;


	public Color color;
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		speed = 21;
	}



	void Update ()
	{


		float moveHorizontal = Input.GetAxis ("Horizontal2");

		float moveVertical = Input.GetAxis ("Vertical2");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
		speedchange = speed;
	}


}