using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
	bool start1 = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject bird = GameObject.Find("Blue_Bird3");
		birdMove targetScript = bird.GetComponent<birdMove>();
		start1 = targetScript.start;

		if (start1)
		{
			Vector3 coord = transform.position;
			coord.z = 0;
			transform.position = coord;
		}
	}
}
