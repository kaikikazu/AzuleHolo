using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class Anim : MonoBehaviour, IInputClickHandler, IFocusable, ISourceStateHandler{
	Animator _animator;
	public GameObject me;
	public bool flag;
	public int pos;
	public bool EyeFlag;
	public float lookTime;
	public bool AnimFlag;
	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
		flag = false;
		pos = 0;
		EyeFlag = false;
		lookTime = 0;
		AnimFlag = false;
	}

	// Update is called once per frame
	void Update () {
		if (EyeFlag) {
			lookTime += Time.deltaTime;
			Debug.Log (lookTime);
			if(lookTime >= 10 && lookTime <= 11){
				flag = true;
				_animator.SetTrigger ("touch2");
				gameObject.transform.parent = null;
			}
		}
		/*Down Action
		if (flag) {
			if (pos <= 100) {
				pos++;
			} else if (pos > 100 && pos <= 140) {
				transform.position += new Vector3 (0, -0.007f, 0);
				pos++;
			} else if (pos > 140 && pos <= 190) {
				pos++;
			} else if (pos > 190) {
				transform.position += new Vector3 (0, 0.007f, 0);
				pos++;
				if (pos >= 210) {
					pos = 0;
					flag = false;
					gameObject.transform.parent = null;
				}
			}
		}
		*/
	}

	public void OnInputClicked(InputClickedEventData eventData){
		_animator.SetTrigger ("touch1");
		flag = true;
		gameObject.transform.parent = null;
		/*
		GameObject copy = gameObject;
		copy.transform.localScale = gameObject.transform.localScale;
		Destroy(gameObject);
		*/
	}

	public void OnFocusEnter(){
		EyeFlag = true;
		Debug.Log (lookTime);
		Debug.Log ("Enter");
	}
	public void OnFocusExit(){
		EyeFlag = false;
		Debug.Log ("Exit");
	}

	public void OnSourceDetected(SourceStateEventData eventData){
		//_animator.SetTrigger ("touch2");
		//gameObject.transform.parent = null;
	}
	public void OnSourceLost(SourceStateEventData eventData){
		//if (flag) {
			//_animator.SetTrigger ("touch2");
			//gameObject.transform.parent = null;
		}
	//}
}
