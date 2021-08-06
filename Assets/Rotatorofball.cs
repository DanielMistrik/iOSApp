using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotatorofball: Rotates the cardboard box in the buffer scene to entertain the user while the game is being loaded.
/// </summary>
public class Rotatorofball : MonoBehaviour {
	// Speed of rotation
	public float rotationSpeed;
	// Rotation of the object
	Quaternion rotation;
	// Update is called once per frame
	void Update () {
		// Get the current rotation of the box object.
		rotation = this.transform.localRotation;
		Vector3 er = rotation.eulerAngles;
		// Changes the rotation.
		er.z += (rotationSpeed * Time.deltaTime)%180;
		rotation.eulerAngles = er;
		// Applies the changed rotation.
		this.transform.localRotation = rotation;

	}
}
