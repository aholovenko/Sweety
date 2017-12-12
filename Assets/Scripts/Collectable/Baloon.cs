using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon : Collectable {

	protected override void OnGhostHit(Ghost ghost){
		LevelController.current.elixirLost();
		CollectedHide ();
	}
}
