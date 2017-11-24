using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Planet : MonoBehaviour, ISelectHandler {
	public GameObject tile;
	private GameObject selected_face = null;
	private const float phi = 1.618f; //Golden ratio
	private GameObject[] faces;
	private static Vector3[] rotations = new Vector3[]{
		new Vector3(0, 0, 0),
		new Vector3(0,0,180 ),
		new Vector3(180, 0, 0 ),
		new Vector3(180, 0, 180 ),
		new Vector3(0, 90, -90 ),
		new Vector3(180, 90, -90 ),
		new Vector3(-90, 90, 0 ),
		new Vector3(-90, 90, 180 ),
		new Vector3(90, 0, 90 ),
		new Vector3(90, 0, -90 ),
		new Vector3(0, -90, -90 ),
		new Vector3(0, 90, 90 ),
	};

	// Use this for initialization
	void Start () {
		faces = new GameObject[12];
		for(int i=0;i<12;i++){
			faces[i] = create(i);
		}
	}
	// Update is called once per frame
	/*
	void Update () {
		Ray ray;
    RaycastHit hit;
		if (Input.GetMouseButtonUp(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      if(Physics.Raycast(ray, out hit)){
				GameObject o = hit.collider.gameObject;
				if (Array.Exists(faces, e => e.GetInstanceID() == o.GetInstanceID())){
					this.select(o);
				}

      }
		}
	}//*/
	public void OnSelect(BaseEventData eventData){
		Debug.Log("selected a planet");
	}
	void select(GameObject o){
		Renderer r = o.GetComponent<Renderer>();
		if (selected_face != null){
			selected_face.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
		}
		Debug.Log("Selecting : "+ o.name);
		r.material.EnableKeyword("_EMISSION");
		selected_face = o;
	}

	GameObject create(int i){
		GameObject res = Instantiate(this.tile, transform, false);
		res.transform.Rotate(rotations[i],Space.Self);
		res.name = "face_"+i;
		res.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
		return res;
	}

}
