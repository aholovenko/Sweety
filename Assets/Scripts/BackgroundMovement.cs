using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

	public GameObject backgroundA;
	public GameObject backgroundB;
	bool isBackgroundA = true;
	//public GameObject checkPoint;
	public float size =30.9f;

	float  positionA;
	float  positionB;
	//Vector3  positionCheck; 



	// Use this for initialization
	void Start () {
		positionA = backgroundA.transform.position.x;
		positionB = backgroundB.transform.position.x;
			

		Debug.Log ("PositionA: " + positionA + " PositionB:" + positionB);
	}
	
	// Update is called once per frame
	void Update () {
		backgroundA.SetActive (false);
		positionA = backgroundA.transform.position.x;
		positionB = backgroundB.transform.position.x;
		if (isBackgroundA && Ghost.current.transform.position.x < positionA) {
			backgroundB.transform.position = new Vector3 (positionA-2*size, 0f, 0f);
			Debug.Log ("double background");
			isBackgroundA = !isBackgroundA;
		}
		if (!isBackgroundA && Ghost.current.transform.position.x < positionB) {
			backgroundA.transform.position = new Vector3 (positionA-2*size, 0f, 0f);
			Debug.Log ("double background");
			isBackgroundA = !isBackgroundA;
		}
	}
}
