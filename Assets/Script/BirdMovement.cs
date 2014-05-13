using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {
	
	Vector3 velocity = Vector3.zero;

	public float flapSpeed = 10f;
	public float forwardSpeed = 1;
	public float maxSpeed = 200;
	bool didFlap = false;
	float timer =5f;
	bool dead = false;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
	}
	
	//Graphics &Input updates here
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0))
		{
			didFlap = true;
		}
		if (dead) {
			//timer-= Time.deltaTime;
			//if(timer<=0)
			if(Input.GetKeyDown(KeyCode.Space))
				Application.LoadLevel("Menu");
			//}
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (dead) {
						return;
				}

		velocity.x = forwardSpeed;
		
		Vector3 v = rigidbody2D.velocity;
		if (didFlap) {
			//rigidbody2D.AddForce(Vector2.up * flapSpeed);
			//velocity.y
			v.y = flapSpeed;
			rigidbody2D.velocity = v;
			animator.SetTrigger("DoFlap");
			didFlap = false;
		}
		transform.position += velocity * Time.deltaTime;
		if (rigidbody2D.velocity.y > 0) {
						transform.rotation = Quaternion.Euler (0, 0, 0);
			} else {
						float angle = Mathf.Lerp (0, -80, -rigidbody2D.velocity.y / 2);
						transform.rotation = Quaternion.Euler (0, 0, angle);
			}

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
				animator.SetTrigger ("Death");
				dead = true;
		}
}
