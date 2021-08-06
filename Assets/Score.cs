using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Score: Manages the scoring of the game and displays the score along with the highscore in the lose/died menu. 
/// </summary>
public class Score : MonoBehaviour {
	// Use this for initialization
	int Highscore;
	void Start () {
		// Gets the current highscore of the game.
		Highscore = PlayerPrefs.GetInt ("HighScore");
		// Gets the final score of the game that just ended
		int score = MovementofWalls.scorehit;
		// If the last score was higher than the current highscore the highscore is changed.
		if (score > Highscore)
		{
			PlayerPrefs.SetInt ("HighScore", score);
		}
		// Displays the highscore along with the current score.
		Highscore = PlayerPrefs.GetInt ("HighScore");
		Text scoredisplay = this.gameObject.GetComponent<Text> ();
		scoredisplay.text = "HigHScore:" + Highscore + " Score:" + score; 
	}
}
