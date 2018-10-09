using UnityEngine;
using System.Collections;

public class TransparentAnswer : MonoBehaviour {
	// Use this for initialization
	public UISprite sprite;

	void Start () {
		sprite.color = new Color (1f, 1f, 1f, 0.4f);
	}
}
