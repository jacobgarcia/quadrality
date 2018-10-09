using UnityEngine;
using System.Collections;

public class Appear : MonoBehaviour {
	public UISprite message;
	public UILabel label;
	public static bool isStopped = false;
	private bool hasStopped = false;
	public AudioClip papyrus;
	public AudioSource audio;

	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "Player") {
			Sound();
			message.enabled = true;
			Time.timeScale = 0;
			StartCoroutine(Skip());
		}
	}

	IEnumerator Skip(){
		float start = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup < start + 2.5f)
			yield return null;

		label.enabled = true;
		isStopped = true;
		hasStopped = true;
	}

	void ContinueGame(){
		isStopped = false;
		Destroy(this.gameObject);
	}

	void Sound(){
		audio.clip = papyrus;
		audio.Play ();
	}

	void Update(){
		if (Input.GetButtonDown ("Jump") && hasStopped) {
			label.enabled = false;
			Time.timeScale = 1.0f;
			Sound();
			message.enabled = false;
			Invoke("ContinueGame", 0.2f);
		}
	}
	

}
