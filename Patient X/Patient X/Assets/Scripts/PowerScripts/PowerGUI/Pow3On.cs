using UnityEngine;
using System.Collections;

public class Pow3On : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CharacterController.havethreepower == true)
			renderer.enabled = true;				
		
		else
			renderer.enabled = false;
		
	}
}
