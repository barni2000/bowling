using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {
	public GameObject pins;
	public GameObject pinGenerator;
	public Text pointsUI;

	private int round = 0;
	public int actualPoints = 0;
	private int points = 0;
	// Use this for initialization
	void Start () {
		pointsUI.text = string.Format("Round: {0} Points: {1}", this.round, this.points);
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void nextRound() {
		points += actualPoints;
		actualPoints = 0;
		round++;
		pointsUI.text = string.Format ("Round: {0} Points: {1}", this.round, this.points);

		if (points % 10 == 0 && points != 0) {
			pinGenerator.GetComponent<BowlingPinGenerator> ().generatePins();
		}
	}
}
