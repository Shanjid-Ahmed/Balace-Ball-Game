using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject ball = GameObject.Find("Ball");
		Vector3 ballPosition = ball.transform.position;
		this.gameObject.transform.position = new Vector3(ballPosition.x - 3f, ballPosition.y + 1f, ballPosition.z);
	}
}
