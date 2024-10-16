using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class characterMovement : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;

    private Vector2 currentMovement;
    private bool movementPressed;
    
    // Start is called before the first frame update

    private void Awake()
    {
        //_input.actions["Movement"].performed += OnMovementPerformed;


    }

    void Start()
    {
        _input.actions["Movement"].performed += OnMovementPerformed;
    }

    private void OnMovementPerformed(InputAction.CallbackContext context)
    {
        Debug.Log(context.ReadValueAsObject());
        currentMovement = context.ReadValue<Vector2>();
    }

    
    private void OnDestroy()
    {
        _input.actions["Movement"].performed -= OnMovementPerformed;
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 updateMovement = new Vector3(0, 0, 0);

        updateMovement.x = currentMovement.x + updateMovement.x;
        updateMovement.y = transform.position.y;
        updateMovement.z = currentMovement.y + updateMovement.z;

        transform.position = updateMovement;

    }

    
}
