
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sun : MonoBehaviour {
	public int size = 0;
	public GameObject model;
	private GameObject[] planets;


	// Use this for initialization
	void Start () {
		planets = new GameObject[size];
		for(int i=0;i<size;i++){
			planets[i] = create(i);
		}
	}
	// Update is called once per frame
	void Update () {

	}

	GameObject create(int i){
		GameObject res = Instantiate(model, new Vector3(i*4+8,i*4+8,0), Quaternion.identity, transform);
		return res;
	}
}
