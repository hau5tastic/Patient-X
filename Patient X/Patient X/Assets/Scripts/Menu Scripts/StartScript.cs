using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	public void LoadScene(int level)
	{

		Application.LoadLevel (level);
	}
	
}