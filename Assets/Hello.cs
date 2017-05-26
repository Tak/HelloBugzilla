using UnityEngine;

public class Hello : MonoBehaviour
{
	Rect _labelRect;
	static readonly string _labelText = "Hello Bugzilla!";
	public float QuitAfterElapsedSeconds;

	void Start ()
	{
		_labelRect = new Rect (Screen.width / 2, Screen.height / 2, Screen.width, Screen.height);
	}

	void OnGUI ()
	{
		GUI.Label (_labelRect, _labelText);
	}

	void Update ()
	{
		if (Time.timeSinceLevelLoad > QuitAfterElapsedSeconds)
		{
			Debug.LogFormat ("Ran for {0} seconds, quitting", QuitAfterElapsedSeconds);
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#else
			Application.Quit();
			#endif
		}
	}
}
