using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Load game: Used by the buffer scene to asynchronously load the actual game, the 'first' scene. Its done asynchronously to allow for some
/// entertainment if the scene is taking a long time to load. 
/// </summary>

public class LoadGame : MonoBehaviour {

	// Use this for initialization. Loads the first scene. 
	void Start () {
		SceneManager.LoadSceneAsync("First");
	}
}
