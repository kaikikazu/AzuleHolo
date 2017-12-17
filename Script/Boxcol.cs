using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.VR.WSA.Input;

public class Boxcol : MonoBehaviour, IInputClickHandler{
	Animator _animator;
	public GameObject me;
	public bool flag;
	public int pos;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		_animator = me.GetComponent<Animator> ();
		flag = false;
		pos = 0;
		rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
		//rend.enabled = false;
		if (flag) {
			if (pos <= 100) {
				pos++;
			} else if (pos > 100 && pos <= 140) {
				me.transform.position += new Vector3 (0, -0.007f, 0);
				pos++;
			} else if (pos > 140 && pos <= 190) {
				pos++;
			} else if (pos > 190) {
				me.transform.position += new Vector3 (0, 0.007f, 0);
				pos++;
				if (pos >= 210) {
					pos = 0;
					flag = false;
				}
			}
		}
	}

	public void OnInputClicked(InputClickedEventData eventData){
		_animator.SetTrigger ("touch1");
		flag = true;
		me.gameObject.transform.parent = null;
		//Instantiate (me);
		//Destroy(gameObject,.5f);
	}
	/*
	public void OnFocusEnter(){
		_animator.SetTrigger ("touch1");
		Instantiate (gameObject);
		Destroy (gameObject);
	}
	public void OnFocusExit(){
	}
	*/
}
