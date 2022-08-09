using UnityEngine;
using System.Collections;
using VRWidgets;

public class speedHandle2 : SliderHandleBase 
{
	public GameObject activeBar = null;
	
	
	public GameObject onPlay;//추가부2
	
	
	private void UpdateActiveBar()
	{
		onPlay = GameObject.Find ("track2");//추가부3
		
		if (activeBar)
		{
			activeBar.transform.localPosition = (transform.localPosition + lowerLimit.transform.localPosition) / 2.0f;
			Vector3 activeBarScale = activeBar.transform.localScale;
			activeBarScale.x = Mathf.Abs(transform.localPosition.x - lowerLimit.transform.localPosition.x);
			activeBar.transform.localScale = activeBarScale;
			
			
			onPlay.GetComponent<AudioSource> ().pitch = ((activeBarScale.x)-2.0f)*0.15f +1.0f; //track1의 속도... peanutbutterjelly 203초
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
