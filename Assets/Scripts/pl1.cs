using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This script is for the movement of the pipes
public class pl1 : MonoBehaviour
{
	int v1 = 3;
	bool dead1 ;
	bool start1 = true;
	public Vector3 coordinate;
	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		GameObject bird = GameObject.Find("Blue_Bird3");
		birdMove targetScript = bird.GetComponent<birdMove>();
		start1 = targetScript.start;
		if (!dead1 && start1)
		{
			Vector3 pos = transform.position;
			pos.x -= v1 * Time.deltaTime;
			transform.position = pos;
			
			if (transform.position.x <= -15)
			{
				Vector3 pos1 = transform.position;
				pos1.x = coordinate.x;
				transform.position = pos1;
			}
			dead1 = targetScript.dead;
		}
	}
}
