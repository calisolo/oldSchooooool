using UnityEngine;
using System.Collections;
using VRWidgets;

public class musicHandle2 : SliderHandleBase 
{
	public GameObject activeBar = null;
	
	

	public GameObject onPlay2;//추가부5
	
	private void UpdateActiveBar()
	{

		onPlay2 = GameObject.Find ("track2");//추가부4
		
		if (activeBar)
		{
			activeBar.transform.localPosition = (transform.localPosition + lowerLimit.transform.localPosition) / 2.0f;
			Vector3 activeBarScale = activeBar.transform.localScale;
			activeBarScale.x = Mathf.Abs(transform.localPosition.x - lowerLimit.transform.localPosition.x);
			activeBar.transform.localScale = activeBarScale;
			
			
			onPlay2.GetComponent<AudioSource> ().time = (activeBarScale.x)/4.0f * 326; //track1의 시간... peanutbutterjelly 203초
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
