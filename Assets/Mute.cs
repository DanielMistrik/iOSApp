using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Mute: Responsible for muting the sound and changing the visibility of the accompanying buttons.
/// </summary>
public class Mute : MonoBehaviour {
	// The mute button that is sensitive to clicks. Is transparent so it needs a visible counterpart so the player knows where to click.
	public GameObject MuteButton;
	// The unmute button that is sensitive to clicks. Is transparent so it needs a visible counterpart so the player knows where to click.
	public GameObject UnMuteButton;
	// The visible counterpart of the mute button.
	public GameObject MuteObject;
	// The visible counterpart of the unmute button.
	public GameObject UnMuteObject;
	// Function triggered by clicking the mute button. Hides the mute objects and makes the unmute objects visible.
	public void Muter ()
	{
		AudioListener.pause = true;
		MuteButton.SetActive (false);
		UnMuteButton.SetActive (true);
		MuteObject.SetActive (false);
		UnMuteObject.SetActive (true);
	}
	// Function triggered by clicking the unmute utton. Hides the unmute objects and makes the mute objects visible.
	public void UnMuter()
	{
		AudioListener.pause = false;
		MuteButton.SetActive (true);
		UnMuteButton.SetActive (false);
		MuteObject.SetActive (true);
		UnMuteObject.SetActive (false);
	}

}
