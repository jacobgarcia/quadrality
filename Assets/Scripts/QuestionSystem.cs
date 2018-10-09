using UnityEngine;
using System.Collections;
using System.Linq;

public class QuestionSystem : MonoBehaviour {
	private string value;
	private int numberOfQuestions = 24;
	private int[] questionsPool;
	private GameObject obj;
	private UISprite sprite;
	private int numberQuestion = 1;
	public GameObject particles;
	public GameObject player;
	private string questionCollider = "";
	public UISprite message;
	public UILabel correct, incorrect, timeOver;
	public AudioSource audio2D;
	public AudioClip correctSE, incorrectSE, laugh, fireSE;

	void Awake(){
		questionsPool = new int[numberOfQuestions];
		for (int i = 0; i < numberOfQuestions; i++) {
			questionsPool[i] = i + 1;
		}
	}

	void Sound(AudioClip clip){
		audio2D.clip = clip;
		audio2D.Play();
	}

	 IEnumerator ContinueGame(UILabel label){
		float start = Time.realtimeSinceStartup;
		label.enabled = true;
		while (Time.realtimeSinceStartup < start + 1f)
			yield return null;

		label.enabled = false;
		message.enabled = false;
		Time.timeScale = 1.0f;
	}

	IEnumerator SoundEffect(AudioSource audio3D){
		float start = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup < start + 1f)
			yield return null;

		audio3D.clip = fireSE;
		audio3D.Play ();
	}

	private void ItIsWrong(UILabel label){
		Sound(incorrectSE);
		StartCoroutine(ContinueGame(label));
		
		/* Mistakes */
		Sound(laugh);
		Vector3 realPosition = new Vector3(-0.7f, 3, player.transform.position.z + 3);
		GameObject fire = Instantiate(particles, realPosition, Quaternion.Euler(-90.0f, -180.0f, -180.0f)) as GameObject;
		AudioSource audio3D = fire.GetComponent<AudioSource>();
		StartCoroutine(SoundEffect(audio3D));
		Destroy(fire,4.3f);
	}

	public void ThisAnswer(string answer){
		UIButton.thisIsEnabled = false;
		AppearNewQuestion.label.enabled = false;
		AppearNewQuestion.harvey.enabled = false;
		SpriteEnabled ();
		Destroy (GameObject.Find (questionCollider));

		message.enabled = true;

		if (answer.Equals (value)) {
			Sound(correctSE);
			StartCoroutine(ContinueGame(correct));
		} 
		else if (answer.Equals("TimeIsOver")) {
			ItIsWrong(timeOver);
		} else
			ItIsWrong(incorrect);
	}

	public void GenerateQuestion(string col){
		numberQuestion = questionsPool[Random.Range (0, questionsPool.Length)];
		questionCollider = col;
		switch (numberQuestion) {
		case 1:
			value = "Verdadero";
			break;
		case 2:
			value = "Verdadero";
			break;
		case 3:
			value = "Verdadero";
			break;
		case 4:
			value = "Verdadero";
			break;
		case 5:
			value = "Falso";
			break;
		case 6:
			value = "Falso";
			break;
		case 7:
			value = "Verdadero";
			break;
		case 8:
			value = "Falso";
			break;
		case 9:
			value = "Falso";
			break;
		case 10:
			value = "Falso";
			break;
		case 11:
			value = "Verdadero";
			break;
		case 12:
			value = "Verdadero";
			break;
		case 13:
			value = "Falso";
			break;
		case 14:
			value = "Falso";
			break;
		case 15:
			value = "Falso";
			break;
		case 16:
			value = "Falso";
			break;
		case 17:
			value = "Falso";
			break;
		case 18:
			value = "Falso";
			break;
		case 19:
			value = "Falso";
			break;
		case 20:
			value = "Verdadero";
			break;
		case 21:
			value = "Verdadero";
			break;
		case 22:
			value = "Verdadero";
			break;
		case 23:
			value = "Verdadero";
			break;
		case 24:
			value = "Verdadero";
			break;
		}

		obj = GameObject.Find ("" + numberQuestion);
		sprite = obj.GetComponent<UISprite> ();
		sprite.enabled = true;

		var list = questionsPool.ToList ();
		list.Remove (numberQuestion);
		questionsPool = list.ToArray ();
	}

	public void SpriteEnabled(){
		sprite.enabled = false;
	}
}
