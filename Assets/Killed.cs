using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Killed: Checks whether the player object is out of bounds in which case it ends the game and loads the died/lost menu. 
/// </summary>
public class Killed : MonoBehaviour {
	// Vector to be used for the current position of the player object.
	Vector3 pos;
	// Boolean that determines whether the player object is out of bounds. Used by the MovementofWalls script.
	public static bool boundary;
	// The maximum distance at which the game stops.
	public float max;
	// Update is called once per frame
	void Update () {
		// Gets the current position of the player object
		pos = this.transform.position;
		// Checks whether the player is out of bounds in which case it ends the game and loads the died/lost menu.
		if (pos.x <= max || pos.y >= 10) {
			AudioListener.pause = false;
			SceneManager.LoadScene ("Died Menu");
			boundary = true;
		}
	}
}
