using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public Rigidbody clone;
	public Rigidbody projectile;
	private Vector3 bullet_velocity;
	public Transform pointer;
	public int speed;
	public float shootTime;
	private float _lastShotTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > _lastShotTime + (shootTime / speed)) {
			_lastShotTime = Time.time;
			shootObject();
		}
	}

	private void shootObject() {
		print (transform.position);
		clone = Instantiate(projectile, transform.position + transform.up*0.25f, transform.rotation) as Rigidbody;
		bullet_velocity = (pointer.position - transform.position).normalized * speed;
		clone.velocity = bullet_velocity;
	}
}
