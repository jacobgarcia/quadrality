using UnityEngine;
using System.Collections;

public class Opacity : MonoBehaviour {

	float x = 1;

	// Use this for initialization
	void Start () {
		//GameObject mat = this.gameObject;
		//mat.renderer.material.color.a = x;
	}
	
	// Update is called once per frame
	void Update () {
		Color color = GetComponent<Renderer>().material.color;
		color.a = .4f;
		GetComponent<Renderer>().material.color = color;

	}
}
