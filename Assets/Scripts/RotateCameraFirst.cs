using UnityEngine;
using System.Collections;

public class RotateCameraFirst : MonoBehaviour {

	// Use this for initialization
	void Update () {
		Vector3 angle = new Vector3 (0, 4, -75);
		
		transform.position = angle;
	}
}
