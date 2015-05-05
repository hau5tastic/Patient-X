using UnityEngine;
using System.Collections;

/// <summary>
/// This is the AI script for testing.
/// The AI in this script has very basic movement. It will move from waypoint to waypoint every X amount of seconds.
/// Waypoints are invisible gameobjects that the AI will move towards. It will move in the order of the waypoints are
/// assigned to the array. If it reaches the end of the array/waypoint, it will move back towards the first waypoint array.
/// </summary>

public class TestEnemyScript : MonoBehaviour {

	//Variables start here
	public Transform[] waypoints; //The game objects the enemy will move towards
	public float timeTillNextMovement = 2; //This is measured in seconds

	public bool canMove = true;
	public bool isMoving = false;
	public float rateOfMovement = 1; //The frequency of the enemy movement. The lower the number the more frequent the movement
	public float movementSpeed = 10; //How fast the enemy moves

	public float health = 50;

	//Private variables are not shown in the inspector window. No other scripts can modify private variables
	private int currentPoint = 0; //This is the waypoint the enemy is currently on.


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (health <= 0)
		{
			Die();
		}

		if (canMove)
		{
			Movement();
		}
		
		if (isMoving)
		{
			if (transform.position != waypoints[currentPoint].transform.position)
				transform.position = Vector3.MoveTowards(transform.position, 
				                                         waypoints[currentPoint].transform.position, movementSpeed * Time.deltaTime);
			else
				isMoving = false;
		}
	}

	void Movement()
	{
		if (Time.time > timeTillNextMovement)
		{
			timeTillNextMovement = Time.time + rateOfMovement;
			if (currentPoint < waypoints.Length - 1)
			{				
				isMoving = true;
				transform.position = Vector3.MoveTowards(transform.position, waypoints[currentPoint].transform.position, movementSpeed * Time.deltaTime);
				currentPoint++;
			}
			else
			{
				currentPoint = 0;
				isMoving = true;
				transform.position = Vector3.MoveTowards(transform.position, waypoints[currentPoint].transform.position, movementSpeed * Time.deltaTime);
			}
		}
	}

	void Die()
	{
		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		Debug.Log ("Detected collision");
		if (coll.gameObject.transform.tag == "PlayerBullet")
		{
			health -= 10;
			Destroy(coll.gameObject);
		}
	}
}
