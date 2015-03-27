using UnityEngine;
using System.Collections;

public class ZombieMoving : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * Time.deltaTime;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "basket") 
		{
			print("Collision");
		}
	}
}
