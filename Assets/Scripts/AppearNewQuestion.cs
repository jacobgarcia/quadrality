using UnityEngine;
using System.Collections;

public class AppearNewQuestion : MonoBehaviour {
	public UISprite message;
	public AudioClip papyrus;
	public AudioSource audio;
	public GameObject questionSystem;
	private bool timer = false;
	public static UILabel label;
	public static UISprite harvey;
	private QuestionSystem question;
	private GameObject lab, harv;

	void Awake(){
		lab = GameObject.Find("Timer");
		harv = GameObject.Find("Harvey Ball");
		label = lab.GetComponent<UILabel>();
		harvey = harv.GetComponent<UISprite> ();
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "Player" && Time.timeScale != 0) {
			Sound();
			Time.timeScale = 0.0f;
			UIButton.thisIsEnabled = true;
			question = (QuestionSystem) questionSystem.GetComponent(typeof(QuestionSystem));
			question.GenerateQuestion(this.gameObject.name);
			StartCoroutine(Skip());
		}
	}

	IEnumerator Skip(){
		float start = Time.realtimeSinceStartup;
		float myColor = 0.0f;
		label.enabled = true;
		harvey.enabled = true;
		while (Time.realtimeSinceStartup < start + 4f) {
			myColor += 0.0032f;
			int timer = (int)((start + 5) - Time.realtimeSinceStartup);
			label.text = timer.ToString();
			label.color = new Color(1.0f, 1.0f - myColor, 1.0f - myColor, 0.5f + myColor);
			yield return null;
		}

		question.ThisAnswer ("TimeIsOver");
	}




	void Sound(){
		audio.clip = papyrus;
		audio.Play ();
	}
}
