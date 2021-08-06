using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pause: Controls whether the game is paused and the appropriate button visibilities.
/// </summary>

public class Pause : MonoBehaviour {
	// Visible counterpart of the pause button.
	public GameObject Pauser;
	// Visible counterpart of the unpause button.
	public GameObject Unpause;
	// The pause button. Is transparent so needs a visible counterpart.
	public GameObject PauseButton;
	// The unpause button. Is transparent so needs a visible counterpart.
	public GameObject UnPauseButton;
	// The boolean that determines whether the game is paused or not. Used by scripts like Movement of Walls.
	static public bool @pause = false;
	// The function that is triggered by clicking on the pause button. Will pause the game and hide pause buttons and objects and make the unpause objects and buttons visible.
	public void OnPause()
	{
		Time.timeScale = 0;
		@pause = true;
		Pauser.SetActive (false);
		Unpause.SetActive (true);
		UnPauseButton.SetActive (true);
		PauseButton.SetActive (false);
	}
	// The function that is triggered by clicking on the unpause button. Will unpause the game and hide unpause buttons and objects and make the pause objects and buttons visible.
	public void UnPause()
	{
		Time.timeScale = 1;
		@pause = false;
		Pauser.SetActive (true);
		Unpause.SetActive (false);
		PauseButton.SetActive (true);
		UnPauseButton.SetActive (false);
	}
}
