using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	public GameObject player;
	public static float posX, posY, posZ;
	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			posX = player.transform.position.x;
			posY = player.transform.position.y;
			posZ = player.transform.position.z;
		}

	}
}
