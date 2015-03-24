using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

	public GameObject Player;
	public GameObject spawn;

	void Start() 
	{
		Player = GameObject.FindGameObjectWithTag("Player");
		spawn = GameObject.FindGameObjectWithTag("Spawn");
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy(this.gameObject, 1f);
			Player.transform.position = spawn.transform.position;
		}
	}

	void Update() 
	{
		Destroy(this.gameObject, 2f);
	}
}
