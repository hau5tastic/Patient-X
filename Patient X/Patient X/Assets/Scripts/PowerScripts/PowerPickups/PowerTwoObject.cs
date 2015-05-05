using UnityEngine;
using System.Collections;

public class PowerTwoObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			CharacterController.havetwopower = true;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
