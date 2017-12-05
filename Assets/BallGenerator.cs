using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour {
	public GameObject ballPrefab;
	public GameObject gameLogic;

	public Transform mCamera;
	public float force = 1000.0f;
	public bool canShoot = true;
	float cdTime = 0;

	void Update () {
		cdTime -= Time.deltaTime;
		if((Input.GetKey(KeyCode.Space) || Input.GetAxis("Fire1") > 0) && cdTime < 0 && canShoot) {
			cdTime = 1;
			GameObject newBall = Instantiate(ballPrefab);
			Vector3 ballPos = mCamera.position;
			newBall.transform.position = ballPos;
			Rigidbody ballRB = newBall.GetComponent<Rigidbody>();
			Vector3 forceDir = mCamera.rotation * Vector3.forward;
			ballRB.AddForce(forceDir * force);
			canShoot = false;
			gameLogic.GetComponent <BallCameraControl> ().trace (newBall.transform);
		}
	}
}