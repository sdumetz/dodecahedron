
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sun : MonoBehaviour, ISelectHandler {
	public int size = 0;
	public GameObject model;
	private GameObject[] planets;


	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

	}
	public void OnSelect(BaseEventData eventData){
		 Debug.Log("selected a sun");
		 planets = new GameObject[size];
		 for(int i=0;i<size;i++){
			 planets[i] = create(i);
		 }
	}


	GameObject create(int i){
		GameObject res = Instantiate(model, new Vector3(i*4+8,i*4+8,0), Quaternion.identity, transform);
		return res;
	}
}
