using UnityEngine;
using System.Collections;

public class BonusManager: MonoBehaviour 
{
	public float initialBonus = 50;
	public GameObject bonusDisplay;
	
	public static float bonus;

	// Use this for initialization
	void Start () 
	{
		bonus = initialBonus;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		bonusDisplay.GetComponent<TextMesh>().text = bonus.ToString();	
	}
}
