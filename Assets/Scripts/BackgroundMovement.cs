using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

	public GameObject backgroundA;
	public GameObject backgroundB;
	bool isBackgroundA = false;
	//public GameObject checkPoint;
	public float size =30.9f;

	float  positionA;
	float  positionB;
	//Vector3  positionCheck; 



	// Use this for initialization
	void Start () {
		positionA = backgroundA.transform.position.x;
		positionB = backgroundB.transform.position.y;
		//checkPoint = checkPoint.transform.position;		

		Debug.Log ("PositionA: " + positionA + " PositionB:" + positionB);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
