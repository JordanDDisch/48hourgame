using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {
	public GameObject player;
	public GameObject spawn;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		spawn = GameObject.FindGameObjectWithTag("Spawn");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			player.transform.position = spawn.transform.position;
		}
	}
}
