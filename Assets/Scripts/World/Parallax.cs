﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {
	public float slowdown = 0.5f;
	Vector3 lastPosition;
	private float yPosition;

	// Works before start
	void Awake () {
		lastPosition = Camera.main.transform.position;
		yPosition = GetComponent<Transform> ().position.y;
	}

	// Works after update
	void LateUpdate () {
		Vector3 newPosition = Camera.main.transform.position;
		Vector3 diff = newPosition - lastPosition;
		lastPosition = newPosition;

		Vector3 myPos = this.transform.position;
		myPos += slowdown * diff;

		myPos.y = yPosition;
		this.transform.position = myPos;

	}
}
