using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {
	public float speed = 1.0f;
	public float initialPosition = 0.0f;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Sin(Time.time) * speed + initialPosition);
	}
}
