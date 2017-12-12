using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D collider){
		Ghost ghost = collider.GetComponent<Ghost>();
		if(ghost != null) {
			LevelController.current.OnGhostDeath(ghost);
		}
	}
}
