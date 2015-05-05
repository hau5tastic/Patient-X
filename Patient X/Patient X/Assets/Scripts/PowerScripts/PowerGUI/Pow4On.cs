using UnityEngine;
using System.Collections;

public class Pow4On : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CharacterController.havefourpower == true)
			renderer.enabled = true;				
		
		else
			renderer.enabled = false;
		
	}
}
