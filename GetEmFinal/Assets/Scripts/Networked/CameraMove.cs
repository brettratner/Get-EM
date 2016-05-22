using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CameraMove : NetworkBehaviour {
	
	public GameObject player;

	private Vector3 offset;

	void Start ()
	{
		// Set the initial camera position based on the difference between the 
		// Camera prefab location and the player prefab location.

		transform.position = player.transform.position + new Vector3(-0.12f, 12.46f, -4.07f);
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		

		transform.position = player.transform.position + offset;
	}



}