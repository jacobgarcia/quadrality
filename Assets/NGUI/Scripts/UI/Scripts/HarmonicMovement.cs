using UnityEngine;
using System.Collections;

public class HarmonicMovement : MonoBehaviour {
	public float speed = 1.0f;
	public float initialPosition = 0.0f;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time) * speed + initialPosition, transform.position.z);
	}
}
