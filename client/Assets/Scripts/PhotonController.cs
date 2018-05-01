using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Photonに接続する
		PhotonNetwork.ConnectUsingSettings(null);
	}

	// ロビーに入ると呼ばれる
	void OnJoinedLobby() {
		Debug.Log("ロビーに入りました");
	}

}
