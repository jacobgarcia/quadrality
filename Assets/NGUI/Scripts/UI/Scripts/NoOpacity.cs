using UnityEngine;
using System.Collections;

public class NoOpacity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Color color = GetComponent<Renderer>().material.color;
		color.a = 1;
		GetComponent<Renderer>().material.color = color;
	}
}
