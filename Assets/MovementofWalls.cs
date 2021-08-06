using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Movementof walls: Responsible for the movement of the pieces of steel that the player must dodge. Also keeps count of the total score of the game. 
/// </summary>
public class MovementofWalls : MonoBehaviour {
    // Speed of the individual piece of steel.
	public float speed = 7;
	// Current score of the running game.
    static public int score;
	// Final score of the game.
	static public int scorehit;
	// Checks whether the passed piece of steel was already counted into the score.
    bool alreadyscored = false;
	// Rigidbody of the piece of steel.
    private Rigidbody2D rigid;
	// Bool that determines whether to reset the current score to 0. Done when the game ends.
	bool resetscore;
	// Boolean that says whether the game is in a pause. 
	bool @pause;
    // Use this for initialization. Gets the rigidbody of the piece of steel.
    void Start () {
        rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {
		// Gets the latest boolean on whether the game is paued.
		@pause = Pause.pause;
		// Gets the latest boolean on whether the player has left the bounds of the game and the game should end
		resetscore = Killed.boundary;
		// Resets the score to 0 if the game should end.
		if (resetscore == true) {
			scorehit = score;
			score = 0;
			Killed.boundary = false;
		}
		// Gets the current position of the piece of steel.
        Vector2 pos = this.transform.position;
		// Destroys the object if it left the field of view of the game.
        if (pos.x < -13)
        {
            Destroy(this.gameObject);
        }
		// Gets the x-position of the player object.
		float tempx = JumpScript.xPosition;
		// By using the x-position and if it was already counted in the score the score is incremented if the player object just passed the current piece of steel.
        if (pos.x < tempx && alreadyscored == false)
        {
            score++;
            alreadyscored = true;
        }
		// If the game is not paused a force is added to the object propelling it forward.
		if (!pause)
			rigid.AddForce (new Vector2 (-speed, 0));
	}
}
