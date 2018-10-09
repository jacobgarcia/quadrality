using UnityEngine;
using System.Collections;

public class JumpingEffect : MonoBehaviour {

	private CharacterController controller;
	public AudioClip jump;

	void Start(){
		controller = GetComponent<CharacterController> ();

	}
	
	// Use this for initialization
	void JumpingNow () {
			GetComponent<AudioSource> ().clip = jump;
			GetComponent<AudioSource> ().Play ();
	}

}
