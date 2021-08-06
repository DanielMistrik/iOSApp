using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Movementof wall: Responsible for the movement of the texture on the background wall object to simulate movement. 
/// </summary>
public class MovementofWall : MonoBehaviour {
	// The renderer of the object whose texture is meant to move.
	private Renderer rend;
	// The speed of the moving texture. 
	public float speed;
	// Use this for initialization. Gets the renderer of the attached object. 
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Gets the current offset of the texture.
		Vector2 uv = rend.material.mainTextureOffset;
		// Decreases the offset to simualte movement.
		uv.x -= speed * Time.deltaTime;
		// Assigns the decreased offset to the actual texture offset of the object.
		rend.material.mainTextureOffset = uv;
	}
}
