using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Go back to menu: Used by the buttons that get the user back to the menu from the lost/died scene. 
/// </summary>
public class GoBackToMenu : MonoBehaviour {
	// On click of the button the main menu scene is loaded. 
	public void OnClick()
	{
		SceneManager.LoadScene ("Menu");
	}
}
