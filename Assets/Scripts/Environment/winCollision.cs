using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class winCollision : MonoBehaviour {

	public string winText;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			print ("you win");
		}
	}
}
