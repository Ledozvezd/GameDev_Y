using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(HingeJoint2D))]

class MouseClick : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    private HingeJoint2D _Connector;
    [SerializeField] private float _speed = 2;

    void Awake()
    {
        _rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        _Connector = gameObject.GetComponent<HingeJoint2D>();
    }
    void Update()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        _rigidBody2D.AddForce(new Vector2(Input.GetAxisRaw("Horizontal"), 0));
        if (Input.GetMouseButtonDown(1)==true)
        {
            _Connector.enabled = false;

        }

    }
}
