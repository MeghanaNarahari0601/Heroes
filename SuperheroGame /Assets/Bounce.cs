using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

	Vector3 spawn;

	// Use this for initialization
	void Start () {

		spawn = transform.position;
	
	}

	
void OnCollisionEnter(Collision collide)
{
	//if(collide.gameObject.tag == "Floor")
	{
		transform.position = spawn;
			print ("in collision");
	}

}



}
