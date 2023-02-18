using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(HingeJoint2D))]
class MouseClick : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidBody2D;
    private HingeJoint2D _joint;
    private BoxCollider2D _chain;


    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _joint = GetComponent<HingeJoint2D>();

    }

    private void Update()
    {
        Swing();
        UnHook();
    }

    private void Swing()
    {
        float direction = Input.GetAxis("Horizontal");

        _rigidBody2D.AddForce(new Vector2(direction, 0) * _speed * Time.deltaTime);
    }

    private void UnHook()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _joint.enabled = false;
            _joint.connectedBody = null;
        }
    }
}
