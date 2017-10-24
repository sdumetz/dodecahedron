using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Planet : MonoBehaviour {
	public float speed = 1f;
	public GameObject tile;
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
	public GameObject selected_face;

	// Use this for initialization
	void Start () {
		for(int i=0;i<12;i++){
			create(i);
		}
	}

	// Update is called once per frame
	void Update () {
		Ray ray;
    RaycastHit hit;
		if (Input.GetMouseButton(1)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      if(Physics.Raycast(ray, out hit)){
				selected_face = hit.collider.gameObject;
        Debug.Log(selected_face.name);
      }
		}
	}

	GameObject create(int i){
		GameObject res = Instantiate(this.tile, new Vector3(0, 0, 0), Quaternion.identity, transform);
		res.transform.Rotate(rotations[i],Space.Self);
		res.name = "face_"+i;
		return res;
	}

}
