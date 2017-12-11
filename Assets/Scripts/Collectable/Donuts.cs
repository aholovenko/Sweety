using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donuts : MonoBehaviour {

	void Start(){

	}


	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Trigger enter");
		Ghost ghost = collider.GetComponent<Ghost>();
		if(ghost != null) {
			this.OnGhostHit (ghost);

		}
	}

   void OnGhostHit (Ghost ghost){
			CollectedHide ();
		}

	public void CollectedHide() {
		Destroy(this.gameObject);
	}
}


