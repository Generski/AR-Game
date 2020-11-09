using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private SphereCollider collider;

    private Rigidbody rb;

    private void Start()
    {
        collider = GetComponent<SphereCollider>();

        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (collider.enabled == true)
        {
            rb.velocity = -50f * Vector3.up * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pickup")
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            Destroy(other.gameObject);
        }
    }
}
