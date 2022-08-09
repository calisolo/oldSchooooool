using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public bool isRotating = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (isRotating == true) {
			transform.Rotate (0,0,1);
		}
	
	}



}
