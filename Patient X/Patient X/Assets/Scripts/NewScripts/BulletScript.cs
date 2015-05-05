using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float bulletSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
	
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		//CollisionScript
		if (collision.gameObject.tag == "Enemy") 
		{
			Destroy(gameObject);
		}
		if (collision.gameObject.tag == "Boundary" || collision.gameObject.tag == "Door") 
		{
			Destroy(gameObject);
		}
	}
}
