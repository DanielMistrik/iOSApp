using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Click to play: Used by the buttons that start the actual game by launching the buffer scene.
/// </summary>
public class ClickToPlay : MonoBehaviour {
	// When the button is clicked the buffer scene is launched.
	public void OnClick()
	{
		
		SceneManager.LoadScene ("BufferScene");

	}
}
