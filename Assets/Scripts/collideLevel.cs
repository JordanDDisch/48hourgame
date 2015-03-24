using UnityEngine;
using System.Collections;

public class collideLevel : MonoBehaviour {

	private int nextLevel;

	void Start() 
	{
		nextLevel = Application.loadedLevel;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && nextLevel == 0)
		{
			Application.LoadLevel(1);
		}
		else
		{
			nextLevel++;
			Application.LoadLevel(nextLevel);
		}
	}
}
