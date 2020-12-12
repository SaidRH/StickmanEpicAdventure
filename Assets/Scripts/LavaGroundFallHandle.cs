﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaGroundFallHandle : MonoBehaviour {
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent <Rigidbody2D> ();
	}
	
	void OnCollisionEnter2D(Collision2D data) { 
		if (data.gameObject.CompareTag("Player")){
			Invoke ("GroundFall",5f);
		}
	}
	void GroundFall (){
		rb.mass = 15;
	}
}