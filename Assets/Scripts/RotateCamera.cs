using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Vector3 angle = new Vector3 (25, -180, 0);
		
		transform.eulerAngles = angle;
	}
}
