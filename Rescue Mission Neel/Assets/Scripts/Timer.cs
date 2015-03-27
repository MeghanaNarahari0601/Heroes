using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float startTime;
	private string currentTime;

	public Rect timerRect;
	public GUISkin skin;

	void Update()
	{
		startTime -= Time.deltaTime;
		currentTime = startTime.ToString ();
		if (startTime <= 0) 
		{
			startTime = 0;
			Application.Quit();
		}

	}
	void OnGUI()
	{
		GUI.Label (timerRect, currentTime);
	}
}
