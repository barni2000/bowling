using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCameraControl : MonoBehaviour {
	private bool canTrace = false;
	private Transform ball;
	public Camera ballCamera;
	public Camera mainCamera;
	// Use this for initialization
	void Start () {
		ballCamera.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (canTrace) {
			//ballCamera.transform.Translate(ball.transform);
			//ballCamera.transform.up
			//transform.y = ball.y;
			//transform.z = ball.y;
		}
	}

	public void trace(Transform ball) {
		this.ball = ball;
		canTrace = !canTrace;
		//mainCamera.enabled = !canTrace;
		//ballCamera.enabled = canTrace;
		Debug.Log ("Toggle Trace");
	}
}
