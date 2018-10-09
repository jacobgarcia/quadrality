using UnityEngine;
using System.Collections;

public class UILabelFontColor : MonoBehaviour {
	public UILabel label;

	void Start () {
		label.color = new Color (1.0f, 1.0f, 1.0f, 0.5f);
	}
}
