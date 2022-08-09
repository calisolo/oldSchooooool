using UnityEngine;
using System.Collections;
using VRWidgets;

public class musicHandle : SliderHandleBase 
{
	public GameObject activeBar = null;
	

	public GameObject onPlay;//추가부2

	
	private void UpdateActiveBar()
	{
		onPlay = GameObject.Find ("track1");//추가부3
		
		if (activeBar)
		{
			activeBar.transform.localPosition = (transform.localPosition + lowerLimit.transform.localPosition) / 2.0f;
			Vector3 activeBarScale = activeBar.transform.localScale;
			activeBarScale.x = Mathf.Abs(transform.localPosition.x - lowerLimit.transform.localPosition.x);
			activeBar.transform.localScale = activeBarScale;

			
			onPlay.GetComponent<AudioSource> ().time = (activeBarScale.x)/4.0f * 230; //track1의 시간... peanutbutterjelly 203초
		}
		
		
		
		
	}
	
	public override void UpdatePosition(Vector3 displacement)
	{
		base.UpdatePosition(displacement);
		UpdateActiveBar();
	}
	
	public override void Awake()
	{
		base.Awake();
		UpdateActiveBar();
	}
}
