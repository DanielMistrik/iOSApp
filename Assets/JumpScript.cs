using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Jump script: Responsible for the jumping of the player. Uses forces.
/// </summary>
public class JumpScript : MonoBehaviour {
	// Force behind a single jump. The value provided is a default and never really used.
    public float jumpForce = 500000.0f;
	// The minimum duration needed between two jumps.
    public float jumpPause = 0.3f;
	// Number of jumps in register. Resets to 0 when the player touches the ground. This makes sure you can only double jump in the air.
    public int jumpCounter = 0;
	// Timestamp of last jump used in conjuction with jumpPause to determine whether a double jump is allowed.
    public float lastJump = -1;
	// The x-position of the player.
    static public float xPosition;
	// Rigid body of the player object to which the jump force is applied.
    private Rigidbody2D rigid;
	// The jump audio source through which the jump sound is player.
	private AudioSource Jump;
	// The jumpsound that is played once the player object is clicked.
	public AudioClip Jumpsound;
    // Use this for initialization. Initializes the audio source object and rigid body of the body this script is attached to.
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
		Jump = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update() {
		// Gets current position of the object this script is attached to.
        Vector2 pos = this.transform.position;
		// Checks all the conditions for jumping and verifies the user is tapping the object and then executes one jump. 
		if (Input.GetMouseButtonDown(0) && jumpCounter < 1 && (lastJump + jumpPause < Time.time || lastJump < 0))
        {
			if (!EventSystem.current.IsPointerOverGameObject (Input.GetTouch (0).fingerId)) {
				rigid.AddForce (new Vector2 (0, jumpForce));
				jumpCounter++;
				lastJump = Time.time;
				Jump.PlayOneShot (Jumpsound, 0.5f);
			}
        }
		//To get the position of the edge of the player
        Vector2 rpos = pos;
        rpos.y -= 1;
		//Used for identifying if the player object is touching another object in which case the jump counter is reset to zero.
        RaycastHit2D rayHitLeft = Physics2D.Raycast(rpos, new Vector2(0, -1));
        RaycastHit2D rayHitRight = Physics2D.Raycast(rpos, new Vector2(0, -1));
		if (rayHitLeft.distance < 0.4f || rayHitRight.distance < 0.4f)
        {
            jumpCounter = 0;
        }
        xPosition = pos.x;
	}
}