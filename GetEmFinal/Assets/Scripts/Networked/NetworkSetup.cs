using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkSetup : NetworkManager {

	public Vector3 player1Pos;
	public Vector3 player2Pos;
	public Vector3 player3Pos;
	public Vector3 player4Pos;
	private GameObject player;


	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId){
		if (conn.connectionId == 0) {
			Debug.Log (conn);
			//assing first position
			player = (GameObject)GameObject.Instantiate (playerPrefab, player1Pos, Quaternion.identity);
			player.GetComponent<PlayerMove> ().color = Color.blue;
			PlayerMove.rend.material.shader = Shader.Find("Specular");
			PlayerMove.rend.material.SetColor("_SpecColor", Color.red);
			player.GetComponent<PlayerMove> ().speed = 30f;
		} else if (conn.connectionId == 1) {
			Debug.Log (conn);
			player.GetComponent<PlayerMove> ().color = Color.red;
			player = (GameObject)GameObject.Instantiate (playerPrefab, player2Pos, Quaternion.identity);
			player.GetComponent<PlayerMove> ().speed = 25f;
			Debug.Log ("The First Client Connected");
		} 
		else if (conn.connectionId == 2) {
			Debug.Log (conn);
			player.GetComponent<PlayerMove> ().color = Color.yellow;
			player = (GameObject)GameObject.Instantiate (playerPrefab, player3Pos, Quaternion.identity);
			player.GetComponent<PlayerMove> ().speed = 25f;
			Debug.Log ("The Second Client Connected");
		} 
		else if (conn.connectionId == 3) {
			Debug.Log (conn);
			//player.GetComponent<PlayerMove> ().color = PlayerMove.orange;
			player.GetComponent<PlayerMove> ().color = Color.green;
			player = (GameObject)GameObject.Instantiate (playerPrefab, player4Pos, Quaternion.identity);
			player.GetComponent<PlayerMove> ().speed = 25f;
			Debug.Log ("The Third Client Connected");
		}

		NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
	}
}

