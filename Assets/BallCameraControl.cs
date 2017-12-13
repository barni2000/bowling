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
			ballCamera.transform.position = new Vector3 (
				ball.transform.position.x+10,
				ball.transform.position.y+10,
				ball.transform.position.z
			);
		}
	}

	public void trace(Transform ball) {
		if (ball != null) {
			this.ball = ball;
		}
		canTrace = !canTrace;
		mainCamera.enabled = !canTrace;
		ballCamera.enabled = canTrace;
	}
}
