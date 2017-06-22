﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    private GameObject target;
    private float despawn = 0f;

	void Start () {
        this.target = GameObject.FindGameObjectWithTag("Pet");	
	}
	
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.up, 50f * Time.deltaTime);
        transform.LookAt(Vector3.up);

        if (this.despawn >= 60f)
        {
            Destroy(gameObject);
        }

        this.despawn += Time.deltaTime;
	}
}
