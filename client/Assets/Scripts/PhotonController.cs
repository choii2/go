using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Photonに接続する
		PhotonNetwork.ConnectUsingSettings(null);
	}

	// ロビー入室時イベント
	void OnJoinedLobby() {
		Debug.Log("ロビーに入りました");

		PhotonRoomModel roomModel = new PhotonRoomModel();
		// ルームの作成もしくはジョイン
		PhotonNetwork.JoinOrCreateRoom(roomModel.roomName, roomModel.roomOptions, roomModel.typedLobby);
	}

	// ルーム作成時イベント
	void OnCreatedRoom() {
		Debug.Log("ルームを作成しました");
	}

	// ルームジョイン時イベント
	void OnJoinedRoom() {
		Debug.Log("ルームにジョインしました");

		// TODO 初期値マジックナンバー対応
		PhotonNetwork.Instantiate("SD_unitychan_humanoid", new Vector3(0, 0, 0), Quaternion.identity, 0);
		PhotonNetwork.Instantiate("target", new Vector3(20, 5, -2), Quaternion.identity, 0);
	}

	// 誰かがルームにジョイン時イベント
	void OnPhotonPlayerConnected(PhotonPlayer newPlayer) {
		Debug.Log("プレイヤー:"+ newPlayer.ID +"ルームに入室しました");
	}
}
