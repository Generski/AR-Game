using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Rigidbody rb;

    public Transform[] waypoints;

    [SerializeField] private float speed;

    private int waypointIndex = 1;
    private float distance;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        transform.LookAt(waypoints[waypointIndex].position);
    }

    private void FixedUpdate()
    {
        distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (distance < 1f)
        {
            UpdateWaypoints();
        }

        rb.velocity = (transform.forward * speed * Time.deltaTime);
    }

    private void UpdateWaypoints()
    {
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }
}
