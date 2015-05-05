using UnityEngine;
using System.Collections;

public class PlayerCombatScript : MonoBehaviour {

	public float rateOfFire = 0.5f;
	public GameObject bullet;
	private float nextFire = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//This method is called repeatedly
		Shooting();

	
	}

	//This method is used for checking the input the player wants to shoot towards
	//then fire in that direction
	void Shooting()
	{
		if (Input.GetButton("FireUp"))
		{
			//Make the player shoot up.
			//Prevent the player from firing again until a certain amount of time based on rate of fire

			if (Time.time > nextFire)
			{
				nextFire = Time.time + rateOfFire;

				Instantiate(bullet, transform.position, Quaternion.Euler(0,0,0));
			}
			
			//Make the player face up for 0.5 seconds after firing
		}
		else if (Input.GetButton("FireDown"))
		{
			if (Time.time > nextFire)
			{
				nextFire = Time.time + rateOfFire;
				
				Instantiate(bullet, transform.position, Quaternion.Euler(0,0,180));
			}
		}
		else if (Input.GetButton("FireLeft"))
		{
			if (Time.time > nextFire)
			{
				nextFire = Time.time + rateOfFire;
				
				Instantiate(bullet, transform.position, Quaternion.Euler(0,0,90));
			}
		}
		else if (Input.GetButton("FireRight"))
		{
			if (Time.time > nextFire)
			{
				nextFire = Time.time + rateOfFire;
				
				Instantiate(bullet, transform.position, Quaternion.Euler(0,0,270));
			}
		}
	}
}
