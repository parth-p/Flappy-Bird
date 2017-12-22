using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is for working of the textmesh
public class scoreBoard : MonoBehaviour {
	static int score = 0;
	bool dead1 = false;
	private void Start()
	{
		score = 0;
	}
	// Update is called once per frame
	void Update () {
		//t.text = "Score" + score; 	
		GetComponent<TextMesh>().text = "Score : "+score;
		GameObject bird = GameObject.Find("Blue_Bird3");
		birdMove targetScript = bird.GetComponent<birdMove>();
		dead1 = targetScript.dead;

		if (dead1)
		{
			GetComponent<TextMesh>().text = "        RIP \n" + "    Score : " + score;

			Vector3 pos = transform.position;
			pos.x = -1;
			pos.y = 0.5f;
			transform.position = pos;
			GetComponent<TextMesh>().text += "\n Tap to Restart";
		}
	}

	static public void AddPoint()
	{
		score++;
	}
}
