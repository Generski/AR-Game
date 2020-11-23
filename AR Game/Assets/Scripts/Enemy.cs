using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim;

    private Transform playerPos;

    private void Start()
    {
        anim = GetComponent<Animator>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("PlayerInRange", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("PlayerInRange", false);
        }
    }

    private void FixedUpdate()
    {
        transform.LookAt(playerPos);
    }
}
