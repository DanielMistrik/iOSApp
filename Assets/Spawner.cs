using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawner: Responsible for spawning lamps.
/// </summary>
public class Spawner : MonoBehaviour {
	// Time since the last lamp was spawned.
	float timecount;
	// Sets a minimum time duration limit between the spawning of two lamps.
	float limitforwall = 2f;
	// The lamp object that is to be continually spawned.
	public GameObject lampObj;
	// Update is called once per frame
	void Update () {
		// Increases the time between the last lamp was spawned.
		timecount += Time.deltaTime;
		// If the the time limit is smaller than the limitforwall the function ends.
		if (timecount < limitforwall)
			return;
		// Creates a new lamp
		GameObject lamp = (GameObject)Instantiate(lampObj, this.transform.position, Quaternion.identity);
		timecount = 0;
	}
}
