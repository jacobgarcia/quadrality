using UnityEngine;
using System.Collections;

public class AnimatorController : MonoBehaviour {
	public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetAxis ("Vertical") > 0.1) {
						animator.SetFloat ("Speed", 1);
				}
		
				if (Input.GetAxis ("Vertical") < 0.1 && Input.GetAxis ("Vertical") >= 0) {
						animator.SetFloat ("Speed", 0.0f);
				}

				if (Input.GetAxis ("Vertical") < 0) {
						animator.SetFloat ("Speed", 1);
				}

				if (Input.GetAxis ("Horizontal") > 0.1) {
						animator.SetFloat ("Speed", 1);
				}
		
				if (Input.GetAxis ("Horizontal") < 0) {
						animator.SetFloat ("Speed", 1);
				}
				
				if (Input.GetButtonDown ("Action") && OpenGate.action ) {
					animator.SetBool ("Act", true);
				}
				else {
					animator.SetBool ("Act", false);
					OpenGate.action = false;
				}

		/* Knight */
		if (Input.GetButtonDown ("Action") && ChangePlayer.knight) {
			animator.SetBool ("Act", true);
		}
		else if (ChangePlayer.knight){
			animator.SetBool ("Act", false);
		}

		if (Input.GetButtonDown ("Jump") && Time.timeScale != 0) {
			animator.SetBool("Jump", true);
		}
		else
			animator.SetBool("Jump", false);
	}

	

}
