using UnityEngine;
using System.Collections;

public class IntroScript : MonoBehaviour {

	public float scrolldown = -80f;

	public float moveTo = 370f;
	bool wait = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (wait == true)
						StartCoroutine (Wait ());


		rigidbody2D.velocity = new Vector2(0, scrolldown);

	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(2.0f);
		wait = false;
	}
}
