using UnityEngine;
using System.Collections;

public class BreakFence : MonoBehaviour {
	private bool open = false;
	public Animator log;
	private float timer = 0.0f;
	private float maxWait = 0.45f;
	private bool beginTimer = false;
	public AudioClip wood;
	private bool destroyed = false;
	private Color lerpedColor = Color.white;

	public GameObject fence;

	private bool fade = false;

	private float fadeColor = 0.0f;

	public Shader transparent;

	public GameObject dust;

	Vector3 position;

	void Start(){
		float positionX = fence.transform.position.x;
		float positionY = fence.transform.position.y;
		float positionZ = fence.transform.position.z;

		transparent = Shader.Find ("Transparent/Diffuse");
		position = new Vector3 (positionX, positionY, positionZ);
	}

	void OnTriggerStay(Collider c){
		if (c.gameObject.tag == "Player") {
			if(Input.GetButtonDown ("Action") && !open && ChangePlayer.knight && !destroyed){
				beginTimer = true;
				destroyed = true;
				Invoke("Wood", 0.25f);
			}
		}
	}

	void Wood(){
		GetComponent<AudioSource> ().clip = wood;
		GetComponent<AudioSource> ().Play ();
	}

	// Update is called once per frame
	void Update () {
		if (beginTimer)
			timer += Time.deltaTime;
		if (timer >= maxWait){
			log.SetBool("Hit", true);
			KillLog();
		}

		lerpedColor = Color.Lerp (Color.white, Color.clear, 0.0f + fadeColor);

		foreach(Renderer EachMesh in fence.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = lerpedColor;
		}

		if(fade){
			fadeColor += 0.02f;
		}
	}

	void KillLog(){
		if(!fade)
			Invoke ("DustMe", 0.1f);
		fade = true;

		foreach(Renderer EachMesh in fence.GetComponentsInChildren<Renderer>()){
			EachMesh.material.shader = transparent;
		}

		foreach(Transform EachLayer in fence.GetComponentsInChildren<Transform>())
		EachLayer.gameObject.layer = 11;

		Invoke ("DestroyEverything", 2.0f);

	}

	void DustMe(){
		Instantiate (dust, position, transform.rotation);
	}
	void DestroyEverything(){
		Destroy (fence);
	}
}
