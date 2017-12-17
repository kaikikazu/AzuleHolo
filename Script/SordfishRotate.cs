using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SordfishRotate : MonoBehaviour {
	private int flag;
	// Use this for initialization
	void Start () {
		flag = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 2, 0));
		if (flag <= 50) {
			transform.position += new Vector3 (0, 0.005f, 0);
			flag++;
		}else if(flag > 50){
			transform.position += new Vector3 (0, -0.005f, 0);
			flag++;
			if(flag >= 100){
				flag = 0;
			}
		}
	}
}
