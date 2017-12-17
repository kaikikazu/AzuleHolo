using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ChangeIrast : MonoBehaviour, IFocusable{
	public GameObject normal;
	public GameObject weding;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnFocusEnter(){
		gameObject.transform.parent = null;
	}
	public void OnFocusExit(){

	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.CompareTag("irast")){
			weding.gameObject.transform.parent = null;
			normal.gameObject.SetActive (false);
			weding.gameObject.SetActive (true);
			Destroy (gameObject);
		}
	}
}
