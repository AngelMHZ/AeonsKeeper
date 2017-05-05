using UnityEngine;
using System.Collections;

public class tryPuzzle : MonoBehaviour {
	
	void OnTriggerEnter (Collider other) {
		if (other.GetComponent<Collider>().name == "Player") {
			Vector3 temp = GameObject.Find ("Player").transform.position;
			temp.x = 5.0f; 
			temp.y = 4.5f; 
			GameObject.Find ("Player").transform.position = temp;
			GetComponent<Renderer>().material.color = Color.gray;
		}
	}
}
