using UnityEngine;
using System.Collections;

public class BasicTower : MonoBehaviour {
	
	public GameObject bullet;
	public float bulletSpeed = 1.0f;
	public float fireRate = 1.0f;
	public float fireRadius = 5.0f;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("SpawnBullet",fireRate,fireRate);
	}
	
	void SpawnBullet()
	{
		GameObject target = null;
		//Check if the enemy in the range of tower
		foreach(Collider col in Physics.OverlapSphere(transform.position,fireRadius))
		{
			if(col.tag == "Enemy")
			{
				target = col.gameObject;
				break;
			}
		}
		
		if(target != null)
		{
			GameObject newBullet = Instantiate(bullet,transform.position,bullet.transform.rotation)  as GameObject;
			newBullet.rigidbody.AddForce((target.transform.position - transform.position).normalized * bulletSpeed,ForceMode.VelocityChange);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
