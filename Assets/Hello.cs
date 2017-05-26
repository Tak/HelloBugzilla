using UnityEngine;

public class Hello : MonoBehaviour
{
	Rect _labelRect;
	static readonly string _labelText = "Hello Bugzilla!";

	void Start ()
	{
		_labelRect = new Rect (Screen.width / 2, Screen.height / 2, Screen.width, Screen.height);
	}

	void OnGUI ()
	{
		GUI.Label (_labelRect, _labelText);
	}
}
