using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// It adds +1 to score on passing through pipes
public class scoreAdd : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			scoreBoard.AddPoint();
			//gameObject.SetActive(false);
		}
	}
}
