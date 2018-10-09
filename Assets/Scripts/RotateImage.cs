using UnityEngine;
using System.Collections;

public class RotateImage : MonoBehaviour {
	public float rotationSpeed = 8f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 angle = transform.eulerAngles;
		angle.z -= rotationSpeed;
		transform.eulerAngles = angle;
	}
}
