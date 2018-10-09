using UnityEngine;
using System.Collections;

public class SecretColliderTwo : MonoBehaviour {
	public static bool third = false;

	void Start(){
		GetComponent<Collider>().enabled = false;
	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			if(!third && ChangePlayer.bolita){
				third = true;
				Debug.Log ("Third Is Ready");
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (SecretColliderOne.second) {
			GetComponent<Collider>().enabled = true;
		}
	}
}
