using UnityEngine;
using System.Collections;

public class lightSystem : MonoBehaviour {

	public GameObject onPlay;
	public GameObject onPlay2;
	public GameObject frontLight;
	public GameObject redLight;
	public GameObject greenLight;
	public GameObject blueLight;
	public GameObject machineLight;
	public float timer;
	public float waitingTime;
	public GameObject people;

	// Use this for initialization
	void Start () {
		frontLight = GameObject.Find ("FrontLight");
		redLight = GameObject.Find("redLight");
		blueLight = GameObject.Find ("blueLight");
		greenLight = GameObject.Find ("greenLight");
		machineLight = GameObject.Find ("machineLight");
		onPlay = GameObject.Find ("track1");
		onPlay2 = GameObject.Find ("track2");
		people = GameObject.Find ("people");

		timer = 0.0f;
		waitingTime = 2.0f;

		Vector3 temp = new Vector3 (50000.0f, 0, 0); //rgb삼인방 시작되면 우주로 날림
		if (redLight.GetComponent<Transform> ().position.x < 30000.0f) {
			redLight.GetComponent<Transform> ().position += temp;
		}

		if (greenLight.GetComponent<Transform> ().position.x < 30000.0f) {
			greenLight.GetComponent<Transform> ().position += temp;
		}
		if (blueLight.GetComponent<Transform> ().position.x < 30000.0f) {
			blueLight.GetComponent<Transform> ().position += temp;
		}

		if (machineLight.GetComponent<Transform> ().position.x < 30000.0f) {
			machineLight.GetComponent<Transform> ().position += temp;
		}


	
	}
	
	// Update is called once per frame
	void Update () {


		Vector3 temp = new Vector3 (50000.0f, 0, 0);
		onPlay = GameObject.Find ("track1");
		onPlay2 = GameObject.Find ("track2");
		people = GameObject.Find ("people");

		timer += Time.deltaTime;


		if (people.GetComponent<AudioSource> ().isPlaying == false) {
				// 오른쪽끝으로 바떙기면 일어나는 
		}

		if (onPlay.GetComponent<AudioSource> ().isPlaying==true) {
			//시간에 따른 이벤트처리
			

			
			if (timer >= waitingTime&& timer<waitingTime*2.0f) {
				if (greenLight.GetComponent<Transform> ().position.x < 30000.0f) {
					greenLight.GetComponent<Transform> ().position += temp;
				}//greenlight를 끕니다.

				if (redLight.GetComponent<Transform> ().position.x >= 30000.0f) {
					redLight.GetComponent<Transform> ().position -= temp;
				}//redlight를 켭니다.

			}

			else if(timer>= waitingTime*2.0f &&timer<waitingTime*4.0f){
				if (redLight.GetComponent<Transform> ().position.x < 30000.0f) {
					redLight.GetComponent<Transform> ().position += temp;
				}//redlight를 끕니다.

				if (blueLight.GetComponent<Transform> ().position.x >= 30000.0f) {
					blueLight.GetComponent<Transform> ().position -= temp;
				}//bluelight를 켭니다.

			}

			else if(timer>= waitingTime*4.0f &&timer<waitingTime*6.0f){
				if (blueLight.GetComponent<Transform> ().position.x < 30000.0f) {
					blueLight.GetComponent<Transform> ().position += temp;
				}//bluelight를 끕니다.

				if (greenLight.GetComponent<Transform> ().position.x >= 30000.0f) {
					greenLight.GetComponent<Transform> ().position -= temp;
				}//greenlight를 켭니다.
				

			}

			if(timer>=12.0f)
			{
				timer =0;
			}
		


		}
	



	}
}
