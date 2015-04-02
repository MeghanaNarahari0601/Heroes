using UnityEngine;
using System.Collections;

public class Victim : MonoBehaviour {
	public float moveSpeed;
	public Transform player;
	private bool isFollowing;
	public Transform target;
	private float minRange = 100;
	public AudioClip Applause;
	
	void Start()
	{
		isFollowing = false;
	}
	void OnTriggerEnter(Collider co)
	{
		if (co.tag == "Player") 
		{
			var audio = GetComponent<AudioSource>();
			audio.PlayOneShot(Applause);
			isFollowing = true;
		}
	}
	void Update()
	{
		if (isFollowing == true) {
			transform.position = Vector3.MoveTowards (transform.position, player.position, moveSpeed * Time.deltaTime);
			transform.LookAt (player);
			float distance = Vector3.Distance(transform.position, target.position);
			bool tooClose = distance < minRange;
			Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
			transform.Translate(direction * Time.deltaTime);
		}

	}
}



