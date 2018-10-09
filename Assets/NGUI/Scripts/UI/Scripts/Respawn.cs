using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
	public GameObject player;
	private float timer = 0.0f;
	private float blinkTime = 0.2f;
	private bool startBlink = false;
	public AudioClip beep;

	public GameObject particleEm;

	private Vector3 position;

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			player.transform.position = new Vector3(Checkpoint.posX, Checkpoint.posY, Checkpoint.posZ);
			startBlink = true;
			player.SendMessage("RespawningMe");
			GetComponent<AudioSource> ().clip = beep;
			GetComponent<AudioSource> ().Play ();
			position = new Vector3(Checkpoint.posX, Checkpoint.posY - 3, Checkpoint.posZ);
			Invoke ("Particles", 0.2f);
		}
	}

	void Particles(){
		Instantiate (particleEm, position, transform.rotation);
	}
}
