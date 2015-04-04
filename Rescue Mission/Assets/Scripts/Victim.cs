using UnityEngine;
using System.Collections;

public class Victim : MonoBehaviour {

	public GameObject GameManager;

	void OnTriggerEnter(Collider co)
	{
		if (co.tag == "Victim") 
		{
			Destroy(co.gameObject);
			var score = GameManager.GetComponent<Score> ();
			score.FlagFoundVicitm1();
		}
	}
	
}



