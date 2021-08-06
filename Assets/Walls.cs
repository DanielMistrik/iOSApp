using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

/// <summary>
/// Walls: Generates pieces of steel the player must dodge and keeps the current score display in the game.
/// </summary>
public class Walls : MonoBehaviour {
	// The wall object to be spawned.
    public GameObject wall;
	// Time since last wall spawn.
    float timecount;
	// Minimum duration between walll spawns
    public float limitforwall;
	// The score text count in the game.
    public TextMesh ScoreText;
	// Minimum duration between large-sized wall spawns.
	public float minbig;
	// Maximum duration between large-sized wall spawns.
	public float maxbig;
	// Minimum duration between normal-sized wall spawns.
	public float minnor;
	// Maximum duration between normal-sized wall spawn.
	public float maxnor;
	// Value above which the generated wall is big and the time between wall spawns should be increased.
	public float bigheight;
    // Update is called once per frame
    void Update() {
		// Displays the current score of the game
        int score = MovementofWalls.score;
        ScoreText.text = "" + score;
		// Adds the time since last wall was spawned  and when its less than the minimum duration between wall spawns it ends the function.
        timecount += Time.deltaTime;
        if (timecount < limitforwall)
            return;

		// Generates a wall of random size
        GameObject walli = (GameObject)Instantiate(wall, this.transform.position, Quaternion.identity);
        Vector3 ls = walli.transform.localScale;
		ls.y = Random.Range(3.7f, 0.6f);
        walli.transform.localScale = ls;
		// Resets time to 0 since last wall was generated.
        timecount = 0;
		// According to size changes the limit for wall with a random component.
		if (ls.y > bigheight)
			limitforwall = Random.Range (minbig,maxbig);
		else
			limitforwall = Random.Range(minnor,maxnor);
    }
}
