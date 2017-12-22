using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is for movement of the bird
public class birdMove : MonoBehaviour {
	public Vector3 gvelocity = Vector2.zero;
	public Vector3 gravity ;
	public Vector3 velocity ;
	Animator animator;
	int x = 0;
	bool flap = false;
	public bool dead = false;
	public bool start = true;
	float timer = 1;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		//Destroy(gameObject);
		if (dead && start)
		{
			timer -= Time.deltaTime;

			if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
				Application.LoadLevel(Application.loadedLevel);//for restart if bird is dead
		}
		else
		{
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
			{
				flap = true;
			}
		}
	}

	void FixedUpdate()
	{
		if (dead && start)
		{
			Vector2 pos = transform.position;
			transform.position = pos;
			transform.rotation = Quaternion.Euler(0, 0, 0);

			if (transform.position.y >= -1.9)
			{
				Vector3 pos1 = transform.position;
				pos1.y -= 0.1f;
				transform.position = pos1;
			}
		}

		else if (!dead && start)
		{
			gvelocity += gravity * Time.deltaTime;
			if (flap)
			{

				animator.SetTrigger("do");//if bird dies animation changes
				gvelocity = Vector2.zero;
				flap = false;
				gvelocity += velocity;
				//transform.rotation = Quaternion.Euler(0, 0, 0);
				transform.Rotate(0, 0, 0);
			}
			transform.position += gvelocity * Time.deltaTime;// movement of bird

			if (gvelocity.y > 0)
				transform.rotation = Quaternion.Euler(0, 0, 0);
			else
			{
				float angle = Mathf.Lerp(0, -90, -gvelocity.y / 4f);// rotation of bird on falling
				transform.rotation = Quaternion.Euler(0, 0, angle);
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		transform.Rotate(0, 0, 0);
		animator.SetTrigger("death"); // dies on collision
		dead = true;
	}
}
