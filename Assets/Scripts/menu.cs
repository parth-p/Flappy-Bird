using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This script shows 'tap to start menu at beginning'
public class menu : MonoBehaviour {
	void Update()
	{
		if(Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			Destroy(gameObject);
			GameObject bird = GameObject.Find("Blue_Bird3");
			birdMove targetScript = bird.GetComponent<birdMove>();
			targetScript.start = true;
		}
	}
}
