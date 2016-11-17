using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Connect();
    }

    void Connect()
    {
        PhotonNetwork.ConnectUsingSettings("v.0.1");
    }

    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    
    void OnPhotonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom("Room Alpha");
    }

    void onJoinedRoom()
    {

    }
}
