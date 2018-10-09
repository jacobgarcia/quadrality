using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public GameObject player;
	public float fuerza = 1f;
	// Use this for initialization
	void Start () {
		Invoke ("BallMove", 10.0f);
		Invoke ("Audio", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//Invoke ("EditForce",10.0f);
		//Vector3 position = new Vector3 (player.
		 
	}

	void BallMove(){

		GetComponent<Rigidbody>().AddForce (new Vector3(0,0,fuerza), ForceMode.Impulse);

		Invoke ("BallMove", 12.0f);
	}

	void EditForce(){
		fuerza= fuerza-0.2f; ;
	}

	void OnTriggerEnter(Collider c){
		if(c.gameObject.tag == "Wall"){
			Destroy(c.gameObject);
		}
		if(c.gameObject.tag == "Puente"){
			GetComponent<Rigidbody>().AddForce (new Vector3(0,0,100), ForceMode.Impulse);
		}
		if(c.gameObject.tag =="Player"){
			Debug.Log("Te alcance");
			Application.LoadLevel (6);
		}
	}

	void Audio(){
		GetComponent<AudioSource>().Play ();
	}

}
