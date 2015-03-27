using UnityEngine;
using System.Collections;

public class MovingCyclops : MonoBehaviour {
	public Vector3 currentDirection;
	public GameObject[] PatrolPoints;
    int currentPatrol;

	void Start()
	{
		currentPatrol = 0;
	}

	void Update () {
		//transform.position += currentDirection * Time.deltaTime;
		print ("patrol points length:" + PatrolPoints.Length);
	/*	if (transform.position == PatrolPoints[currentPatrol].transform.position) {
			currentPatrol++;		
		}
		*/
		print ("currentPatrol" + currentPatrol);
		transform.position = Vector3.MoveTowards(transform.position, PatrolPoints[currentPatrol].transform.position, 2 * Time.deltaTime);
	}

	public void CheckAndMove(GameObject collisionObject)
	{
		print ("***** In collision ****");
		if (collisionObject == PatrolPoints [currentPatrol]) {
			print ("collied with patrol point");
			currentPatrol++;
			transform.Rotate(0,90, 0);
		}
	}

}
