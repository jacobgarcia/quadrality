using UnityEngine;
using System.Collections;

public class Appear1 : MonoBehaviour {
	public UISprite message;

	// Use this for initialization
	void OnTriggerStay (Collider c) {
		if (c.gameObject.tag == "Player") {
			message.enabled = true;
			Invoke ("DestroyMe", 2.0f);
		}
	}

	void DestroyMe(){
		this.GetComponent<Collider>().enabled = false;
	}
}
