using UnityEngine;
using System.Collections;

public class DisplayController2 : MonoBehaviour {
	private UISprite message;
	private int cont = 0;
	public AudioClip page;
	private bool begin = false;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Jump") && !begin) {
			cont++;
			GetComponent<AudioSource>().clip = page;
			GetComponent<AudioSource>().Play ();

			GameObject mess = GameObject.Find(cont.ToString());
			message = mess.GetComponent<UISprite>();
			message.enabled = false;

			if(cont == 2)
				begin = true;
		}
		if (Input.GetButtonDown ("Jump") && begin)
			Application.LoadLevel(4);
	}
}
