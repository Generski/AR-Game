using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerControls controls;

    [SerializeField] private float moveSpeed = 10f;
    private Vector2 move;

    private CharacterController characterController;

    private void Awake()
    {
        controls = new PlayerControls();

        characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        move = controls.Gameplay.Move.ReadValue<Vector2>();

        Vector3 movement = (move.y * transform.forward) + (move.x * transform.right);

        characterController.Move(movement * moveSpeed * Time.deltaTime);

        controls.Gameplay.ResetPos.started += context => ResetPos();
    }

    private void ResetPos()
    {
        transform.position = Vector3.zero;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
