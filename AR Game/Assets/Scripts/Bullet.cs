using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = (transform.forward * moveSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Die", 3f);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
