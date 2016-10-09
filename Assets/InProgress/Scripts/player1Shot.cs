﻿using UnityEngine;
using System.Collections;

public class Player1Shot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject Shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Player 1 Fire") && Time.time > nextFire) {
			//fire rate
			nextFire = Time.time + fireRate;
			Instantiate (Shot, shotSpawn.position, shotSpawn.rotation);

		}
	}
}
