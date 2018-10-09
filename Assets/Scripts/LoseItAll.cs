using UnityEngine;
using System.Collections;

public class LoseItAll : MonoBehaviour {
	private GameObject obj;
	private UISprite sprite;
	private int numberSprite;

	// Use this for initialization
	void Start () {
		numberSprite = Random.Range (1, 27);
		obj = GameObject.Find ("" + numberSprite);
		sprite = obj.GetComponent<UISprite> ();
		sprite.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Application.LoadLevel("SecondLevelFine");
			
		}
	}
}
