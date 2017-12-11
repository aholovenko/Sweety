using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFollow : MonoBehaviour {

	public Ghost ghost;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () {
		
		Transform rabbit_transform = ghost.transform;
		Transform camera_transform = this.transform;

		Vector3 rabbit_position = rabbit_transform.position;
		Vector3 camera_position = camera_transform.position;

		camera_position.x = rabbit_position.x;

		camera_transform.position = camera_position;
	}
}
