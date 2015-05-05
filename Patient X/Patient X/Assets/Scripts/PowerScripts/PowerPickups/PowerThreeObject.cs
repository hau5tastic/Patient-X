using UnityEngine;
using System.Collections;

public class PowerThreeObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			CharacterController.havethreepower = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
