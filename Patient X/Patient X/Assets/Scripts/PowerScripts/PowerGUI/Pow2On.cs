using UnityEngine;
using System.Collections;

public class Pow2On : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CharacterController.havetwopower == true)
			renderer.enabled = true;				

		else
			renderer.enabled = false;

	}
}
