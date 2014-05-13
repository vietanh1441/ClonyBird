﻿using UnityEngine;
using System.Collections;

public class CameraTrackBird : MonoBehaviour {
	Transform player;
	float OffsetX;
	// Use this for initialization
	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");

		player = player_go.transform;

		OffsetX = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null)
		{
			Vector3 pos = transform.position;

			pos.x = player.position.x + OffsetX;
			transform.position = pos;
		}
	}
}
