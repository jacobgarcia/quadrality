using UnityEngine;
using System.Collections;

public class DisplayController3 : MonoBehaviour {
	public UISprite message1, message2;
	private bool begin = false;
	// Use this for initialization
	void Start () {
		message1 = GetComponent<UISprite>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Jump") && !begin) {
			Application.LoadLevel(0);
		}
	}
}
