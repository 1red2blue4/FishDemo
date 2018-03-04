using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmove : MonoBehaviour {


	Quaternion addRot = Quaternion.identity;
	float yaw = 0.0f;
	float pitch = 0.0f;
	float roll = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") > 0) 
		{
			transform.position += transform.forward * 15.0f * Time.deltaTime;
		}
		else if (Input.GetAxis("Vertical") < 0) 
		{
			transform.position -= transform.forward * 15.0f * Time.deltaTime;
		}

		yaw = Input.GetAxis("Horizontal") * 60.0f * Time.deltaTime;
		roll = Input.GetAxis("Roll") * 60.0f * Time.deltaTime;
		pitch = Input.GetAxis("Pitch") * 60.0f * Time.deltaTime;

		addRot.eulerAngles = new Vector3(pitch, yaw, roll);
		transform.rotation *= addRot;

		/*
		if (Input.GetAxis("Horizontal") > 0) 
		{
			transform.Rotate(transform.up * 60.0f * Time.deltaTime);
		}
		else if (Input.GetAxis("Horizontal") < 0) 
		{
			transform.Rotate(-transform.up * 60.0f * Time.deltaTime);
		}
		if (Input.GetAxis("Roll") > 0) 
		{
			transform.Rotate(transform.forward * 60.0f * Time.deltaTime);
		}
		else if (Input.GetAxis("Roll") < 0) 
		{
			transform.Rotate(-transform.forward * 60.0f * Time.deltaTime);
		}
		if (Input.GetAxis("Pitch") > 0) 
		{
			transform.Rotate(transform.right * 60.0f * Time.deltaTime);
		}
		else if (Input.GetAxis("Pitch") < 0) 
		{
			transform.Rotate(-transform.right * 60.0f * Time.deltaTime);
		}
		*/
	}
}
