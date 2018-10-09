using UnityEngine;
using System.Collections;

public class FootSteps : MonoBehaviour {
	public AudioClip[] footsteps;
	public AudioClip[] bolita;
	public float nextFoot;
	public float nextBolita;

	// Use this for initialization
	IEnumerator Start () {
		CharacterController controller = GetComponent<CharacterController> ();
		while (true){
			if(controller.isGrounded && Mathf.Abs(controller.velocity.x) > 0.4f || controller.isGrounded && Mathf.Abs(controller.velocity.z) > 0.4f){
				if(ChangePlayer.bolita){
					GetComponent<AudioSource>().PlayOneShot(bolita[Random.Range (0, bolita.Length)]);
					yield return new WaitForSeconds(nextBolita);
				}
				else{
					GetComponent<AudioSource>().PlayOneShot(footsteps[Random.Range (0, footsteps.Length)]);
					yield return new WaitForSeconds(nextFoot);
				}
			}
			else{
				yield return 0;
			}
		}
	}

}
