using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {
	public static Ghost current;
	public float horizontalSpeed = 1;
	public float verticalSpeed = 1;

	Rigidbody2D myBody = null;
	Transform heroParent = null;
	//SpriteRenderer myRenderer = null;
	public static Animator animator = null;

	void Awake() {
		current = this;
		
	}

	// Use this for initialization
	void Start () {
		myBody = this.GetComponent<Rigidbody2D>();
		animator = this.GetComponent<Animator> ();
		//LevelController.current.SetStartPosition(transform.position);
	}

	// Update is called once per frame
	void FixedUpdate () {
	}

	void Update()
	{


		Vector3 moveHorizontal = new Vector3(1, 0, 0) * Time.deltaTime * horizontalSpeed;
		float yValue = Input.GetAxis("Vertical");

		var vertVector = new Vector3 (0, yValue, 0) * Time.deltaTime * verticalSpeed;

		var moveVector = vertVector + moveHorizontal;
		transform.Translate (moveVector);
	}

}
