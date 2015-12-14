using UnityEngine;
using System.Collections;

public class FeetScipt : MonoBehaviour {

	public Character pc;
	public Renderer view;

	void Start() {

		view.GetComponent<Renderer> ();
	}
	void OnTriggerEnter2D(Collider2D collider) {
		print ("FEET");
		GameObject collidedWith = collider.gameObject;
		print("TAG:" + collidedWith.name);
		pc.isOnGround = true;
		pc.ResetJump();
	}
	void OnTriggerExit2D(Collider2D collider) {
		GameObject collidedWith = collider.gameObject;
		pc.isOnGround = false;
	}


}
