using UnityEngine;
using System.Collections;

public class CreateParticles : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Invoke ("EnableMe", 2.25f);
	}

	void EnableMe(){
		this.GetComponent<ParticleSystem>().enableEmission = true;
	}
}
