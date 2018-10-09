using UnityEngine;
using System.Collections;

public class SecretColliderOne : MonoBehaviour {
	public static bool second = false;

	void Start(){
		GetComponent<Collider>().enabled = false;
	}

	void OnTriggerStay(Collider c){
		if (c.gameObject.tag == "Player") {
			if(Input.GetButtonDown ("Action") && !second && ChangePlayer.knight){
				second = true;
				Debug.Log ("Second Is Ready");
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (!GetComponent<Collider>().enabled) {
			if (SecretLever.first) {
				GetComponent<Collider>().enabled = true;
			}
		}
	}
}
