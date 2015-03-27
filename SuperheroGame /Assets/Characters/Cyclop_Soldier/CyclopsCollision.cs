using UnityEngine;
using System.Collections;

public class CyclopsCollision : MonoBehaviour {
	public MovingCyclops Cyclops;
	bool collided;
	public GameObject cagePatrol;

	void Start()
	{
	//	Cyclops.transform.position += Vector3.right * Time.deltaTime;
	}
	void OnTriggerEnter (Collider co)
	{
		print ("CyclopsCollision.triggerenter");
		if (co.tag == "lampost" && collided == false) 
		{
			Cyclops.CheckAndMove(co.gameObject);
			collided = true;
			print("Colliding");
		//	Cyclops.transform.Rotate(0 , 90 , 0);

		}

	}
}
	