using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour {

	public float speed = 1;

	Rigidbody2D myBody = null;
	Transform heroParent = null;
	//SpriteRenderer myRenderer = null;
	public static Animator animator = null;

	// Use this for initialization
	void Start () {
		myBody = this.GetComponent<Rigidbody2D>();
		animator = this.GetComponent<Animator> ();
		//LevelController.current.SetStartPosition(transform.position);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = new Vector3(0, 1, 0);
		this.transform.Translate ( move * Time.deltaTime * speed);
	}
}
