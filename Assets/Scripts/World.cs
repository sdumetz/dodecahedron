using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class World : MonoBehaviour, IPointerClickHandler{
	public GameObject tile;
	private GameObject selected_system = null;
	private GameObject[] systems;

	// Use this for initialization
	void Start () {
		systems = new GameObject[1];
		systems[0] = create(0);
	}

	public void OnPointerClick(PointerEventData eventData){
    RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    if(Physics.Raycast(ray, out hit)){
			GameObject o = hit.collider.gameObject;
			EventSystem.current.SetSelectedGameObject (o);
    }

	}

	GameObject create(int i){
		return Instantiate(this.tile, transform, false);
	}

}
