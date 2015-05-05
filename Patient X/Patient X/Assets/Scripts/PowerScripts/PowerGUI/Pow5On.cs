using UnityEngine;
using System.Collections;

public class Pow5On : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CharacterController.havefivepower == true)
			renderer.enabled = true;				
		
		else
			renderer.enabled = false;
		
	}
}
