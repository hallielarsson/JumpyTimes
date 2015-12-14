using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public float jumpSpeed = 2.0f;
	public float walkSpeed = 1.0f;
	public Rigidbody2D phys;

	public int maxJumps = 2;
	private int jumpCount = 0;
	public bool isOnGround = false;
	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Jump ();
		}
		Walk ();
	}

	void Jump() {
		print ("JUMP!" + jumpCount);
		if (jumpCount > 0) {
			Vector2 newVelocity = new Vector2(phys.velocity.x, jumpSpeed);
			phys.velocity = newVelocity;
			jumpCount--;
		}
	}
	void Walk() {
		Vector2 newVelocity = new Vector2(Input.GetAxis("Horizontal") * walkSpeed ,phys.velocity.y);
		phys.velocity = newVelocity;
	}

	public void ResetJump() {
		print ("RESETJUMP");
		jumpCount = maxJumps;
	}
}
