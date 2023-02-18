using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(HingeJoint2D))]

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private Rigidbody2D _rigidBody2D;
    
    private void Awake()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            var joint = _player.TryGetComponet<Rigidbody2D>(out Rigidbody2D _Rigidbody2D);
            joint.connectedBody = _rigidBody2D;
        }
    }
}
