using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float Minutes;
	private float seconds = 0;
	private string currentTime;

	public Rect timerRect;
	public GUISkin skin;

	void Update()
	{

		if (seconds <= 0) {
			Minutes--;
			seconds = 59;
		}
		seconds -= Time.deltaTime;
		currentTime = string.Format("{0:0}:{1:0}",Minutes,seconds);
		if (Minutes <= 0) 
		{
			Minutes = 0;
			seconds = 0;

		}

	}
	void OnGUI()
	{
		GUI.Label (timerRect, currentTime, skin.GetStyle("Timer"));
	}
}
