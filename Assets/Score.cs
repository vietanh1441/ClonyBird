using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	static public int scorel = 0;

	void Start()
	{
		scorel = 0;
	}
	static public void AddPoint()
	{
				scorel++;
	}
	// Update is called once per frame
	void FixedUpdate () {
		guiText.text = "Score: " + scorel;
	
	}
}
