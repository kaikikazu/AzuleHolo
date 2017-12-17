using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour {
	Animator Irast_animator;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		Irast_animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("ring")) {
			Irast_animator.SetTrigger ("touch3");
		}
	}
}
