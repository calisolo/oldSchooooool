using UnityEngine;
using System.Collections;
using VRWidgets;

public class startButton2 : ButtonBase 
{
	public GameObject graphics2;
	public GameObject onPlay;
	public GameObject rotateItself;
	public GameObject frontLight;
	public GameObject machineLight;

	void Start()
	{
		graphics2.transform.parent = transform;
		graphics2.AddComponent<Rigidbody>();
	}
	
	
	public override void ButtonReleased()
	{
		Debug.Log("Released");
	}
	
	public override void ButtonPressed()
	{
		
		graphics2.GetComponent<Renderer> ().material.color = Color.red;
		graphics2.GetComponent<Rigidbody> ().useGravity = true;
		onPlay = GameObject.Find ("track2");
		onPlay.GetComponent<AudioSource>().Play ();  //음악 컴포넌트 실행  

		frontLight = GameObject.Find ("FrontLight");
		Vector3 temp = new Vector3 (50000.0f, 0, 0); 
		if (frontLight.GetComponent<Transform> ().position.x < 30000.0f) {
			frontLight.GetComponent<Transform> ().position += temp;
		}

		machineLight = GameObject.Find ("machineLight");
		Vector3 temp2 = new Vector3 (50000.0f, 0, 0); 
		if (machineLight.GetComponent<Transform> ().position.x >= 30000.0f) {
			machineLight.GetComponent<Transform> ().position -= temp;
		}


		
		rotateItself = GameObject.Find ("Cylinder02");
		rotateItself.GetComponent<rotate> ().isRotating = true;
		
		
		
		Debug.Log("Pressed");
		
	}
	
	public override void Update()
	{
		base.Update();
		graphics2.transform.localPosition = GetPosition();
	}
}