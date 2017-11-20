using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {
	public GameObject target;
	public float speedMod = 20f;
	private Vector3 point;
	// Use this for initialization
	void Start () {
		point = target.transform.position;
		transform.LookAt(point);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) && !Input.GetMouseButtonDown(0)){
			float x = Input.GetAxis("Mouse X");
			float y = Input.GetAxis("Mouse Y");
			transform.RotateAround (point,new Vector3(0.0f,1.0f,0.0f),x*speedMod);
			transform.RotateAround (point,-transform.right,y*speedMod);
		}
	}
}
