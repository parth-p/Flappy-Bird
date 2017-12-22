using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This script is for movement of cload
public class cloudmove : MonoBehaviour {
	bool dead1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!dead1)
		{
			Vector3 pos = transform.position;
			pos.x -= 0.1f;
			transform.position = pos;

			if (transform.position.x <= -13)
			{
				Vector3 pos1 = transform.position;
				pos1.x = 13;
				transform.position = pos1;
			}
			GameObject bird = GameObject.Find("Blue_Bird3");
			birdMove targetScript = bird.GetComponent<birdMove>();
			dead1 = targetScript.dead;
		}
	}
}
