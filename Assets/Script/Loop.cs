using UnityEngine;
using System.Collections;

public class Loop : MonoBehaviour {

	float numPanel = 6;

	float pipeMax = -0.1880913f ;
	float pipeMin = -0.9335532f ;

	void Start() {
		GameObject[] pipes = GameObject.FindGameObjectsWithTag ("Pipe");

		foreach(GameObject pipe in pipes)
		{
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range (pipeMin, pipeMax);
			pipe.transform.position = pos;
		}
	}

	void OnTriggerEnter2D(Collider2D  collider) {
		float widthofObject = ((BoxCollider2D)collider).size.x;
		Vector3 pos = collider.transform.position;
		pos.x += widthofObject * numPanel;

		if (collider.tag == "Pipe") 
		{
			pos.y = Random.Range (pipeMin, pipeMax);
		}

		collider.transform.position = pos;

	}
}
