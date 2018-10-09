using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject player;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = new Vector3 (player.transform.position.x + offset.x, player.transform.position.y + offset.y, player.transform.position.z + offset.z);
		transform.position = position;
	}
}
