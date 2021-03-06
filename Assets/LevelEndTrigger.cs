﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour {
	public Collider ball;
	public GameObject gameLogic;
	public GameObject ballGenerator;

	public void OnTriggerExit(Collider other) {
		if (other.GetType() == ball.GetType()) {
			gameLogic.GetComponent<GameLogic>().nextRound();
			ballGenerator.GetComponent<BallGenerator> ().canShoot = true;
		}
	}

	public void OnTriggerEnter(Collider other) {
		if (other.GetType () == ball.GetType ()) {
			gameLogic.GetComponent<BallCameraControl>().trace(null);
		}
	}
}
