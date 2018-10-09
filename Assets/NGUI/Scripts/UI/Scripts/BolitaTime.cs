using UnityEngine;
using System.Collections;

public class BolitaTime : MonoBehaviour {
	public GameObject player;
	public GameObject wood;
	public static bool bolitaTime = false;

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			if(ChangePlayer.bolita){
				bolitaTime = true;
			}
		}
	}

	void OnTriggerStay(Collider c){
		if (c.gameObject.tag == "Player") {
			if(ChangePlayer.bolita){
				player.layer = 10;
				bolitaTime = true;
			}
		}
	}

	void OnTriggerExit(Collider c){
		if (c.gameObject.tag == "Player") {
			player.layer = 8;
			bolitaTime = false;
		}
	}

	// Update is called once per frame
	void Start () {
		bolitaTime = false;
	}
}
