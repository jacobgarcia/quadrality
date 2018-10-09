using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {
	private bool goDown = false;
	public float speed = 1.0f;
	public float initialPosition = 0.0f;
	public GameObject collider1;
	public AudioSource sound, fireworks;

	public GameObject fireWorks1, fireWorks2, fireWorks3, fireWorks4;

	// Use this for initialization
	void OnTriggerStay(Collider c) {
		if (c.gameObject.tag == "Player") {
			goDown = true;
			GetComponent<Collider>().GetComponent<Collider>().enabled = false;
			sound.Play ();
			fireworks.Play ();

			foreach(ParticleSystem EachParticle in fireWorks1.GetComponentsInChildren<ParticleSystem>()){
				EachParticle.enableEmission = true;
			}
			
			foreach(ParticleSystem EachParticle in fireWorks2.GetComponentsInChildren<ParticleSystem>()){
				EachParticle.enableEmission = true;
			}

			foreach(ParticleSystem EachParticle in fireWorks3.GetComponentsInChildren<ParticleSystem>()){
				EachParticle.enableEmission = true;
			}
			
			foreach(ParticleSystem EachParticle in fireWorks4.GetComponentsInChildren<ParticleSystem>()){
				EachParticle.enableEmission = true;
			}
		}
	}

	void Update(){
		if (goDown) {
			speed = speed - 0.01f;
			transform.position = new Vector3(transform.position.x, speed + initialPosition, transform.position.z);
		}
	}

}
