using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	void Start(){
		
	}


	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Trigger enter");
		Ghost ghost = collider.GetComponent<Ghost>();
			if(ghost != null) {
				this.OnGhostHit (ghost);

			}
	}

	protected virtual void OnGhostHit (Ghost ghost){
	}

	public void CollectedHide() {
		Destroy(this.gameObject);
		}
	}

	
