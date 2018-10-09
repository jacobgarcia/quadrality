using UnityEngine;
using System.Collections;

public class SecretLever : MonoBehaviour {
	private bool open = false;
	public GameObject lever;
	private bool activate = false;
	public AudioClip leverClip;
	public static bool first = false;
	public GameObject wall;
	
	void OnTriggerStay(Collider c){
		if (c.gameObject.tag == "Player") {
			if(Input.GetButtonDown ("Action") && !open && ChangePlayer.scientist){
				first = true;
				open = true;
				lever.GetComponent<Animation> ().Play ("Activate Lever");
				GetComponent<AudioSource> ().clip = leverClip;
				GetComponent<AudioSource> ().Play ();
				Debug.Log ("First Is Ready");
				Destroy (wall);
			}
		}
	}

	
}