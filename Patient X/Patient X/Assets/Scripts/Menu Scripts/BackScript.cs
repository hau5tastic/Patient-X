﻿using UnityEngine;
using System.Collections;

public class BackScript : MonoBehaviour {
	
	public void LoadScene(int level)
	{
		
		Application.LoadLevel (level);
	}
	
}