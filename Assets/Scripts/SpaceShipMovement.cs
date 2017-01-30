using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour {

    [SerializeField]
    public static float speed = 50.0f;
    public static float maxSpeed = 96f;
    private float minSpeed = 20f;

    private float decreaseSpeed = 2f;
    private float increaseSpeed = 2f;

    private float decreaseCameraDistance = 0.18f;
    private float increaseCameraDistance = 0.18f;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.W) && speed <= maxSpeed)
        {
            speed = speed + increaseSpeed;
            CamFollow.distanceAway = CamFollow.distanceAway + increaseCameraDistance;
        }
        if (Input.GetKey(KeyCode.S) && speed >= minSpeed)
        {
            speed = speed - decreaseSpeed;
            CamFollow.distanceAway = CamFollow.distanceAway - decreaseCameraDistance;
        }

        transform.position += transform.forward * Time.deltaTime * speed;

        //speed -= transform.forward.y * Time.deltaTime * 50.0f;

        transform.Rotate(Input.GetAxis("Mouse Y"), 0.0f, -Input.GetAxis("Mouse X"));
	}
}
