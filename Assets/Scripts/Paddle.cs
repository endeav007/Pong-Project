using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float speed = 10.0f;

    private void Awake()
    {
        //how we establish a reference to our rigid body
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
