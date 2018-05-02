using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ルームに関する情報を保持するモデルクラス
public class PhotonRoomModel : MonoBehaviour {

	private const string defaultRoomName = "test";

	// ルーム名
	public string roomName { get; private set; }
	// ルームオプション
	public RoomOptions roomOptions { get; private set; }
	// どのロビーに作るか
	public TypedLobby typedLobby { get; private set; }

	public PhotonRoomModel() {
		this.roomName = defaultRoomName;
		this.roomOptions = new RoomOptions();
		this.typedLobby = new TypedLobby();
	}

}
