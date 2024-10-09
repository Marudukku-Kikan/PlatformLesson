using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PlayerCamera : MonoBehaviour
{
    
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;

    [SerializeField] private float _mouseX; 
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        transform.position = _player.position;

        //transform.Rotate(Vector3.up, _speed * Time.deltaTime);
        
        
        _mouseX = Input.GetAxis("Mouse X");
        
        
        
        Debug.Log(_mouseX);
        
        transform.Rotate(Vector3.up, _mouseX * _speed * Time.deltaTime);
    }
}
