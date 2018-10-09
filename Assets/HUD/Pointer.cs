using UnityEngine;
using System.Collections;

public class Pointer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Z)){
			GetComponent<GUITexture>().pixelInset = new Rect(0,0,Screen.width,Screen.height);
		}

		if(Input.GetKeyDown(KeyCode.X)){
			GetComponent<GUITexture>().pixelInset = new Rect(0,-140,Screen.width,Screen.height);
			//posY = -140;
		}

		if(Input.GetKeyDown(KeyCode.C)){
			GetComponent<GUITexture>().pixelInset = new Rect(0,-280,Screen.width,Screen.height);
			//posY = 20;
		}

		if(Input.GetKeyDown(KeyCode.V)){
			GetComponent<GUITexture>().pixelInset = new Rect(0,-410,Screen.width,Screen.height);
			//posY = 30;
		}
	
	}
}
