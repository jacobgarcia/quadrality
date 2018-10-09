using UnityEngine;
using System.Collections;

public class DisplayController : MonoBehaviour {
	public UISprite message1, message2;
	private bool begin = false;
	public AudioClip page;
	// Use this for initialization
	void Start () {
		message1 = GetComponent<UISprite>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Jump") && !begin) {
			GetComponent<AudioSource> ().clip = page;
			GetComponent<AudioSource> ().Play ();
			message1.enabled = false;
			message2.enabled = true;
			begin = true;
		}
		if (Input.GetButtonDown ("Jump") && begin) {
			Application.LoadLevel(1);
	
		}
	}
}
