using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioClip))]
public class Cage : MonoBehaviour {
	public AudioClip unlock;

	void OnTriggerEnter(Collider co1)
	{
		if(co1.gameObject.tag == "Cage")		
		{
			print ("Destroyed");
			Destroy(co1.gameObject);
			GetComponent<AudioSource>().PlayOneShot(unlock,1);
		}
	}
}