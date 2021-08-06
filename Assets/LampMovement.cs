using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Lamp movement: Responsible for the movement and eventual destruction of the Lamp object which serves in the background to liven up the scene.
/// </summary>
public class LampMovement : MonoBehaviour {
	// Float speed of Lamp per second
	public float lampspeed = 2;
	//Vector used for positioning of the Lamp
	Vector3 pos;
	// Gets the current position of the lamp subtracts it by the speed*seconds_since_last_frame. Checks whether the new position is out of bounds in which
	// case it destroys the object.
	void Update () {
		pos = this.transform.position;
		pos.x -= lampspeed * Time.deltaTime;
		this.transform.position = pos;
		if (pos.x < -13) {
			Destroy (this.gameObject);
		}
	}
}
