using UnityEngine;
using System.Collections;
public class Cage : MonoBehaviour {
	public AudioClip unlock;

	void OnTriggerEnter(Collider co1)
	{
		if (co1.gameObject.tag == "Cage") 
		{
			var audio = GetComponent<AudioSource> ();
			audio.PlayOneShot (unlock);
			Destroy (co1.gameObject);
		}

	}
}