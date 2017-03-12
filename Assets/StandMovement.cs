using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class StandMovement : MonoBehaviour {

	int leftIndex = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost);

	SteamVR_Controller.Device leftDevice;
	Vector2 leftAxis;

	void Start ()
	{
		leftDevice = SteamVR_Controller.Input(leftIndex);
		leftAxis  = leftDevice.GetAxis();
	}

	// Update is called once per frame
	void Update () {

		if (leftDevice.GetPressDown(EVRButtonId.k_EButton_A))
		{
			GetComponentInParent<Transform> ().Translate (new Vector3(leftAxis.x,0,leftAxis.y));
		}
		else if (GetComponentInParent<Transform> ().localPosition != Vector3.zero) 
		{
			GetComponentInParent<Transform> ().localPosition = Vector3.zero;
		}
	}
}
