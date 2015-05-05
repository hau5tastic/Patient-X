using UnityEngine;
using System.Collections;

public class Paused : MonoBehaviour{
bool isPaused = false;

	void Start (){
		}



void Update()
{
	if(Input.GetKeyDown(KeyCode.Space))
	{
		isPaused = !isPaused;
		if(isPaused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}


}
}
