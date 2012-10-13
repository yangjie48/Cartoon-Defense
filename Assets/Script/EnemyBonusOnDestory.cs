using UnityEngine;
using System.Collections;

public class EnemyBonusOnDestory : MonoBehaviour 
{
	public int enemyBonus = 5;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnDestroy()
	{
		BonusManager.bonus += enemyBonus;
	}
}
