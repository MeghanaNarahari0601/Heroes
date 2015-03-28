using UnityEngine;
using System.Collections;
public class Cage : MonoBehaviour {
	public AudioClip unlock;

	void OnTriggerEnter(Collider co1)
	{
		if(co1.gameObject.tag == "Cage")		
		{
			print ("Destroyed");
			Destroy(co1.gameObject);
			var audio = GetComponent<AudioSource>();
			audio.PlayOneShot(unlock);
		}
	}
}