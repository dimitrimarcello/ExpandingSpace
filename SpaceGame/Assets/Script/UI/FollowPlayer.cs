using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
	void Update () {
        transform.position = new Vector3(player.position.x + 3, 0, -10);
	}
}
