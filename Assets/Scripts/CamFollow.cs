﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    [SerializeField]
    public static float distanceAway;
    [SerializeField]
    public static float distanceUp;
    [SerializeField]
    private float smooth;
    [SerializeField]
    private Transform follow;

    private Vector3 height = new Vector3(0,10,0);
    private Vector3 targetPosition;

    // Use this for initialization
    void Start () {
        follow = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        targetPosition = follow.position + follow.up * distanceUp - follow.forward * distanceAway;
        Debug.DrawRay(follow.position, Vector3.up * distanceUp, Color.red);
        Debug.DrawRay(follow.position, -1f * follow.forward * distanceAway, Color.blue);
        Debug.DrawLine(follow.position, targetPosition, Color.magenta);

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);

        transform.LookAt(follow);
	}
}
