using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCounter : MonoBehaviour {
	public Collider pin;
	public GameObject gameLogic;

	public void OnTriggerExit(Collider other) {
		if (other.GetType() == pin.GetType()) {
			Debug.Log ("Fall");
			int points = gameLogic.GetComponent<GameLogic> ().actualPoints++;
			Debug.Log (points);
		}
	}
}
