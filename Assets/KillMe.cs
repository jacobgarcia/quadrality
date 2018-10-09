using UnityEngine;
using System.Collections;

public class KillMe : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player")
			Application.LoadLevel (5);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
