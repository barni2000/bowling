using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackGenerator : MonoBehaviour {
	public Transform trackPrefab;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 20; i++) {
			Transform trackslice = GameObject.Instantiate (trackPrefab);
			trackslice.transform.Translate (i, 0, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
