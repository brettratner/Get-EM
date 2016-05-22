using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{

	[SerializeField]
	private GameObject _cameraPrefab = null; // camera prefab
	private GameObject cameraObj;

	[SyncVar]
	public Color color;
	public float speed;
	private Rigidbody rb;
	public static Color orange = new Color(1F, 0.8F, 0F);
	static public Renderer rend;

	void Start() {
		if (!isLocalPlayer) {
			return;
			}
		if (color != null) {
			GetComponent<MeshRenderer> ().material.color = color;

		}
		cameraObj = GameObject.Instantiate(_cameraPrefab); // add camera
		rend = GetComponent<Renderer> ();
		rend.material.shader = Shader.Find("Specular");
		rend.material.SetColor("_SpecColor", Color.red);
		cameraObj.GetComponent<CameraMove> ().player = gameObject;
		//Debug.Log (Camera.main.GetComponent<CameraMove>().player);
		rb = GetComponent<Rigidbody> ();
	}

//	public override void OnStartLocalPlayer()
//	{
//		GetComponent<MeshRenderer>().material.color = Color.red;
//	}


	void Update()
	{
		if (!isLocalPlayer) {
				// Check to see if the non-local player’s camera is enabled and, if so, disable it
			if (cameraObj.GetComponent<Camera>().enabled == true) {
				cameraObj.GetComponent<Camera>().enabled = false;
			}
			return;
		}
		if (color != null) {
			GetComponent<MeshRenderer> ().material.color = color;
		}

		float moveHorizontal = Input.GetAxis ("Horizontal2");

		float moveVertical = Input.GetAxis ("Vertical2");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}


}