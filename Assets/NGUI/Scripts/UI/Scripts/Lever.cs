using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {
	public GameObject lever;
	private bool activate = false;
	public AudioClip leverClip;

	void OnTriggerStay(){

		if (Input.GetButtonDown ("Action") && !activate) {
	
			activate = true;
		}
	}
}
