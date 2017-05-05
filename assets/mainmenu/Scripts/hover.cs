using UnityEngine;
using System.Collections;

public class hover : MonoBehaviour {

	// Use this for initialization
	void OnMouseEnter () {
		GetComponent<Renderer>().material.color = Color.gray;
	}
	
	// Update is called once per frame
	void OnMouseExit () {
		GetComponent<Renderer>().material.color = Color.white;
	}
}
