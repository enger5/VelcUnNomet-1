using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour 
{
	//Entering the game
	public void OnMouseDown()
	{
		SceneManager.LoadScene (1);
	}
	//Exit the game
	public void ExitClick()
	{
		SceneManager.LoadScene (0);
	}
}
