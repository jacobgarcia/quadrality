using UnityEngine;
using System.Collections;

public class TransparentSprite : MonoBehaviour {
	// Use this for initialization
	public UISprite sprite;

	void Start () {
		/*SpriteRenderer.color = new Color (1f, 1f, 1f, .5f);*/
		sprite.color = new Color (1f, 1f, 1f, 0.8f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
