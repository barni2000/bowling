using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPinGenerator : MonoBehaviour {

	public Transform bowlingPinPrefab;
	public Transform parent;

	// Use this for initialization
	void Start () {
		generatePins ();
	}

	public void generatePins() {
		int padding = 3;
		int i = 0;
		int j = 0;
		for (i = 0; i < 4; i++) {
			for (j = 0; j < 7; j++) {
				if ((j % 2 == 0 && i % 2 != 0) || (j % 2 != 0 && i % 2 == 0)) {
					if (j >= padding && j <= 7-padding) {
						Transform newBowlingPin = GameObject.Instantiate (bowlingPinPrefab, parent);
						newBowlingPin.transform.Translate (j, i, 3);
					}
				}
			}
			padding--;
		}
	}
}
