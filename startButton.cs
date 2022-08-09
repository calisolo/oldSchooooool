using UnityEngine;
using System.Collections;
using VRWidgets;

public class startButton : ButtonBase 
{
	public GameObject graphics;
	public GameObject onPlay;
	public GameObject rotateItself;
	public GameObject lightSystem;
	public GameObject frontLight;
	public GameObject machineLight;
	public GameObject redLight;


	void Start()
	{
		graphics.transform.parent = transform;
		graphics.AddComponent<Rigidbody>();
	}


	public override void ButtonReleased()
	{
		Debug.Log("Released");
	}
	
	public override void ButtonPressed()
	{


		graphics.GetComponent<Renderer> ().material.color = Color.red;
		graphics.GetComponent<Rigidbody> ().useGravity = true;
		onPlay = GameObject.Find ("track1");
		onPlay.GetComponent<AudioSource>().Play ();  //음악 컴포넌트 실행  

		frontLight = GameObject.Find ("FrontLight");
		Vector3 temp = new Vector3 (50000.0f, 0, 0); 
		if (frontLight.GetComponent<Transform> ().position.x < 30000.0f) {
			frontLight.GetComponent<Transform> ().position += temp;
		}//음악이 켜져있을경우 frontlight를 안드로메다로 날려버

		machineLight = GameObject.Find ("machineLight");
		Vector3 temp2 = new Vector3 (50000.0f, 0, 0); 
		if (machineLight.GetComponent<Transform> ().position.x >= 30000.0f) {
			machineLight.GetComponent<Transform> ().position -= temp;
		}//기계등 돌아와라 !!! 


		/*
		float timer;
		float waitingTime;
		timer = 0.0f;
		waitingTime = 2.0f;
		
		timer += Time.deltaTime;
		onPlay = GameObject.Find ("track1");
		redLight = GameObject.Find("redLight");
		
		if (onPlay.GetComponent<AudioSource> ().isPlaying==true) {
			//시간에 따른 이벤트처리
			
			
			
			if (timer >= waitingTime) {
				if (redLight.GetComponent<Transform> ().position.x >= 30000.0f) {
					redLight.GetComponent<Transform> ().position -= temp;
				}//redlight를 켭니다.
				
			}
			
			if(timer>= waitingTime*2.0f){
				if (redLight.GetComponent<Transform> ().position.x < 30000.0f) {
					redLight.GetComponent<Transform> ().position += temp;
				}//redlight를 끕니다.
				
				timer =0.0f;
			}
			
			
		}
*/













		rotateItself = GameObject.Find ("Cylinder20");
		rotateItself.GetComponent<rotate> ().isRotating = true;
	


		Debug.Log("Pressed");

	}
	
	public override void Update()
	{
		base.Update();
		graphics.transform.localPosition = GetPosition();
	}
}
