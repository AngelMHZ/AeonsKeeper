﻿using UnityEngine;
using System.Collections;

public class overviewWest : MonoBehaviour {
	void OnTriggerEnter (Collider other) {
		if (other.GetComponent<Collider>().name == "Player") {
			Vector3 tempCamera = GameObject.Find ("Camera").transform.position;
			tempCamera.x = tempCamera.x+5; 
			GameObject.Find ("Camera").transform.position = tempCamera;
		}
	}
	void OnTriggerExit (Collider other) {
		if (other.GetComponent<Collider>().name == "Player") {
			Vector3 tempPlayer = GameObject.Find ("Player").transform.position;
			tempPlayer.z = -5.8f; 
			GameObject.Find ("Camera").transform.position = tempPlayer;
		}
	}
}
