using UnityEngine;
using System.Collections;

public class ChangePlayer : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;

	public static bool knight, scientist, jumper, bolita;

	public ParticleEmitter particles;
	public GameObject particleEm;

	public AudioClip change;

	private GameObject sKnight, sScientist, sJumper, sBolita;
	private UISprite spriteKnight, spriteScientist, spriteJumper, spriteBolita;

	Vector3 particlesPosition;

	private Shader transparent;

	void Start(){
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.enabled = false;
		}

		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.enabled = false;
		}

		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.enabled = false;
		}

		knight = true;
		scientist = false;
		jumper = false;
		bolita = false;

		sKnight = GameObject.Find ("SelectionKnight");
		sScientist = GameObject.Find ("SelectionScientist");
		sJumper = GameObject.Find ("SelectionJumper");
		sBolita = GameObject.Find ("SelectionBolita");

		spriteKnight = sKnight.GetComponent<UISprite> ();
		spriteScientist = sScientist.GetComponent<UISprite> ();
		spriteJumper = sJumper.GetComponent<UISprite> ();
		spriteBolita = sBolita.GetComponent<UISprite> ();

		transparent = Shader.Find ("Transparent/Diffuse");
	}
	// Update is called once per frame
	void Update () {
		float positionX = transform.position.x;
		float positionY = transform.position.y;
		float positionZ = transform.position.z;

		particlesPosition = new Vector3 (positionX, positionY - 3, positionZ);
		if (Time.timeScale != 0) {
			if (!BolitaTime.bolitaTime) {
				if (Input.GetButtonDown ("Knight")) {
					if (!knight) {
						Particles ();
						Sound ();
						knight = true;
						foreach (Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = true;
							Invoke ("ColorMeK", 0f);
							Invoke ("NormalK", 0.1f);
							Invoke ("ColorMeK", 0.2f);
							Invoke ("NormalK", 0.3f);
						}

						scientist = false;
						foreach (Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}

						jumper = false;
						foreach (Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}

						bolita = false;
						foreach (Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}

						Selector ();
					}
				}

				if (Input.GetButtonDown ("Scientist")) {
					if (!scientist) {
						Particles ();
						Sound ();
						knight = false;
						foreach (Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
							Invoke ("ColorMeS", 0f);
							Invoke ("NormalS", 0.1f);
							Invoke ("ColorMeS", 0.2f);
							Invoke ("NormalS", 0.3f);
						}
				
						scientist = true;
						foreach (Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = true;
						}
				
						jumper = false;
						foreach (Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}
				
						bolita = false;
						foreach (Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}

						Selector ();
					}
				}

				if (Input.GetButtonDown ("Jumper")) {
					if (!jumper) {
						Particles ();
						Sound ();
						Selector ();
						knight = false;
						foreach (Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
							Invoke ("ColorMeJ", 0f);
							Invoke ("NormalJ", 0.1f);
							Invoke ("ColorMeJ", 0.2f);
							Invoke ("NormalJ", 0.3f);
						}
				
						scientist = false;
						foreach (Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}
					
						jumper = true;
						foreach (Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = true;
						}
				
						bolita = false;
						foreach (Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}

						Selector ();
					}
				}

				if (Input.GetButtonDown ("Bolita")) {
					if (!bolita) {
						Particles ();
						Sound ();
						Selector ();
						knight = false;
						foreach (Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
							Invoke ("ColorMeB", 0f);
							Invoke ("NormalB", 0.1f);
							Invoke ("ColorMeB", 0.2f);
							Invoke ("NormalB", 0.3f);
						}
				
						scientist = false;
						foreach (Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}
				
						jumper = false;
						foreach (Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = false;
						}
				
						bolita = true;
						foreach (Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()) {
							EachMesh.enabled = true;
						}

						Selector ();
					}
				}
			}
		}
	}

	void NormalK(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
	}

	void ColorMeK(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.cyan;
		}
	}

	void NormalS(){
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
	}
	
	void ColorMeS(){
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.cyan;
		}
	}

	void NormalJ(){
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
	}
	
	void ColorMeJ(){
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.cyan;
		}
	}

	void NormalB(){
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
	}
	
	void ColorMeB(){
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.cyan;
		}
	}

	void Particles(){
		Instantiate (particleEm, particlesPosition, transform.rotation);
	}

	void Sound(){
		GetComponent<AudioSource> ().clip = change;
		GetComponent<AudioSource> ().Play ();
	}

	void Selector(){
		spriteKnight.enabled = knight;
		spriteScientist.enabled = scientist;
		spriteJumper.enabled = jumper;
		spriteBolita.enabled = bolita;
	}

	void RespawningMe(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}

		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}

		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}

		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}

		Invoke ("RM1", 0.2f);

	}

	void RM1(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}

		Invoke ("RM2", 0.1f);
	}

	void RM2(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		Invoke ("RM3", 0.1f);
		
	}

	void RM3(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		Invoke ("RM4", 0.1f);
	}

	void RM4(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		Invoke ("RM5", 0.1f);
		
	}

	void RM5(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		Invoke ("RM6", 0.1f);
	}

	void RM6(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.clear;
		}
		
		Invoke ("RM7", 0.1f);
		
	}

	void RM7(){
		foreach(Renderer EachMesh in player1.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player2.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player3.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
		
		foreach(Renderer EachMesh in player4.GetComponentsInChildren<Renderer>()){
			EachMesh.material.color = Color.white;
		}
	}
}
