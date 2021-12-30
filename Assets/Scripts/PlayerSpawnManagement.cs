using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class PlayerSpawnManagement : MonoBehaviourPunCallbacks
{
    private GameObject spawnPlayerPrefabs;

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);

    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnPlayerPrefabs);
    }
}
