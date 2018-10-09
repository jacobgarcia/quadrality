using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider c){

		if(c.gameObject.tag =="Player"){
			Debug.Log("Murio");
			Application.LoadLevel (6);
		}
	}
}
