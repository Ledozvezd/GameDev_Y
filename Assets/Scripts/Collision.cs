using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(HingeJoint2D))]
public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private Rigidbody2D _rigidBody2D;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player") == false)
        {
            return;
        }

        if (other.TryGetComponent(out HingeJoint2D joint))
        {
            if (joint.connectedBody == null)
            {
                joint.enabled = true;
                joint.connectedBody = _rigidBody2D;
            }
        }
    }
}
