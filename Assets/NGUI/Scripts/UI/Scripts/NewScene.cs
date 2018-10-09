using UnityEngine;
using System.Collections;

public class NewScene : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(){
		Application.LoadLevel (2);
	}
}
