using UnityEngine;
using System.Collections;

public class SecretColliderThree : MonoBehaviour {
	public static bool ready = false;
	public AudioClip secretRevealed;
	public GameObject mannequin;

	void Start(){
		foreach(Renderer Eachmesh in mannequin.GetComponentsInChildren<Renderer>()){
			Eachmesh.enabled = false;
		}
	}

	void OnTriggerEnter(Collider c){
		if(SecretColliderTwo.third){
			if (c.gameObject.tag == "Player") {
				if(!ready && ChangePlayer.bolita){
					ready = true;
					GetComponent<AudioSource> ().clip = secretRevealed;
					GetComponent<AudioSource> ().Play ();
					Visible();
				}
			}
		}
	}

	// Update is called once per frame
	void Visible (){
		foreach(Renderer Eachmesh in mannequin.GetComponentsInChildren<Renderer>()){
			Eachmesh.enabled = true;
		}
		Debug.Log ("HE Is Ready");
	}
}
