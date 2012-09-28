using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour 
{
	
	public int life = 10;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
		
	//When bullet hits enemy
	void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.tag == "Bullet")
		{
			life--;
			Destroy(collision.collider.gameObject);
		}
		
		if(life <= 0)
		{
			Destroy(gameObject);
		}
	}
}
