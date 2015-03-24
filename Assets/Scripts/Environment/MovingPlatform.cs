using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {
	public Transform[] movepoints;
	public float moveSpeed;
	private int currentPoint;


	// Use this for initialization
	void Start () {
		transform.position = movepoints[0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position == movepoints[currentPoint].position) {
			currentPoint++;
		}
		if(currentPoint >= movepoints.Length){
			currentPoint = 0;
		}

		transform.position = Vector3.MoveTowards(transform.position, movepoints[currentPoint].position, moveSpeed * Time.deltaTime);
	}

}
