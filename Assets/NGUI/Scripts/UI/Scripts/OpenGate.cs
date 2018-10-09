using UnityEngine;
using System.Collections;

public class OpenGate : MonoBehaviour {
	public GameObject gate;
	private bool open = false;
	public float speed = 1.0f;
	public GameObject lever;
	private bool activate = false;
	public AudioClip leverClip;
	public AudioClip gateClip;
	public static bool action;

	void OnTriggerStay(Collider c){
		if (c.gameObject.tag == "Player") {
			if(Input.GetButtonDown ("Action") && !open && ChangePlayer.scientist){
				action = true;
				open = true;
				Gate ();
				lever.GetComponent<Animation> ().Play ("Activate Lever");
				GetComponent<AudioSource> ().clip = leverClip;
				GetComponent<AudioSource> ().Play ();
			}
		}
	}

	void Update(){
		if (gate != null) {
			if (open && gate.transform.position.y < 7.0f)
				gate.transform.position += new Vector3 (0f, Time.deltaTime * speed, 0f);
		}
	}

	void Gate(){
		gate.GetComponent<AudioSource> ().clip = gateClip;
		gate.GetComponent<AudioSource> ().Play ();
	}

}
