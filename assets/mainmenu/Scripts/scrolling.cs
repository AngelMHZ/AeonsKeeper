using UnityEngine;
using System.Collections;

public class scrolling : MonoBehaviour {

	public float speed = 0;


	void Update () {
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);
	}
}
