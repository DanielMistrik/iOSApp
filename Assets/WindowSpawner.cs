using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Window spawner: Responsible for spawning windows used in the background.
/// </summary>
public class WindowSpawner : MonoBehaviour {
	// Time since the last window spawn.
	float timecount;
	// Minimum duration between two window spawns.
	float limitforwall = 2f;
	// Window object to be generated.
	public GameObject Window;
	// Update is called once per frame
	void Update () {
		// Adds time between last window spawn.
		timecount += Time.deltaTime;
		// If time is less than minimum window duration the function ends.
		if (timecount < limitforwall)
			return;
		// Generates window object.
		GameObject window = (GameObject)Instantiate(Window, this.transform.position, Quaternion.identity);
		timecount = 0;
	}
}
