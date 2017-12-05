using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {
	public GameObject pins;
	public Text pointsUI;

	private int round = 0;
	public int points = 0;
	// Use this for initialization
	void Start () {
		pointsUI.text = string.Format("Round: {0} Points: {1}", this.round, this.points);
	}

	// Update is called once per frame
	void Update () {
	}

	public void nextRound() {
		var children = pins.GetComponentsInChildren<Transform> ();
		for (int i = 0; i < children.Length; i++) {
			Debug.Log ("Object:" + children[i] + " " + children [i].transform.up.x);
			if (children [i].transform.up.x < 0.5f) {
				this.points++;
				//children [0].gameObject.SetActive (false);
				pointsUI.text = string.Format ("Round: {0} Points: {1}", this.round, this.points);
			} 
		}
		round++;
	}
}
