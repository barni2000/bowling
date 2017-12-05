using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse Look")]
public class CameraControl : MonoBehaviour {
	void Update () {
		float moveSpeed = 10;
		float dt = Time.deltaTime;
		Vector3 move = new Vector3(0,0,0);
		if (Input.GetAxis ("Horizontal") < 0) {
			move = move + new Vector3(-1,0,0);
		}
		else if(Input.GetAxis ("Horizontal") > 0) {
			move = move + new Vector3(1,0,0);
		}

		move.Normalize();
		transform.Translate(move * dt * moveSpeed);

		float rotateSpeed = 2.0f;
		if (Input.GetAxis ("Mouse X") > 0) {
			transform.RotateAround(Vector3.up, dt * rotateSpeed);
		}
		if (Input.GetAxis ("Mouse X") < 0) {
			transform.RotateAround(Vector3.up,-dt * rotateSpeed);
		}
	}
}