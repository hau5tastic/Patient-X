using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterController : MonoBehaviour {


	public float moveSpeed = 3f;

	public List<GameObject> prefabs1;

	//CurrentPower
	public bool onepower = true;
	public bool twopower = false;
	public bool threepower = false;
	public bool fourpower = false;
	public bool fivepower = false;

	//Powers owned
	public static bool havetwopower = false;
	public static bool havethreepower = false;
	public static bool havefourpower = false;
	public static bool havefivepower = false;


	Animator playerAnim;


	// Use this for initialization
	void Start () {
		playerAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame

	void FixedUpdate()
	{

		playerAnim.SetFloat ("VSpeed", rigidbody2D.velocity.x);
		playerAnim.SetFloat ("HSpeed", rigidbody2D.velocity.y);		


		//Moving
		float xMove = Input.GetAxis("Horizontal");
		float yMove = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2 (xMove * moveSpeed, rigidbody2D.velocity.y);
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, yMove * moveSpeed);


		//PowerSwitchingCode
		if (Input.GetKeyDown("1")&& havefivepower == true)
		{		
			fivepower = true;
			twopower = false;
			threepower = false;
			fourpower = false;
		}
		if (Input.GetKeyDown("2")&& havetwopower == true)
		{			
			onepower = false;
			twopower = true;
			threepower = false;
			fourpower = false;			
		}
		if (Input.GetKeyDown("3")&& havethreepower == true)
		{			
			onepower = false;
			twopower = false;
			threepower = true;
			fourpower = false;			
		}
		if (Input.GetKeyDown("4")&& havefourpower == true)
		{			
			onepower = false;
			twopower = false;
			threepower = false;
			fourpower = true;			
		}
	}


	void Update () {
	


	}

	private void PowerShown() {
		Instantiate (prefabs1[prefabs1.Count], new Vector3 (0f, 0f, 0f), Quaternion.identity);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		//CollisionScript
		if (collision.gameObject.name == "Two") 
		{
			havetwopower = true;
		}
		if (collision.gameObject.name == "Three") 
		{
			havethreepower = true;	
		}
		if (collision.gameObject.name == "Four") 
		{
			havefourpower = true;	
		}
		if (collision.gameObject.name == "Five") 
		{
			havefivepower = true;	
		}
	}
}
