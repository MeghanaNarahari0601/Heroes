using UnityEngine;
using System.Collections;

public class Victim : MonoBehaviour {
	public float moveSpeed;
	public Transform player;
	private bool isFollowing;
	
	void Start()
	{
		isFollowing = false;
	}
	void OnTriggerEnter(Collider co)
	{
		if (co.tag == "Player") 
		{
			isFollowing = true;
		}
	}
	void Update()
	{
		if (isFollowing == true) {
			transform.position = Vector3.MoveTowards (transform.position, player.position, moveSpeed * Time.deltaTime);
			transform.LookAt(player);
		} 
		else 
		{
		
		}
	}
}
