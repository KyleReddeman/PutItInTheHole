﻿using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        //Time.timeScale = 0;
        Application.LoadLevel("level_1");
    }
}
